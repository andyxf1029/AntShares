﻿using AntShares.Core;
using AntShares.Core.Scripts;
using AntShares.Cryptography.ECC;
using AntShares.IO;
using AntShares.Wallets;
using System;
using System.IO;

namespace AntShares.Network.Payloads
{
    public class ConsensusPayload : Inventory
    {
        public uint Version;
        public UInt256 PrevHash;
        public uint Height;
        public ushort MinerIndex;
        public uint Timestamp;
        public byte[] Data;
        public Script Script;

        public override InventoryType InventoryType => InventoryType.Consensus;

        public override Script[] Scripts
        {
            get
            {
                return new[] { Script };
            }
            set
            {
                if (value.Length != 1) throw new ArgumentException();
                Script = value[0];
            }
        }

        public override void Deserialize(BinaryReader reader)
        {
            ((ISignable)this).DeserializeUnsigned(reader);
            if (reader.ReadByte() != 1) throw new FormatException();
            Script = reader.ReadSerializable<Script>();
        }

        public override void DeserializeUnsigned(BinaryReader reader)
        {
            Version = reader.ReadUInt32();
            PrevHash = reader.ReadSerializable<UInt256>();
            Height = reader.ReadUInt32();
            MinerIndex = reader.ReadUInt16();
            Timestamp = reader.ReadUInt32();
            Data = reader.ReadVarBytes();
        }

        public override UInt160[] GetScriptHashesForVerifying()
        {
            if (Blockchain.Default == null)
                throw new InvalidOperationException();
            if (PrevHash != Blockchain.Default.CurrentBlockHash)
                throw new InvalidOperationException();
            ECPoint[] miners = Blockchain.Default.GetMiners();
            if (miners.Length <= MinerIndex)
                throw new InvalidOperationException();
            return new[] { Contract.CreateSignatureContract(miners[MinerIndex]).ScriptHash };
        }

        public override void Serialize(BinaryWriter writer)
        {
            ((ISignable)this).SerializeUnsigned(writer);
            writer.Write((byte)1); writer.Write(Script);
        }

        public override void SerializeUnsigned(BinaryWriter writer)
        {
            writer.Write(Version);
            writer.Write(PrevHash);
            writer.Write(Height);
            writer.Write(MinerIndex);
            writer.Write(Timestamp);
            writer.WriteVarBytes(Data);
        }

        public override bool Verify()
        {
            if (Blockchain.Default == null) return false;
            if (!Blockchain.Default.Ability.HasFlag(BlockchainAbility.TransactionIndexes) || !Blockchain.Default.Ability.HasFlag(BlockchainAbility.UnspentIndexes))
                return false;
            if (PrevHash != Blockchain.Default.CurrentBlockHash)
                return false;
            if (Height != Blockchain.Default.Height + 1)
                return false;
            return this.VerifySignature();
        }
    }
}

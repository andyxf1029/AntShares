﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntShares.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AntShares.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 交易构造完成，但没有足够的签名：.
        /// </summary>
        internal static string IncompletedSignatureMessage {
            get {
                return ResourceManager.GetString("IncompletedSignatureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 签名不完整.
        /// </summary>
        internal static string IncompletedSignatureTitle {
            get {
                return ResourceManager.GetString("IncompletedSignatureTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 您已取消了证书安装过程。.
        /// </summary>
        internal static string InstallCertificateCancel {
            get {
                return ResourceManager.GetString("InstallCertificateCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 安装证书.
        /// </summary>
        internal static string InstallCertificateCaption {
            get {
                return ResourceManager.GetString("InstallCertificateCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 小蚁需要安装Onchain的根证书才能对区块链上的资产进行认证，是否现在就安装证书？.
        /// </summary>
        internal static string InstallCertificateText {
            get {
                return ResourceManager.GetString("InstallCertificateText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 余额不足，无法创建交易。.
        /// </summary>
        internal static string InsufficientFunds {
            get {
                return ResourceManager.GetString("InsufficientFunds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 交易已发送，这是交易编号(TXID)：.
        /// </summary>
        internal static string SendTxSucceedMessage {
            get {
                return ResourceManager.GetString("SendTxSucceedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 交易成功.
        /// </summary>
        internal static string SendTxSucceedTitle {
            get {
                return ResourceManager.GetString("SendTxSucceedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 区块链未同步完成，无法发送该交易。.
        /// </summary>
        internal static string UnsynchronizedBlock {
            get {
                return ResourceManager.GetString("UnsynchronizedBlock", resourceCulture);
            }
        }
    }
}

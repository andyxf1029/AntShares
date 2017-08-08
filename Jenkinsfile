pipeline {
  agent any
  stages {
    stage('1') {
      steps {
        echo 'test'
      }
    }
    stage('2') {
      steps {
        mail(subject: 'gogo', body: 'gogo', to: 'andyxf1029@outlook.com')
      }
    }
  }
}
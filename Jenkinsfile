pipeline {
    agent any 

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Restore') {
            steps {
                script {
                    sh 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                
                script {
                    sh 'dotnet build'
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    sh 'dotnet test --logger "nunit;LogFilePath=test-results.xml"'
                }
            }
        }
    }
}
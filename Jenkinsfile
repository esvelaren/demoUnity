pipeline {
    agent any

    // environment {
    //     ANDROID_HOME = "/path/to/your/android/sdk" // Update this to your Android SDK path
    // }

    stages {
        // stage('Checkout') {
        //     steps {
        //         git branch: 'main', url: 'https://github.com/esvelaren/demoUnity.git'
        //     }
        // }
        
        stage('Build for Windows') {
            steps {
                script {
                    bat """
                    "C:\\Program Files\\Unity\\Hub\\Editor\\2021.2.19f1\\Editor\\Unity.exe" -quit -batchmode -projectPath "${WORKSPACE}\\First Test Game" -executeMethod BuildScript.BuildWindows -logFile build_windows.log
                    """
                }
            }
        }
        
        // stage('Build for Android') {
        //     steps {
        //         script {
        //             def unityPath = tool 'Unity 2021.2.19f1' // Get the Unity tool path
        //             sh """
        //             export ANDROID_HOME=${ANDROID_HOME}
        //             ${unityPath}/Editor/Unity -quit -batchmode -projectPath ${WORKSPACE} -executeMethod BuildScript.BuildAndroid -buildTarget Android -logFile build_android.log
        //             """
        //         }
        //     }
        // }
    }

    post {
        always {
            echo 'Succeded Building...'
            archiveArtifacts artifacts: '**/WindowsBuild/**', allowEmptyArchive: true
            // junit 'build_*.log'
        }
        failure {
            echo 'Failed Building...'
            // mail to: 'youremail@example.com',
            //      subject: "Build Failed: ${currentBuild.fullDisplayName}",
            //      body: "Something is wrong with the build.\nCheck console output at ${env.BUILD_URL}"
        }
    }
}

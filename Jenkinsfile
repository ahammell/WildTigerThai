node {
 	// Clean workspace before doing anything
    deleteDir()

    try {
        stage ('Clone') {
        	checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'WipeWorkspace'], [$class: 'RelativeTargetDirectory', relativeTargetDir: 'C:\\Users\\Geranis\\Documents\\WildTigerThai\\'], [$class: 'RelativeTargetDirectory', relativeTargetDir: 'C:\\Users\\Geranis\\Documents\\WildTigerThaiLive\\'], [$class: 'CheckoutOption', timeout: 3], [$class: 'CloneOption', depth: 0, noTags: false, reference: '', shallow: false, timeout: 3]], submoduleCfg: [], userRemoteConfigs: [[credentialsId: 'cbeebf34-eb5c-47a8-803b-6ba334475f3f', url: 'https://github.com/ahammell/WildTigerThai']]])

        }
        stage ('Build') {
        	sh "echo 'shell scripts to build project...'"
        }
      	stage ('Deploy') {
            sh "echo 'shell scripts to deploy to server...'"
      	}
    } catch (err) {
        currentBuild.result = 'FAILED'
        throw err
    }
}





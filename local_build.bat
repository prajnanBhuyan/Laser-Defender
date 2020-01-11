echo "For generating the manual activation file use:"
echo "Unity.exe -quit -batchmode -nographics -logFile stdout.log -createManualActivationFile"

"C:\Program Files\Unity\Editor\Unity.exe" -quit -batchmode -logFile stdout.log -executeMethod WebGLBuilder.build
EXIT
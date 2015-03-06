
echo "creating unitypackage for SOOMLA Core"

"C:\Program Files (x86)\Unity\Editor\Unity.exe" -batchmode -logFile create_unity.log -projectPath %CD%/Soomla -exportPackage Assets %CD%/soomla-unity3d-core.unitypackage -quit

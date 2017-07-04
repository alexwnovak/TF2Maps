@Echo off

echo =========================================
echo  Syncing Manitou props from Propper...
echo =========================================

REM Materials

rmdir "C:\TF2\Maps\jump_manitou\Content\materials\jump_manitou\models" /s /q
xcopy "C:\Program Files (x86)\Steam\steamapps\sourcemods\propper\materials\jump_manitou\models\*.*" "C:\TF2\Maps\jump_manitou\Content\materials\jump_manitou\models\" /E /Y

REM Models

rmdir "C:\TF2\Maps\jump_manitou\Content\models\jump_manitou\props" /s /q
xcopy "C:\Program Files (x86)\steam\steamapps\sourcemods\propper\models\jump_manitou\*.*" "C:\TF2\Maps\jump_manitou\Content\models\jump_manitou\" /E /Y

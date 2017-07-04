@Echo off

echo ================================
echo  Removing Manitou Content...
echo ================================

REM Materials

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\nightocean*"
rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_manitou" /s /q

REM Configs

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_manitou_level_sounds.txt"

REM Models

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\models\jump_manitou" /s /q 2\tf\models\jump_manitou\" /E /Y

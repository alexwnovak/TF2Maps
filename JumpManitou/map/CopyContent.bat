@Echo off

echo ================================
echo  Copying Manitou Content...
echo ================================

REM Materials

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_manitou" /s /q
xcopy Content\materials\jump_manitou "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_manitou\" /E /Y
xcopy Content\materials\skybox\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\" /E /Y

REM Configs

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_manitou_level_sounds.txt"
copy Content\maps\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps" /Y

REM Models

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\models\jump_manitou" /s /q
xcopy Content\models\jump_manitou\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\models\jump_manitou\" /E /Y

@Echo off

echo ================================
echo  Removing Sobel Content...
echo ================================

REM Materials

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_sobel" /s /q
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\ridgebk.*"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\ridgedn.*"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\ridgeft.*"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\ridgelf.*"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\ridgert.*"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\ridgeup.*"

REM Configs

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_sobel_level_sounds.txt"

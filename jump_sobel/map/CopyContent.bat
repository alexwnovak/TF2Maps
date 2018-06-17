@Echo off

echo ================================
echo  Copying Sobel Content...
echo ================================

REM Materials

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_sobel" /s /q
xcopy Content\materials\jump_sobel "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_sobel\" /E /Y
xcopy Content\materials\skybox\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\skybox\" /E /Y

REM Configs

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_sobel_level_sounds.txt"
copy Content\maps\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps" /Y

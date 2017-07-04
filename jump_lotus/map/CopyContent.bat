@Echo off

echo ==============================
echo  Copying Lotus content...
echo ==============================

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_lotus" /s /q
xcopy Content\materials\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\" /E /Y

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_lotus_level_sounds.txt"
copy Content\maps\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps" /Y

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\jump_lotus.cfg"
copy Content\cfg\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg" /Y

echo.
echo ========
echo  Done!
echo ========

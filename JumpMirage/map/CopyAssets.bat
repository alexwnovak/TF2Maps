@Echo off

echo ==============================
echo  Copying Mirage materials...
echo ==============================

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_mirage" /s /q
xcopy Content\materials\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\" /E

echo.
echo ===============================
echo  Copying Mirage map config...
echo ===============================

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_mirage_level_sounds.txt"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\jump_mirage.cfg"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\motd.txt"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\mapcycle.txt"

copy Content\maps\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps" /Y
copy Content\cfg\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg" /Y

echo.
echo ===========================
echo  Copying Mirage sounds...
echo ===========================

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\sound\jump_mirage" /s /q
xcopy Content\sound\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\sound\" /E

echo.
echo ===========================
echo  Copying Mirage models...
echo ===========================

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\models\jump_mirage" /s /q
xcopy Content\models\*.* "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\models\" /E

echo.
echo ========
echo  Done!
echo ========

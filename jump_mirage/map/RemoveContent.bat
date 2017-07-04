@Echo off

echo ===============================
echo  Removing Mirage materials...
echo ===============================

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_mirage" /s /q

echo.
echo ===============================
echo  Removing Mirage map config...
echo ===============================

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_mirage_level_sounds.txt"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\jump_mirage.cfg"

echo.
echo ============================
echo  Removing Mirage sounds...
echo ============================

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\sound\jump_mirage" /s /q

echo.
echo ============================
echo  Removing Mirage models...
echo ============================

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\models\jump_mirage" /s /q

echo.
echo ========
echo  Done!
echo ========

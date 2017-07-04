@Echo off

echo Removing Lotus content...

rmdir "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_lotus" /s /q

del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_lotus_level_sounds.txt"
del "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\jump_lotus.cfg"

echo Done!

@Echo off

echo Disabling Lotus content...

rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_lotus" jump_lotus_disabled
rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_lotus_level_sounds.txt" jump_lotus_disabled_level_sounds.txt
rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\jump_lotus.cfg" jump_lotus_disabled.cfg

echo Done!

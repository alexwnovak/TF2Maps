@Echo off

echo Disabling Mirage materials...
rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_mirage" jump_mirage_disabled

echo Disabling Mirage configuration...

rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_mirage_level_sounds.txt" jump_mirage_disabled_level_sounds.txt
rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\jump_mirage.cfg" jump_mirage_disabled.cfg

echo Disabling Mirage sounds...

rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\sound\jump_mirage" jump_mirage_disabled"

echo Disabling Mirage models...

rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\models\jump_mirage" jump_mirage_disabled

echo Done!
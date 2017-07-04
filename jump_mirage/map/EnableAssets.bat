@Echo off

echo Enabling Mirage materials...
rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\materials\jump_mirage_disabled" jump_mirage

echo Enabling Mirage configuration...

rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\maps\jump_mirage_disabled_level_sounds.txt" jump_mirage_level_sounds.txt
rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\cfg\jump_mirage_disabled.cfg" jump_mirage.cfg

echo Enabling Mirage sounds...

rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\sound\jump_mirage_disabled" jump_mirage

echo Enabling Mirage models...

rename "C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2\tf\models\jump_mirage_disabled" jump_mirage

echo Done!
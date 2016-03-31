Jump Mirage
===========

This ended up being a huge undertaking. The scope was huge, and the design more complex. I used all
custom textures, custom sounds, custom props, and loads of detail. This map also features connectors,
instead of teleport doors, which added a ton of work. I built two entire routes with complete jumps
before building the third and final one. This is why it took a year. :(

Because of the complexity, I ran into Hammer limitations pretty frequently. This map took my
familiarity with Hammer and drove it into a new echelon. However, that took lots of time. The biggest
problem with development was the time I wasted repeating work. If I knew then all the things I learned
during this map, it would've taken a fraction of the time. But I love the result. It's not perfect,
but it's so much more than I thought I would accomplish.

# In this folder

| Path                      | Contents                                                             |
|---------------------------|----------------------------------------------------------------------|
| `demos/`                  | These are the raw .dem files I recorded for each jump tutorial video |
| `--/TitleCard`            | The Paint.NET project for the jump tutorial video's intro image      |
| `jumpthrough/`            | Contains the .dem file used for the YouTube jumpthrough intro video  |
| `map/`                    | The original map resources for Hammer (VMF, materials, etc.)         |
| `--/Content/`             | The materials, models and configuration that packs into the map      |
| `--/Models/`              | The original VMF map files that contain the original models          |
| `--/CopyAssets.bat`       | Copies the /Content stuff into the TF2 directory for use             |
| `--/DisableAssets.bat`    | Moves the copied TF2 content out of the way, but doesn't delete it   |
| `--/EnableAssets.bat`     | Moves the copied TF2 content INTO the right names for use            |
| `--/RemoveContent.bat`    | Deletes the content out of the TF2 directory for clean-slate testing |
| `--/FileList.txt`         | A manifest of all the files that need to get packed into the BSP     |
| `--/Pack.bat`             | Packs the compiled BSP with all the /Content files for distribution  |
| `--/jump_mirage.vmf`      | The actual source map for jump_mirage                                |
| `src/`                    | Any code I wrote to generate/build stuff for the map                 |
| `--/NumberGenerator/`     | C# project that generates jump number decals                         |
| `--/RuneCircleGenerator/` | C# project that generates the teleport ring's texture                |

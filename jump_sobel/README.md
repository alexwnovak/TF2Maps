Jump Sobel
==========

My fifth official map. Build cycle ran from June 29, 2017 to ??? with a total of ??? hours. Check out the [Time Sheet](https://github.com/alexwnovak/TF2Maps/raw/master/jump_sobel/TimeSheet.pdf) for the full breakdown.

# Concept

This is another niche/gimmick centered around edgebugs. My mentality was the same as it was for my previous map, [jump_manitou](https://github.com/alexwnovak/TF2Maps/tree/master/jump_manitou): Provide a reasonable stomping ground to practice a particular skill. Nothing _crazy_, but something _doable_.

I liked `jump_edgebug`, but it suffers from a syndrome. It's complex, impractical, and isn't _focused_ on edgebugs--some feel bolted on, because they have to be there. Edgebugging off a ramp into a massive sync is about the sync, not skillfully controlling your speed and angle against an edge. Don't get me wrong, the map is fun, and Eleven deserves credit for bringing it to life. But I wanted to build something pragmatic. What if people started using edgebugs as part of gameplay? Wouldn't it be rad if you saw people hitting edgebugs to avoid cratering? Or as part of their escape from a fight? Or to get the distance to land a market garden? What if we had a map that could make you _good at edgebugs_?

This was my mentality when building `jump_sobel`: Make a space to enable people to become amazing at something unique. I love this approach, because it allows for evolution.

# Jumps

I wanted to laser-focus on the edgebugs, so they were the core of the difficulty. To make this true, any extra chaff wasn't allowed. The jumps needed to be simple, so all your brain cycles could be devoted to the edgebug.

There's a bit of variation, but they're all pretty similar. I wanted them to feel familiar to what you'd encounter in a game--falling toward an edge, coming off a wallshot or a skip at an edge--that kind of stuff. They're intentionally not as hard as humanly possible. Remember, I was going for practical and approachable.

# Design

I wanted something with neutral colors for the backdrop, and incorporated splashes of color to highlight important things (like surfaces you interact with--bright green for the edgebugs, bright orange for shootable walls). The backdrop colors are a little boring, so I added different materials (matte vs. metal), and used interesting geometry to help fill in the interest. Glass was also a big part, since you can see through it. This is used in some places to help illuminate where you have to go. It's also a nice shade of blue, which is a cooler color, but still feels neutral in that it's familiar, but not garish--it still feels like it fits in the background (unlike the green and orange). Finally, to offset the sterile, medical feel of shiny metal, I threw in a rock texture to sit behind the glass. It's a nice juxtaposition (mechanical vs. natural) and adds a little life. (I tried this a long time ago with `jump_babylon` with the stone and wood.)

Originally this theme was meant for the map that would become `jump_lotus`. I assembled the textures and sketched out some geometry, but the project sat stagnant for quite a while. Eventually I picked it back up, but started from scratch, and that turned into Lotus, which left this metal theme unused.

I went with teleporters over connectors. Connectors serve speedrunning really well, to open up the space and give options to the jumper. But that's not what I wanted for this niche. I wanted the jumps to be done exactly like I built them--it's about edgebugs, so strats to avoid edgebugs was off the table. This also let me copy/paste loads of elements and sped up development.

Since I had to tightly control how the jumps were done, I take to take as many measures as possible to remove options. Only a handful of surfaces were shootable, since those were the ones you had to interact with to do the jump. All others became unshootable--your rockets pass right through. This means you can't hit extra skips or life-saver rockets to circumvent the level. I did this by making every non-shootable surface a `func_brush` with the "Never Solid" setting. This makes everything pass right through--including players. To fix this, I also built out the structure of each level with clip brushes, which blocked players, but not rockets. The effect is a solid world structure that can block the player, but all shots pass right through.

# Tooling



# Trivia

A sobel ("SO-bull") filter is an image processing algorithm that can do _edge detection_. It's a play on words between edgebugs and edge detection.

# In this folder

| Path                      | Contents                                                             |
|---------------------------|----------------------------------------------------------------------|
| `demo/`                   | Contains the demo material for the YouTube jumpthrough intro video   |
| `map/`                    | The original map resources for Hammer (VMF, materials, etc.)         |
| `--/Assets/`              | The source material for the custom textures and decals               |
| `--/Content/`             | The materials, models and configuration that packs into the map      |
| `--/CopyContent.bat`      | Copies the /Content stuff into the TF2 directory for use             |
| `--/RemoveContent.bat`    | Deletes the content out of the TF2 directory for clean-slate testing |
| `--/SyncProps.bat`        | Copies the compiled props from Propper into the Content directory    |
| `--/FileList.txt`         | The "pack list" of all additional resources used by the map          |
| `--/Pack.bat`             | Packs all additional map resources into the .bsp for delivery        |
| `--/jump_sobel.vmf`       | The actual Hammer map                                                |
| `TimeSheet.pdf`           | A record I kept of the time I spent building the map                 |

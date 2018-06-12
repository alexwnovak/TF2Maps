Jump Sobel
==========

My fifth official map. Build cycle ran from June 29, 2017 to ??? with a total of ??? hours. Check out the [Time Sheet](https://github.com/alexwnovak/TF2Maps/raw/master/jump_sobel/TimeSheet.pdf) for the full breakdown.

# Concept

This is another niche/gimmick centered around edgebugs. My mentality was the same as it was for my previous map, [jump_manitou](https://github.com/alexwnovak/TF2Maps/tree/master/jump_manitou): Provide a reasonable stomping ground to practice a particular skill. Nothing _crazy_, but something _doable_.

I liked `jump_edgebug`, but it suffers from a syndrome. It's complex, impractical, and isn't _focused_ on edgebugs--some feel bolted on, because they have to be there. Edgebugging off a ramp into a massive sync is about the sync, not skillfully controlling your speed and angle against an edge. Don't get me wrong, the map is fun, and Eleven deserves credit for bringing it to life. But I wanted to build something pragmatic. What if people started using edgebugs as part of gameplay? Wouldn't it be rad if you saw people hitting edgebugs to avoid cratering? Or as part of their escape from a fight? Or to get the distance to land a market garden? What if we had a map that could make you _good at edgebugs_?

This was my mentality when building `jump_sobel`: Make a space to enable people to become amazing at something unique. I love this approach, because it allows for evolution. Not just of a person, but of the art itself.

# Jumps

I wanted to laser-focus on the edgebugs, so they were the core of the difficulty. To make this true, any extra chaff wasn't allowed. The jumps needed to be simple, so all your brain cycles could be devoted to the edgebug.

There's a bit of variation, but they're all pretty similar. I wanted them to feel familiar to what you'd encounter in a game--falling toward an edge, coming off a wallshot or a skip at an edge--that kind of stuff. They're intentionally not as hard as humanly possible. Remember, I was going for practical and approachable.

# Design

I wanted something with neutral colors for the backdrop, and incorporated splashes of color to highlight important things (like surfaces you interact with--bright green for the edgebugs, bright orange for shootable walls). The backdrop colors are a little boring, so I added different materials (matte vs. metal), and used geometry to help fill in the interest. Glass was also a big part, since you can see through it. This is used in some places to help illuminate where you have to go. It's also a nice shade of blue, which is a cooler color, but still feels neutral in that it's familiar, but not garish--it still feels like it fits in the background (unlike the green and orange). Finally, to offset the sterile, medical feel of shiny metal, I threw in a rock texture to sit behind the glass. It's a nice juxtaposition (mechanical vs. natural) and adds a little life. (I tried this a long time ago with `jump_babylon` with the stone and wood.)

Originally, this theme was meant for the map that would become `jump_lotus`. I assembled the textures and sketched out some geometry, but the project sat stagnant for quite a while. Eventually I picked it back up, but started from scratch, and that turned into Lotus, which left this metal theme unused.

I went with teleporters over connectors. Connectors serve speedrunning really well, to open up the space and give options to the jumper. But that's not what I wanted for this niche. I wanted the jumps to be done exactly like I built them--it's about edgebugs, so strats to avoid edgebugs was off the table. This also let me copy/paste loads of elements and sped up development.

Since I had to tightly control how the jumps were done, I take to take as many measures as possible to remove options. Only a handful of surfaces were shootable, since those were the ones you had to interact with to do the jump. All others became unshootable--your rockets pass right through. This means you can't hit extra skips or life-saver rockets to circumvent the level. I did this by making every non-shootable surface a `func_brush` with the "Never Solid" setting. This makes everything pass right through--including players. To fix this, I also built out the structure of each level with clip brushes, which blocked players, but not rockets. The effect is a solid world structure that can block the player, but all shots pass right through.

# Development

Building the jumps was the same as the previous few maps. Was pretty efficient. The hardest thing was testing, since it required hitting edgebugs to make sure they felt right. I had to get good enough to know whether these were reasonable or ridiculous.

Building the geometry was really fun. I've wanted to do things with hexagons for a long time, since they're such a good shape (they even fit together). Incorporating super-weird abstract pieces was a good time, and I felt lots of creative freedom. This isn't always true, depending on the theme, since you tend to develop a look and feel and rules of consistency tend to emerge. That was less true here, so I could make weird wavy walls, or crazy spiky triangle walls--anything goes.

Toward the end of development I actually hit the brush limit. Since there are only 10 jumps, I couldn't imagine I'd need models. Turns out all that wacky geometry eats up brushes pretty fast. I originally had a more complex version of the capture point that I had to re-work to stay under the brush limit. I was unwilling to re-work brushes into models (this is what made `jump_mirage` take forever). I was willing to compromise and work within the limits.

A positive thing I tried was using PowerShell to automate packing the map. I typically get a list of files and munge the file list myself. This time I used PowerShell to generate the file list as well as pack the map. It worked out great. I've experimented with PowerShell for compilation as well and there's lots of potential here.

# Shortcomings

My biggest regret is not building a bonus. Bonuses are great and let you do wackier things that go outside the consistency you've set forth. It was also the perfect place to play homage to Eleven, the guy behind `jump_edgebug`. I felt like that'd be a great way to tie the whole map together, but I didn't have any space left in the map. Not planning for scale bit me really hard here--brushes are at 95% capacity. There's room for a handful of details, but no more major components. Adding a bonus would mean re-working most of the entire map, and this wasn't going to happen.

# Trivia

A sobel ("SO-bull") filter is an image processing algorithm that can do _edge detection_. It's a play on words between edgebugs and edge detection.

# In this folder

| Path                      | Contents                                                             |
|---------------------------|----------------------------------------------------------------------|
| `map/`                    | The original map resources for Hammer (VMF, materials, etc.)         |
| `map/Assets/`             | The source material for the custom textures and decals               |
| `map/Content/`            | The materials, models and configuration that packs into the map      |
| `map/CopyContent.bat`     | Copies the /Content stuff into the TF2 directory for use             |
| `map/RemoveContent.bat`   | Deletes the content out of the TF2 directory for clean-slate testing |
| `map/Pack.ps1`            | Packs all additional map resources into the .bsp for delivery        |
| `map/jump_sobel.vmf`      | The actual Hammer map                                                |
| `TimeSheet.pdf`           | A record I kept of the time I spent building the map                 |

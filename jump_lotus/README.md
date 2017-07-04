Jump Lotus
===========

My third official map. This went way faster than jump_mirage, clocking in at about 50 hours
(compare to jump_mirage at _hundreds_ of hours), spanning two months of development. This
project was extremely more efficient than jump_mirage, because the scope was smaller, and I
also learned a lot from the last go-round. I organized the work and planned for scale early--
I'll detail shortly.

# Map Concept

I've wanted to do an Airstrike jump map for quite some time. Pants beat me to it and released
jump_strike, which was cool, but I felt the jumps were a little "out there." I wanted to show
fun, but practicality--jumps that you could do in pubs, but _also_ show off the potential with
"out there" jumps.

I also wanted to expand our vocabularity in the jump community. There are so many options for
jumping, and Airstrike jumping hasn't been explored much at all. I'm thrilled to contribute
something relatively new that we can chew on. It may not take off, but this is still a new angle
that many of us haven't considered. I have many plans to keep bringing out new concepts, so
stay tuned.

# Design

I didn't plan this out too much. I sat down, found some mostly-matte textures I liked, made them
in a few colors, put together some brushes, and the visuals began to emerge. I had a feeling
the visual complexity wouldn't be nearly as high as Mirage--I didn't want to sink a _ton_ of work
in, but I still wanted it to look good/passable. I decided "no models," which capped the complexity.
Going too complex and coming back through later with model-rebuilds was a crushing reset on Mirage.

There are plenty of Mirage inspirations also--the platforms/borders, I blatantly copied. I used a
lot more displacements here--snow instead of sand. Rock walls, too. The final jump, I'm really
happy with how the ice walls turned out.

One last thing I did up front was default the light map scale to 32. This makes a few areas look
meh, but it made build times incredibly shorter. I also learned this too late in Mirage's development.

# Development

I changed up how I approached things this time and it really worked out. Here's how I went about it:

**1. Built all jumps in separate VMFs, Dev textures only**

This made it really easy to iterate quickly on small components. I could fire up a single map,
adjust it and play on it. I wasn't waiting for long build times because I wasn't compiling the
whole big thing.

I used Dev textures and full-bright. Nothing elaborate. The point here was to flesh out the
structure and feel of each jump, not to make it look good.

One major change I also did was _not_ launching TF2 after each compile. Instead, I un-checked
the "Run" option and only did compiles. I _left TF2 running_ in another window, and would
Alt+Tab in and out. After a build, I'd switch to TF2 and reload with a "map" command. This saved me
_loads_ of time, not waiting for the game to load constantly.

**2. Route the map**

Once I had a series of jumps in a reasonable progression, I assembled them all together and
filled in pathways between each jump. This was the part where the whole map was fleshed out.
I spent a lot of time on the connectors, making sure they felt good, making sure that they
flowed. I jumped through it a lot and added bits for speedrunning--well-placed ramps, big
distances for speedshots or crazy syncs.

One detail I tried out here (that worked out great, I think) is that upward stairs are _ramps_,
so you can slide up them. However, downward stairs _are stairs_. This lets you hit easy edgebugs
as you fly down them. Downward ramps don't offer you much here.

Jump construction and routing together took about 13 hours.

**3. Detailing**

This took the longest--what else is new? Didn't go crazy, but tried to make it look unique and
interesting. Landed on a snow motif after stumbling into a cool palette of textures. Threw some
ice and snow in there and it took off. Added a blue hue to the lighting a sweet snowy skybox
I stole from somewhere (CS:GO I think) and some windy soundscapes and it _feels cold_.

Detailing took about 30 hours.

**4. Post-production**

I _really_ wanted to do QR Codes in Mirage, but it didn't make it. Lots of servers have
implemented ways of teaching you how to do the jumps. Some maps even try to explain it (like Beef).
I thought this was better: Put QR codes at each jump that link to a YouTube video, showing how to
do it. This meant you'd need to make a ton of YouTube videos, get their links, make QR codes, and
put them back in the map. It was a lot of work (hence why it was cut from Mirage), but this was the
perfect time. Airstrike jumps are new, and it's a lot harder to look at a jump and see how to do it
when we haven't been jumping on them for years.

I hope to keep up this tradition in future maps. I'd love to see the community run with this concept.
This way, instruction is self-contained. For those markers, you have to play on certain servers, and
dedicated folks have to create those tutorials. Might as well be the map author!

Another change I tried out here was the jump numbering. Like usual, I wrote some C# to generate the
images since it involved geometry. The design change is that I wanted to incorporate the _total_
number of jumps somehow. This worked out great--the dotted ring around the number indicates your
progress (basically like a radial progress bar). You can count them based on where you are, and figure
out the total number of jumps. This removes that "HOW MUCH FARTHER IS IT" discomfort I get when
jumping on new maps. There's no reason to keep the player in the dark, so we might as well clue them
in.

# In this folder

| Path                      | Contents                                                             |
|---------------------------|----------------------------------------------------------------------|
| `demos/`                  | These are the raw .dem files I recorded for each jump tutorial video |
| `--/LowerThirds`          | Individual images that appear in the videos                          |
| `jumpthrough/`            | Contains the .dem file used for the YouTube jumpthrough intro video  |
| `map/`                    | The original map resources for Hammer (VMF, materials, etc.)         |
| `--/Content/`             | The materials, models and configuration that packs into the map      |
| `--/CopyAssets.bat`       | Copies the /Content stuff into the TF2 directory for use             |
| `--/DisableAssets.bat`    | Moves the copied TF2 content out of the way, but doesn't delete it   |
| `--/EnableAssets.bat`     | Moves the copied TF2 content INTO the right names for use            |
| `--/RemoveContent.bat`    | Deletes the content out of the TF2 directory for clean-slate testing |
| `--/jump_lotus.vmf`       | The actual source map for jump_lotus                                 |
| `src/`                    | Any code I wrote to generate/build stuff for the map                 |
| `--/NumberGenerator/`     | C# project that generates jump number decals                         |

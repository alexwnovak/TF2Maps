Jump Manitou
============

My fourth official map, and as usual, I tried to do new things I hadn't before. Production
ran from January 19, 2017 through July 4, 2017, clocking in at 97 total hours. See the
[Time Sheet](https://github.com/alexwnovak/TF2Maps/raw/master/jump_manitou/TimeSheet.pdf) for a breakdown of where the time went.

# The Concept

I love ctaps. I think it's the most practical and applicable thing you can learn in jumping.
Not everyone loves it though (and I don't understand it). It's _hard_, but it's worth it.

The only ctap map I'd seen was `tr_ctap_a2`, and it was really simple. It had three jumps--
jump straight up, jump across a flat gap, and jump upward across a gap. It had dev textures
and was great. (Fun fact, this is where I got my trademark "seamless teleports.")

I wanted to add my support for ctap training. I wanted to make a good-looking, full-blown
jump map around this idea. Hopefully to raise awareness for this great skill and provide an
inviting place to practice.

# Design

The jumps took a handful of hours to sketch out. I took my usual approach of building them in
separate VMFs so I could iterate quickly and Alt+Tab between Hammer and TF2 to try them out.

I opted for connectors instead of teleports. I prefer connectors, because I think it makes
better maps. It gives the builder way more options for making a visually-distinct and speed-run
friendly environment. However, if the map is centered around gimmick jumps (like this one), then
strats _aren't_ what you want. You want to dictate _how_ the player does the jumps. (This is also
why gimmick maps shouldn't be the norm.) It's constricting, and teleports fit this model better,
since it's about the quirky jumps, not about discovering cool ways to blast past them.

However, with this map I wanted to try a new visual design. Connectors give a lot of freedom here,
since you have to build a way for the player to get from start to finish. Teleports simplify
things a lot and have a tendency to box you into a specific design language.

The visual design I wanted was to _make it look more like an actual TF2 map_. Jump maps are often
disjoint with their looks, using textures you never see in regular maps. It's a cool feature of
the sub-culture, but they don't fit in with the typical TF2 look. Some get in the ballpark
(`jump_rebound` comes to mind), but I wanted to get closer.

I'm thrilled with the end result, but I didn't get as close as I wanted. I overlooked plenty
of details, and that's the reason I fell short. But I can't split too many hairs.

The main difference with this map is that I wanted to focus on a few facets that are present 
in first-party TF2 maps compared to jump maps: _props_ and _scale_.

### Props

Most jump maps don't have any of these. I've used props as an optimization technique (especially
on Mirage), but not for enhancing the environment. That's what I wanted to do here: use props
to tell a richer story about the world. Props help make a map seem legitimate; they make it seem
immersive; they make it seem _like an actual place_.

I went a little overboard.

Every room and wall had to have junk on it. I opened up Process, Powerhouse, Badwater, and others
and copy/pasted props out of them I liked. I put props everywhere. I tried hard to not obstruct
the jumping experience, and only use them to add credence in the environment. But I have plenty of
inconsistency about the types of props (radioactive barrels vs. water barrels). I tried to think
of what kind facility this map is set in--is it farming? Mining? Construction? I used props from
all of those settings.

A take-away here is to consider carefully the place you're building and add props that feel at
home there. Don't go ballistic; add enough to make it interesting, but not too much to get in
the player's way.

### Scale

Jump maps are a little weird because the _scale_ is different than regular maps. In a game, you're
usually walking and shooting, not flying as high as you can. It's geared for all classes to
traverse, so short hallways are normal. However, in jump maps, short hallways are the _worst_--
jumping through them is hard or impossible. So what do we do? Make 'em bigger! Hallways that are
three times your height are _super common_ in jump maps, because it makes them _functional_, and
that's what you want.

I wanted to strike a balance. Seeing gigantic rooms is atypical in TF2. I wanted to make believable
rooms, but also make them jumpable. I settled on creating a doorframe that I used repeatedly, but
it's not very _deep_. You can fly through it. You can also quickly walk through it and always wall
jump right away. From there, I looked at maps I liked--especially Badwater--to get a sense of size.
I copied its room heights especially.

What I ended up with is I think a good approximation of how big things are in the TF2 universe.
It's not perfect, and it couldn't be, since part of jump map DNA _is_ long distances you need to
cover.

# Trivia

"Man-uh-too" is defined as "a good or evil spirit as an object of reverence."

I heard this on X-Files forever ago. It's a cool-sounding word, but the definition plays perfectly
with the theme of the map:

Depending on who you ask, ctaps are good or evil, but they're powerful.

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
| `--/jump_manitou.vmf`     | The actual Hammer map                                                |
| `TimeSheet.pdf`           | A record I kept of the time I spent building the map                 |

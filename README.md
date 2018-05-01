# spells

Unity game built with Unity version 5.6.3p1 Personal (64 bit)

# Bugs

- None known

# TODO (priority order)

- Display health bar (public info - red)
  - All done expect for the actual bar display part (Controllers/DefaultUnitHealthUIController is in charge of the rendering)
- Display mana bar (public info - blue)
- Camera Movement / Larger maps (keep camera centered)
- Camera Zoom controls
- Blocking/reflecting spell
  - reflects 180 degrees if blocked in the first 0.1 ish seconds with a 1.5x speed increase (shield is red)
  - otherwise reflects like normal
- basic respawn point (just 1 respawn location, no selection)
- kill counter
- Levels / Experience (per damage done, extra exp for a kill, divide bonus by number of people in capture zone)
- display exp bar (public info - yellow)
- Player level ups (start with 3 skill points, gain 3 skill points per rank up)
  - Ranks are Peon (3), Captain (6), Officer (9), Lieutenant (12), General (15)
  - XP is expoitital both up and down the rank chart (ie, an Officer would need to damage like 12 captains to level up, but only 3 lieutenants)
  - Ranks are shown as as a pre-fix to player's nickname (Peons shown with no name, Captains shown as just Captain, all others shown as Officer SomeName)
- Unit name colors (peon blank, captain white/black, officer yellow, lieutenant orange, general red)
- Players should have **stars** around their titles/names (ai does not)
- Ability to buy upgrades/abilities via skill points (ui overlay)
- Pits (shoot over, but can't walk over)
- Shields (move over, but can't shoot over)
- Capture point and regen health, regen mana, better exp gain, more ai troops, respawn points (associated to nearby capture point)
- Multiplayer
- Show unit count for each side and number of officers, lieutenants, and generals (per side)
- moral bar (summary/normalized number of total exp, num of units, and number of capture points)
- Kills of Officers, Lieutenants, and Generals are announced globaly (both the killer and the killed)
- AI (each side should have a varity of differently skilled AI)

## TODO Later

- Detailed leader board
- Multiple levels to choose from & level select screen
- Better graphics
- Sound effects
- Main menu w/ options and level loading
- Battle customization screen
- More classes (ranger, warlock, assassin, barbarian, druid, etc)

# Class Ideas

- Warlocks drain energy but don't regen normally
  - Upgrade to auto drain from nearby allies that have full energy
- Archer arrows pierce 'x' walls and units and do a lot of damage, but are inaccurate over long range
  - Double-shot upgrade (shoot 2 arrows at once (each drifts seperately))
  - Fan-shot upgrade (shoot 3 arrows in a fan pattern, can stack with the double-shot)
- Druid plants trees that heal and turrets that auto-attack

# spells

Unity game built with Unity version 5.6.3p1 Personal (64 bit)

## Bugs

- None known

## TODO (priority order)

- Ability Rate of Fire
  - Bounce bolt should be about 0.25 / sec
  - No max rate of fire
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

### TODO Later

- Detailed leader board
- Multiple levels to choose from & level select screen
- Better graphics
- Sound effects
- Main menu w/ options and level loading
- Battle customization screen
- More classes (ranger, warlock, assassin, barbarian, druid, etc)

## Class Ideas

- Mage
  - Short range Teleport
  - Fireball (fire once normally as a small projectile, explode on impact or on second button press)
- Archer arrows pierce 'x' walls and units and do a lot of damage, but are inaccurate over long range
  - Should shoot about 1 / 0.75 sec
  - Double-shot upgrade (shoot 2 arrows at once (each drifts seperately))
  - Fan-shot upgrade (shoot 3 arrows in a fan pattern, can stack with the double-shot)
  - Upgrade for more accurate shots
  - Can place hidden traps that explode when stepped on
  - Has limited energy that doesn't regenerate
  - Faster movement speed than mage
  - Starts with 15 max and current health
- Warlocks drain energy but don't regen normally
  - Upgrade to auto drain from nearby allies that have full energy
  - Confuse (mult. target move speed by -1)
  - Energy drain
- Druid plants trees that heal and turrets that auto-attack
- Barbarian
  - Loses energy over time
    - Gain energy by taking or doing damage
  - Blood Rage
	- Self-heal costing a lot of energy and tmp move/primary attack speed buff
  - Cleave
    - Lowers target's max health and major push-back w/ large move speed debuff for short time (crawling)
- Assassian
  - Backstabs for major damage
  - Poison dart causes tmp health degen and move speed loss
  - Cloak to go invisible for a short amount of time and increase own move speed
  - Can place caltrops trap that sets target's movement speed to 0 for a short time 

### Class Upgrades

- Max health
- minor Health regen
- Max energy
- energy regen
- speed
- attack speed
- new abilities to use / ability ranks (upgrades)

## Gameplay Notes

- Forts / sources of regen go by %/sec rather than a hard number

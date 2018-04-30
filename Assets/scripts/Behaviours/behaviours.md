# behaviours

## tl;dr

- Behaviours contain state and manage when the controllers get called ('when?')
- Controllers define how the behaviour should act ('what?')

## details

- Top-level behaviours are what can be dragged onto a prefab to add a behaviour
  - ie, drag the AbilityUser script onto a prefab to allow it to rotate and use abilities
- Behaviours that can be controlled (such as movement) have an associated ControllerDefinition
  - Some behaviours, such as health, are not controlled. So they wouldn't have a ControllerDefinition
- ControllerDefinitions define what a controller needs to implment for a behaviour to be controlled
  - ie, an AbilityUserController definition would require a way to tell when to use a certain ability
- Behaviours hold their own state and pass themselves to the ControllerDefinition functions to be told what to do
  - Behaviours define when the controllers get called (ie, in Update())

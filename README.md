# FromHellToEternity

Project Concept:
  The game begins in the hub, players can enter the dungeon and interact with a statue to see leaderboards. When the player triggers the dungeon entrance the first scene will be loaded. Each of the 5 eras are split into their own scenes and have 3 maps. 2 mob floors and 1 boss. The player will start at the first mob floor where they must clear all the enemies in the room in order for a chest to spawn. The chest contains a key and will allow players to interact with the gate and progress to the next room. In the boss room players must kill the boss in order to spawn a teleporter that will take them to the next scene. 
  Players have basic WASD movement, a dash, and basic melee attacks (possibly a limited ranged attack)
  Players dash should be able to go through smaller obstacles around the map, but not pass through the border
  Enemies have 3 basic mechanics: dash attack, melee attack, and ranged attack
  All attacks should inflict some form of knockback/stun
  
Issues:
  Enemies do not work
  The enemies utilize  package called Spine, I can not figure out how to properly use the package to animate the sprites. 
  Maps are not included in this file. Sophia has the maps, so if u would like to work on a more complete version you can geet the maps from sophia and merge the files. The gate, chest, and teleporter should be prefabs, if not then just copy them from the base scene that everything is located in
  The dashes do not work properly. They have gone through stages where theysort of worked, but now just just dont work at all (most of the code was disabled or changed when I was attempting to adapt it to Spine)
  Knockback is broken
  
 
Notes:
  I apologize for the messy state the project is in. I wanted to clean it up a bit before sending it over, but I havent had the time. You are welcome to make any changes to the project that you see fit. Like if you have sprites on hand and would rather use those than figure out the Spine package that is totally fine with me. I am only using these Sprites because they are the best(most complete) free ones I could find. The main thing that I would like you to look at is the enemies. If you could get them to work that would be a lot of weight lifted off my shoulders. If you have time and would like to do more then the dash attack and players dash would be second on the list. Another would be the knockback. i am not sure how I broke it, but there is no friction now so if you hit an enemy they just slide forever. 

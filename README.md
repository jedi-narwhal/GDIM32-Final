# GDIM32-Final

## Check-In
### Team Devlog
The inclusion of the vector math technique we used was raycasting. This is when a vector math technique projects an invisible line defined by an origin point and a direction into a 3D scene to test for intersections with geometry. Raycasting lets the player click on 3D objects to pick them up. When the left mouse button is pressed, ScreenPointToRay converts the 2D mouse position into a 3D ray shooting out from the camera, and Physics. Raycast fires that ray up to 100 units to check if it hits any collider. If it does, the code checks whether the hit object has an items component, and if so, calls Pickup() on it. Essentially, the ray acts as a laser pointer from the camera through the cursor into the world, bridging 2D screen space and 3D world space so the player can interact with objects through simple mouse clicks. 
### Sonia Mangat
Put your individual check-in Devlog here.
### Milla Lucido
What I worked on:
I worked a lot in the prefabs and materials sections to make the scene and walls work. The apartment prefab was the biggest trouble because the original materials I was going to use were not going to work so I had to redo a lot of my work when I decided that it was not worth it, but it turned out much better. I also put in the agitated and angry bool parameters in the cat’s animator. I also made the rotation animations for the cat so that it moves more like an actual security camera. I made the battery rotate slightly and increase in scale by 0.5 so that it is more noticeable to players, though that will be changed later when the objects only appear when talked to by the cat. I made the audio manager and put in all of the audios that we are using in our project. I made it so that the camera moves with the player more naturally and does not look like a fishbowl effect. I also put in a skybox at the request of an LA. 

The breakdown was very useful because I was very quickly able to take stock of what I needed to both build the scene and what audios we decided on. I was able to keep going back to it to remember exactly what we discussed in the planning to most accurately replicate what we decided as a team was good for the project. 

If I had to do this again, a Google Doc would not be my favorite choice of progress tracking. It is not the most convenient, but it is what we decided at the beginning, so we are stuck with it for now. Other than that, Discord and Messages were often used to update the other team members, and that was a good means of information passing. 

If there was something I would improve on for future project planning, it would likely be splitting up tasks more effectively. A lot of how our project made it hard to know when others were working in Unity so that we did not also work in unity so even just making a more effective and clear schedule would be a much better system. 

### Minjoo Shin
I contributed to this project’s UI system and inventory. I created all UI canvases and the inventory canvas.
UI manager
Game Start Canvas
Game Over Canvas
Crosshair (the white dot in the middle of the player’s perspective)
Dialogue Canvas
For the script, I worked on the UI (UI manager), ChecklistUI (inventory), player, battery, and key scripts. The UI manager game object manipulates the game canvases, including the game start, game over, and dialogue canvas. The UI manager opens and closes the game start screen by detecting the player’s click. The crosshair represents the middle point where the hidden cursor is located. 

Breakdown was useful in writing the scripts and creating game objects in the scene. This is because I was able to understand what I have to create and connect with visual diagrams and a simple checklist. In addition, Professor Reid’s advice (a simple breakdown of my inventory) helped me understand how to create a simple checklist UI. For example, for the inventory, I connected the icon sprites (battery and key icons) to the player’s action using a Boolean value. If the player clicks the battery, _hasBattery is set to true, which activates the inventory icon sprite, which works smoothly.

The first plan was to make an inventory, which is similar to GDIM 31’s 2D final checklist system. However, I changed the inventory UI because I thought the simple icon inventory is much easier to create and enhances player immersion more effectively. Thus, I decided to simply update the icon's sprite for clarity. For the final project, I want to implement an interactive inventory to interact with the stuffed animal in the game.



## Final Submission
### Group Devlog
Put your group Devlog here.


### Sonia Mangat
Put your individual final Devlog here.
### Milla Lucido
Put your individual final Devlog here.
### Minjoo Shin
Put your individual final Devlog here.

## Open-Source Assets
Cite any open-source assets here. Put them in a LIST, and use correctly formatted LINKS.
- [Wasteland Cabin Assets](https://assetstore.unity.com/packages/3d/environments/urban/wasteland-cabin-94865) - House Sprites
- [Stuffed Animal Asset](https://assetstore.unity.com/packages/3d/characters/animals/little-friends-cartoon-animals-lite-262505) - Stuffed Cat Sprites
- [Camera Asset](https://assetstore.unity.com/packages/3d/props/surveillance-camera-264577) - Camera Sprite
- [Horror Puzzle Assets](https://assetstore.unity.com/packages/3d/props/retro-psx-horror-puzzle-item-pack-icon-lowpoly-250188) - Battery Sprites
- [Simple Keys](https://assetstore.unity.com/packages/3d/props/tools/simple-keys-231162) - House Key
- [Dreamcore Music](https://assetstore.unity.com/packages/audio/music/dreamcore-music-355604) - Background Music
- [Door Sounds](http://assetstore.unity.com/packages/audio/sound-fx/foley/door-cabinets-lockers-free-257610) - Door Sound Effects
- [Casual SFX Pack](https://assetstore.unity.com/packages/audio/sound-fx/free-casual-game-sfx-pack-54116) - Pick Up Sound
- [Ash Valley Cybernetics](https://assetstore.unity.com/packages/audio/sound-fx/ash-valley-cybernetics-lite-108327#content) - Fail Alarm Sound

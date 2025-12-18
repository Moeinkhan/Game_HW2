# Batman 3D Game

## Project Overview
This is a simple **3D Batman game** set in an open environment.  
The main features include character movement, state changes, and interaction with lights and sounds.  

Key Features:
- Player controls Batman using WASD keys
- Batman has three states: Normal, Stealth, Alert
- Alert state triggers flashing lights and alarm sounds
- Bat-Signal with spotlight in the sky
- Background music with Alert overlay
- Urban map environment from Unity Asset Store (Name: Demo City by Versatile Studio)

---

## How to Run the Game
1. Open the project in **Unity 6.2** or a compatible version.
2. Download the map environment asset from Unity Asset Store ([Download from here](https://assetstore.unity.com/packages/3d/environments/urban/demo-city-by-versatile-studio-mobile-friendly-269772))
3. Make sure all assets are available in the `Assets/` folder.
4. Open the Game Scene.
5. Click **Play** to run the game in the Editor.
6. To run a build:
   - Go to **File → Build Profile → select Windows Profile**
   - Make sure the main scene is selected
   - Click **Build** and run the executable

---

## Controls

### Character Movement
- **W**: Move forward  
- **S**: Move backward  
- **A**: Rotate left  
- **D**: Rotate right  

### Batman States
- **N**: Normal  
- **C**: Stealth  
- **Space**: Alert  

### Bat-Signal
- **B**: Toggle Bat-Signal spotlight in the sky  

### Alert State
- Flashing lights (red and blue) appear  
- Alarm sound plays  
- Exiting Alert stops the lights and sound

---

## Work Summary
- **Character movement** implemented with Character Controller and input system  
- **Three Batman states** with different speed and environmental effects:
  - Normal: standard speed, normal lighting, background music  
  - Stealth: slower speed, dimmer environment lighting, background music   
  - Alert: flashing lights and alarm sound activated  
- **Bat-Signal spotlight** with toggle on/off and smooth circular movement  
- **Game and Alert music** implemented with two separate AudioSources  
- **Alert lights and sound** managed via simple Coroutines  
- Used ready-made assets for city environment from Unity Asset Store: Demo City by Versatile Studio
- You can download it from here:
- https://assetstore.unity.com/packages/3d/environments/urban/demo-city-by-versatile-studio-mobile-friendly-269772

---

# TestTaskAR
AR-Based Test Project for job opening at Advin Global

This Unity (6000.3.13f1 LTS Silicon) project contains solutions of a technical task for Advin Global. 

1. AR Part of the task 
This part of the task was implemented in the scene called TTAR (Assets/Scenes/TTAR.unity) using AR Core. To launch it, simply add this scene to the build settings as the only scene there and press "Build and Run"(Make sure to only enable Google AR Core for all platforms in Project Settings/XR Plugin Management). When app will finish building onto your device, it will launch automatically, simply follow the instructions that will appear on the screen. Alternatively, you can download the build from ~/Builds/TTAR.apk
Note: Each model has appr. 300k vertices, but the textures are upscaled to 8k to increase details. This increases build size dramatically, but if you want, you can reduce it all together by simply selecting all 5 textures at Assets/Models/Textures and capping their maximum size at 2048 for Android target platform.

2. VR Part of the task
This part of the task was implemented in the scene called TTVR (Assets/Scenes/TTVR.unity) using XR Interaction Toolkit. To launch it, simply add this scene to the build settings as the only scene there and press "Build and Run" (Make sure to enable OpenXR for all platforms in Project Settings/XR Plugin Management). Alternatively, you can download the build from ~/Builds/TTVR.apk. Also, you can open the scene and test it in editor by simply launching it, since the project uses XR Interaction Simulator for testing without headset.

Controls: Use left joystick to move, right joystick to turn, 'A' to jump. You can grab any Blue object by moving close to it and holding "Grab" key. To throw the object you are holding, just release the "Grab" key. To Interact with UI, aim at the button with the Ray (only active when pointing at the UI Element) and press the "Trigger" button.

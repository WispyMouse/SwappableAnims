## This Project

This project is designed to teach the process for using **Sprite Library** overrides for frame-by-frame graphics in Unity.
I assume the reader is already familiar with using **Animation Clip**s for frame-by-frame Sprite Animation.
If you're using **Animation Clip**s as a way to set a sprite directly through dope sheets, you may have seen that you cannot create new **Animation Clip**s at runtime.
The built-in Unity way of resolving this is using a **Sprite Library** and a **Sprite Resolver**.

## This Demo's Setup

**/Assets/DemoSpriteLibraryAsset** is a **Sprite Library Asset**. This is a root asset describing the base for sprites in your game.
This demo starts with two categories, **Character Animation** and **Other Category**. Inside **Character Animation** you can see **Frame0** and **Frame1**.
The game scene has a **Replacing Animating Thing**. This has a **Sprite Renderer** component, a **Animator** component, a **Sprite Resolver** component, and a **Sprite Library** component.
The **Sprite Library** points at the **/Asset/DemoSpriteLibraryAsset**. This will fill in the **Sprite Resolver** component.
**/Assets/DemoAnimation** is a **Animation Clip**. It tells a **Sprite Resolver** component to alternate between using "category **Character Animation** label **Frame0**" and "category **Character Animation** label **Frame1**".

Play the scene to show that it flips between Frame0 and Frame1.

When you press the top left "Load Replacement Hexagon From File IO" button it will call into the controller script, which is from **Assets/DemoController.cs**.
This will load in a Sprite from the file system, and then set it to be an override for the **Sprite Library** attached to only one of the animated objects.
Observe that after pressing it, a Hexagon is used as part of the animation, whereas the other animated object is unaffected.
This demonstrates how you can replace sprites without affecting other **Sprite Library** instances.
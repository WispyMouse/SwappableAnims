## This Project

This project is designed to teach the process for using [i]Sprite Library[/i] overrides for frame-by-frame graphics in Unity.
I assume the reader is already familiar with using [i]Animation Clip[/i]s for frame-by-frame Sprite Animation.
If you're using [i]Animation Clip[/i]s as a way to set a sprite directly through dope sheets, you may have seen that you cannot create new [i]Animation Clip[/i]s at runtime.
The built-in Unity way of resolving this is using a [i]Sprite Library[/i] and a [i]Sprite Resolver[/i].

## This Demo's Setup

[u]/Assets/DemoSpriteLibraryAsset[/u] is a [i]Sprite Library Asset[/i]. This is a root asset describing the base for sprites in your game.
This demo starts with two categories, [i]Character Animation[/i] and [i]Other Category[/i]. Inside [i]Character Animation[/i] you can see [i]Frame0[/i] and [i]Frame1[/i].
The game scene has a [i]Replacing Animating Thing[/i]. This has a [i]Sprite Renderer[/i] component, a [i]Animator[/i] component, a [i]Sprite Resolver[/i] component, and a [i]Sprite Library[/i] component.
The [i]Sprite Library[/i] points at the [u]/Asset/DemoSpriteLibraryAsset[/u]. This will fill in the [i]Sprite Resolver[/i] component.
[u]/Assets/DemoAnimation[/u] is a [i]Animation Clip[/i]. It tells a [i]Sprite Resolver[/i] component to alternate between using "category [i]Character Animation[/i] label [i]Frame0[/i]" and "category [i]Character Animation[/i] label [i]Frame1[/i]".

Play the scene to show that it flips between Frame0 and Frame1.

When you press the top left "Load Replacement Hexagon From File IO" button it will call into the controller script, which is from [u]Assets/DemoController.cs[/u].
This will load in a Sprite from the file system, and then set it to be an override for the [i]Sprite Library[/i] attached to only one of the animated objects.
Observe that after pressing it, a Hexagon is used as part of the animation, whereas the other animated object is unaffected.
This demonstrates how you can replace sprites without affecting other [i]Sprite Library[/i] instances.
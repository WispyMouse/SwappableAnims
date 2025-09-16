This is an attempt to demonstrate how to swap out sprites during runtime.
Made in Unity 2021.3.38f1 using the 2D Animation Package (AnimationModule)
/Assets/DemoAnimation.anim contains an animation, instructing that it show a Circle, wait, Triangle, wait, Circle.
At the root of the project, not inside assets, is /ReplacementHexagon.png.
When you press an onscreen UI button, the game will load ReplacementHexagon into memory, copy the animation, apply the hexagon as a replacement, and then set the animation.
The previous animation will still remain in memory, with a new copy of the animation.
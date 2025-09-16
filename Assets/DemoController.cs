using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class DemoController : MonoBehaviour
{
    public SpriteLibrary TargetSpriteLibrary;

    public void ReplaceHexagon()
    {
        // If we haven't loaded this override in before, load it now
        if (!TargetSpriteLibrary.HasOverride("Character Sprite", "Frame0"))
        {
            // Assuming that there is a file at exactly this location, with exactly this name, that is the exact dimensions of 256x256
            byte[] replacement = File.ReadAllBytes("./ReplacementHexagon.png");
            Texture2D incomingTexture = new Texture2D(1, 1);
            if (!incomingTexture.LoadImage(replacement))
            {
                Debug.LogError("Something unexpected happened while loading the replacement sprite.");
                return;
            }
            Sprite incomingSprite = Sprite.Create(incomingTexture, new Rect(0, 0, 256, 256), Vector2.one / 2f, 256);
            TargetSpriteLibrary.AddOverride(incomingSprite, "Character Animation", "Frame0");
        }
    }
}

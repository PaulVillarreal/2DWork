using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    public List<Sprite> sprites = new List<Sprite>();
    int currentFrame = 0;
    public float timePerFrame = 0.1f;
    float timer = 0;
    public SpriteRenderer spriteRenderer;

    public void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timePerFrame)
        {
            timer = 0;

            currentFrame++;

            if (currentFrame >= sprites.Count)
            {
                currentFrame = 0;
            }

            spriteRenderer.sprite = sprites[currentFrame];
        }
    }
}

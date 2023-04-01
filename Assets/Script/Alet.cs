using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alet : MonoBehaviour
{
    public Envanter envanterKod;

    public SpriteRenderer spriteRenderer;
    public Sprite bosSprite;
    public Sprite sprite;

    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (envanterKod.itemID == 4)
        {
            spriteRenderer.sprite = sprite;
        }

        if (envanterKod.itemID == 1 || envanterKod.itemID == 2 || envanterKod.itemID == 3 || envanterKod.itemID == 5)
        {
            spriteRenderer.sprite = bosSprite;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tower : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    // Start is called before the first frame update
    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    public static int w = 0;

    public void OnClick()
    {
        spriteRenderer.sprite = sprite1;
        
        w = 2;
        
    }
}

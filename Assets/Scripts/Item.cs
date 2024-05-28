using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Item : MonoBehaviour
{
    int waitingTime;

    public SpriteRenderer Img_Renderer;
    public Sprite Sprite01;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "item")
        {
            Img_Renderer.sprite = Sprite01;
        }
    }

    void Update()
    {

    }
}

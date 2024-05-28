using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class Item : MonoBehaviour
{
    float timer;
    int waitingTime;

    public SpriteRenderer Img_Renderer;
    public Sprite Sprite01;

    void Start()
    {
        timer = 0.0f;
        waitingTime = 5;
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
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            timer = 0;
        }
    }
}

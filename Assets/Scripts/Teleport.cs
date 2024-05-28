using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject targetObj;
    public GameObject toObj;
    public bool Tele = true;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            targetObj = collision.gameObject;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Tele == true)
            {
                StartCoroutine(TeleportRoutine());
            }
        }
    }

    IEnumerator TeleportRoutine()
    {
        yield return null;
        targetObj.transform.position = toObj.transform.position;
        Tele = false;
    }

}

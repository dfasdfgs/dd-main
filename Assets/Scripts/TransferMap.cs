using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferMap : MonoBehaviour
{
    public Transform ta;
    public Transform target; // �̵��� Ÿ�� ����

    public GameObject thePlayer;
    public GameObject theCamera;


    // �ڽ� �ݶ��̴��� ��� ���� �̺�Ʈ �߻�
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Player")
        {
            theCamera.transform.position = ta.transform.position;
            thePlayer.transform.position = target.transform.position;

        }
    }


}

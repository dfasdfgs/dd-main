using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text uiText;
    public Text uiT;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame


    public void Update()
    {
        if (PlayerMove.Getitem == true)
        {
            uiText.text = "������ ȹ�� : �Ϸ�!";
        }
        
        if (PlayerMove.Finish == true)
        {
            uiT.text = "���� : �Ϸ�!";
        }
    }
}
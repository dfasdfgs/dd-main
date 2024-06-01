using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float MaxSpeed;
    public float JumpPower;

    public GameObject Target;

    bool IsJumping;
    public static bool Getitem;
    public static bool Finish;

    Rigidbody2D PlayerRigid;


    private void Awake()
    {
        PlayerRigid = GetComponent<Rigidbody2D>();
        IsJumping = false;
    }

    private void FixedUpdate()
    {
        //������ �ӵ�
        float h = Input.GetAxisRaw("Horizontal");
        PlayerRigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);


        //������ �ְ� �ӵ�
        if (PlayerRigid.velocity.x > MaxSpeed)
            PlayerRigid.velocity = new Vector2(MaxSpeed, PlayerRigid.velocity.y);
        //���� �ְ� �ӵ�
        else if (PlayerRigid.velocity.x < MaxSpeed * (-1))
            PlayerRigid.velocity = new Vector2(MaxSpeed * (-1), PlayerRigid.velocity.y);
    }
    private void Update()
    {
        //����
        if (Input.GetButtonDown("Jump") && !IsJumping)
        {
            PlayerRigid.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            IsJumping = true;
        }

        //�ӵ� ����
        if (Input.GetButtonUp("Horizontal"))
        {
            PlayerRigid.velocity = new Vector2(PlayerRigid.velocity.normalized.x * 0.5f, PlayerRigid.velocity.y);
        }
    }

    //�浹 ���� �� ���� �ʱ�ȭ
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsJumping = false;

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "item")
        {
            Item item = collision.gameObject.GetComponent<Item>();
            switch (item.type)
            {
                case "item":
                    break;

            }
            Getitem = true;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("��ǥ���� ����");

            Finish = true;

        }
    }
}

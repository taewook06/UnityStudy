using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CatplayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxwalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //����
        if(Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            animator.SetBool("JumpTrigger",true);
            rigid2D.AddForce(transform.up * jumpForce);
        }
        else
        {
            animator.SetBool("JumpTrigger",false);
        }

        //�¿��̵�
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }

        //�÷��̾� �ӵ� üũ
        float speedx = Mathf.Abs(rigid2D.velocity.x);

        //���ǵ� ����
        if(speedx < maxwalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //�����̴� ���� ��ȯ
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if(rigid2D.velocity.y == 0)
        {
            //�÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ� ����
            animator.speed = speedx / 2.0f;

        }
        else   //����
        {
            animator.speed = 1.0f;
        }


        //�÷��̾ ȭ������� �����ٸ� ó������
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("Jumping");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("��");
        SceneManager.LoadScene("ClearScene");
    }
}

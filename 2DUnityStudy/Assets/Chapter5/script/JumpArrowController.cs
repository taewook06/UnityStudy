using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArrowController : MonoBehaviour
{
    //�����
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("BtnOnOff").GetComponent<StartBtn>().IsStart == true)
        {
            //�����Ӹ��� ������� ���Ͻ�Ų��.
            gameObject.transform.Translate(0, -0.1f, 0);

            //ȭ�� ������ ������ �Ҹ��Ѵ�.
            if (gameObject.transform.position.y < -5.0f)
            {
                Destroy(gameObject);
            }

            //�浹����
            Vector2 p1 = gameObject.transform.position; //ȭ��ǥ
            Vector2 p2 = player.transform.position; //�÷��̾�

            Vector2 dir = p1 - p2;

            float d = dir.magnitude; //�Ÿ��� ��ȯ

            float r1 = 0.5f; //ȭ��ǥ�� �ݰ�    
            float r2 = 1.0f; //�÷��̾��� �ݰ� 

            //�������
            if (d <= r1 + r2)
            {
                GameObject director = GameObject.Find("GameManager");
                director.GetComponent<GameManager>().DecreaseHp();

                Destroy(gameObject);

            }
        }
    }   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Transform upLog;
    public Transform downLog;
    public bool isDownObstacle = false;
    public float speed;
    private bool alreadyCreated = false;
    private bool gotPoint = false;
    private GameObject bird;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        bird = GameObject.Find("Player");

        body.velocity = Vector2.up * speed;
        InvokeRepeating("Switch", 0, 2); //�̵� ���� ����
    }

    // Update is called once per frame
    void Update()
    {
        float birdX = bird.transform.position.x;

        //���� �ִ� ���ع��� �����Ÿ���ŭ ���� ���� ����
        if(isDownObstacle)
        {
            if(GetComponent<Renderer>().isVisible && !alreadyCreated)
            {
                CreateNextObstacles();
                alreadyCreated = true;
            }
            //������ �ش� ��ġ���� ������
            if(!gotPoint && transform.position.x < birdX)
            {
                //��������
                LevelManager.instance.UpdatePoints();
                gotPoint = true;
            }
        }

        //�ڷ� �Ѿ�� ����
        if(transform.position.x < birdX -6)
        {
            Destroy(gameObject);
        }

    }

    void CreateNextObstacles()
    {
        //��ġ ���� ����
        float nextX = transform.position.x + Random.Range(6, 10);
        float targetY = Random.Range(11f, -2.5f);
        float deltaY = Random.Range(8f, 9f);

        //��ġ ����
        Vector3 upLogPostion = new Vector3(nextX, targetY + deltaY, transform.position.z);
        Vector3 downLogPosition = new Vector3(nextX, targetY - deltaY, transform.position.z);

        Transform upLogObject = Instantiate(upLog, upLogPostion, Quaternion.identity);
        Transform downLogObject = Instantiate(downLog, downLogPosition, Quaternion.identity);

        //�������� �ƴ��� üũ�� (����)
        bool shouldMove = Random.Range(1, 10) % 3 == 0;
        if(shouldMove)
        {
            upLogObject.GetComponent<Obstacle>().speed = 1;
            downLogObject.GetComponent<Obstacle>().speed = 1;

        }
        else
        {
            upLogObject.GetComponent<Obstacle>().speed = 0;
            downLogObject.GetComponent<Obstacle>().speed = 0;
        }
    }
    void Switch()
    {
        body.velocity *= -1;
    }
}

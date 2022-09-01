using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteController : MonoBehaviour
{
    public GameObject Chance;
    float rotSpeed = 0; // ȸ�� �ӵ�
    bool end = false;
    public int carMoveChance;
    

    // Start is called before the first frame update
    void Start()
    {
        Chance = GameObject.Find("Chance");
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.GetComponent<RouletteController>().enabled = true;  //��ũ��Ʈ �ѱ�
        {
            //Ŭ���ϴ� ���� ȸ���Ѵ�.
            if (Input.GetMouseButton(0))
            {
                rotSpeed = 10;
                end = true;
            }
            //ȸ�� �ӵ��� ���δ�.
            rotSpeed *= 0.96f;

            //ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��. 
            gameObject.transform.Rotate(0, 0, rotSpeed);

            //���
            if (rotSpeed <= 0.01)
            {

                if (end == true)
                {
                    if (gameObject.transform.eulerAngles.z > 330 || gameObject.transform.eulerAngles.z <= 30)
                    {
                        Debug.Log("��� ����");
                        carMoveChance = 1;
                        Chance.GetComponent<Text>().text = $"���� ��ȸ: {carMoveChance}";
                    }
                    else if (gameObject.transform.eulerAngles.z > 30 && gameObject.transform.eulerAngles.z <= 90)
                    {
                        Debug.Log("��� ����");
                        carMoveChance = 2;
                        Chance.GetComponent<Text>().text = $"���� ��ȸ: {carMoveChance}";
                    }
                    else if (gameObject.transform.eulerAngles.z > 90 && gameObject.transform.eulerAngles.z <= 150)
                    {
                        Debug.Log("��� �ſ� ����");
                        carMoveChance = 1;
                        Chance.GetComponent<Text>().text = $"���� ��ȸ: {carMoveChance}";
                    }
                    else if (gameObject.transform.eulerAngles.z > 150 && gameObject.transform.eulerAngles.z <= 210)
                    {
                        Debug.Log("��� ����");
                        carMoveChance = 3;
                        Chance.GetComponent<Text>().text = $"���� ��ȸ: {carMoveChance}";
                    }
                    else if (gameObject.transform.eulerAngles.z > 210 && gameObject.transform.eulerAngles.z <= 270)
                    {
                        Debug.Log("��� ����");
                        carMoveChance = 2;
                        Chance.GetComponent<Text>().text = $"���� ��ȸ: {carMoveChance}";
                    }
                    else
                    {
                        Debug.Log("��� ����");
                        carMoveChance = 4;
                        Chance.GetComponent<Text>().text = $"���� ��ȸ: {carMoveChance}";
                    }
                    end = false;

                    gameObject.GetComponent<RouletteController>().enabled = false;  //�귿�� �� �� ������ ��ũ��Ʈ ����
                }
            }
        }
    }  
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //ȸ���ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        //Ŭ���ϸ� ȸ���Ѵ�.
        if (Input.GetMouseButton(0))
=======
        //Ŭ���ϴ� ���� ȸ���ϰ�, end�� true�� �ʱ�ȭ
        if (Input.GetMouseButton(0)) 
>>>>>>> Stashed changes
        {
            rotSpeed = 5;
=======
        //Ŭ���ϴ� ���� ȸ���ϰ�, end�� true�� �ʱ�ȭ
        if (Input.GetMouseButton(0)) 
        {
            rotSpeed = 10;
            end = true; 
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }
        //�ӵ��� ���δ�.
        rotSpeed *= 0.96f;

        //ȸ���ӵ���ŭ �귿�� ȸ����Ų��.
        gameObject.transform.Rotate(0, 0, rotSpeed);
<<<<<<< Updated upstream
=======

        if (rotSpeed <= 0.01) //�ӵ��� 0.01�ʺ��� ���� �� (����)
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
            }
        }
>>>>>>> Stashed changes
    }
}

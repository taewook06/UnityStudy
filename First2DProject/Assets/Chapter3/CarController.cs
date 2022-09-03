using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    int RemainChance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance > 0 ) // �귿�� carMoveChance�� 0���� Ŭ ��
        {
            
            
                //���콺 Ŭ������ ��
                if (Input.GetMouseButtonDown(0))
                {
                    //���콺 ��ġ��ǥ ����
                    startPos = Input.mousePosition;
                }

                //���콺Ŭ������ ���� ��
                else if (Input.GetMouseButtonUp(0))
                {
                    Vector2 endPos = Input.mousePosition;
                    float swipeLiength = endPos.x - startPos.x;


                    speed = swipeLiength / 500.0f;

                    GetComponent<AudioSource>().Play();


                    GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance -= 1; //�̵��ϰ� ���� carMoveChance -1 
                    RemainChance = GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance; //�귿�� carMoveChance -> RemainChance ����                  
                    GameObject.Find("Chance").GetComponent<Text>().text = $"���� ��ȸ:{RemainChance }";

                  

                }
 
                transform.Translate(speed, 0, 0);

                speed *= 0.98f;
            


            if (GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance == 0) //���� ��ȸ�� 0�� ��
            {              
               
                
                    GameObject.Find("Chance").GetComponent<Text>().text = "��ȸ�� ��� ����Ͽ����ϴ�.";
                
                      
            }
            
        }                
        
    }
   
}

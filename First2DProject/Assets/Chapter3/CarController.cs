using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    bool OverText = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance > 0)
        {
            while(GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance > 0)
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

                    Reduction();
                }

                transform.Translate(speed, 0, 0);

                speed *= 0.98f;
                
            }
            OverText = true;           
        }
        else if (OverText == true)
        {
            if(GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance == 0)
            {
                GameObject.Find("Chance").GetComponent<Text>().text = "��ȸ�� ��� ����Ͽ����ϴ�.";
                OverText = false;
            }
           
        }          
    }
    static void Reduction()
    {
        GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance -= GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance;
    }
   
}

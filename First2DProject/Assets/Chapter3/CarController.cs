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

        if (GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance > 0 ) // 룰렛의 carMoveChance가 0보다 클 때
        {
            
            
                //마우스 클릭했을 때
                if (Input.GetMouseButtonDown(0))
                {
                    //마우스 위치좌표 저장
                    startPos = Input.mousePosition;
                }

                //마우스클릭에서 땠을 때
                else if (Input.GetMouseButtonUp(0))
                {
                    Vector2 endPos = Input.mousePosition;
                    float swipeLiength = endPos.x - startPos.x;


                    speed = swipeLiength / 500.0f;

                    GetComponent<AudioSource>().Play();


                    GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance -= 1; //이동하고 나면 carMoveChance -1 
                    RemainChance = GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance; //룰렛의 carMoveChance -> RemainChance 저장                  
                    GameObject.Find("Chance").GetComponent<Text>().text = $"남은 기회:{RemainChance }";

                  

                }
 
                transform.Translate(speed, 0, 0);

                speed *= 0.98f;
            


            if (GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance == 0) //남은 기회가 0일 때
            {              
               
                
                    GameObject.Find("Chance").GetComponent<Text>().text = "기회를 모두 사용하였습니다.";
                
                      
            }
            
        }                
        
    }
   
}

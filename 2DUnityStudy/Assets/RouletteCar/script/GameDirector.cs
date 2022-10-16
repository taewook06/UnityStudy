using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    public float lenght;
    public bool play;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {   
        //깃발과 차의 거리를 구하는 공식.
        lenght = flag.transform.position.x - car.transform.position.x;

        distance.GetComponent<Text>().text = "남은거리 :" + lenght.ToString("F2");

        if (GameObject.Find("car").GetComponent<CarController>().speed <= 0.001 )
        {            

                if (lenght <= 3 && lenght >= 0)
                {
                    GameObject.Find("Chance").GetComponent<Text>().text = "승리!";

                }
                else if (((lenght > 3 || lenght < 0) && GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance == 0) || lenght <0 )
                {
                   
                        GameObject.Find("Chance").GetComponent<Text>().text = "패배...";

                      play = false;
                }
                               
        }
    }
}

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
        //��߰� ���� �Ÿ��� ���ϴ� ����.
        lenght = flag.transform.position.x - car.transform.position.x;

        distance.GetComponent<Text>().text = "�����Ÿ� :" + lenght.ToString("F2");

        if (GameObject.Find("car").GetComponent<CarController>().speed <= 0.001 )
        {            

                if (lenght <= 3 && lenght >= 0)
                {
                    GameObject.Find("Chance").GetComponent<Text>().text = "�¸�!";

                }
                else if (((lenght > 3 || lenght < 0) && GameObject.Find("roulette").GetComponent<RouletteController>().carMoveChance == 0) || lenght <0 )
                {
                   
                        GameObject.Find("Chance").GetComponent<Text>().text = "�й�...";

                      play = false;
                }
                               
        }
    }
}

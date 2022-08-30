using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteController : MonoBehaviour
{
    GameObject Chance;
    float rotSpeed = 0; // 회전 속도
    bool end = false;

    // Start is called before the first frame update
    void Start()
    {
        Chance = GameObject.Find("Chance");
    }

    // Update is called once per frame
    void Update()
    {
        //클릭하는 동안 회전한다.
        if (Input.GetMouseButton(0))
        {
            rotSpeed = 10;
            end = true;
        }
        //회전 속도를 줄인다.
        rotSpeed *= 0.96f;

        //회전 속도만큼 룰렛을 회전시킨다. 
        gameObject.transform.Rotate(0, 0, rotSpeed);

        //출력
        if (rotSpeed <= 0.01)
        {

            if (end == true)
            {
                if (gameObject.transform.eulerAngles.z > 330 || gameObject.transform.eulerAngles.z <= 30)
                {
                    Debug.Log("운수 나쁨");
                    Chance.GetComponent<Text>().text = "뽑은 기회: 1";
                }
                else if (gameObject.transform.eulerAngles.z > 30 && gameObject.transform.eulerAngles.z <= 90)
                {
                    Debug.Log("운수 대통");
                    Chance.GetComponent<Text>().text = "뽑은 기회: 2";
                }
                else if (gameObject.transform.eulerAngles.z > 90 && gameObject.transform.eulerAngles.z <= 150)
                {
                    Debug.Log("운수 매우 나쁨");
                    Chance.GetComponent<Text>().text = "뽑은 기회: 1";
                }
                else if (gameObject.transform.eulerAngles.z > 150 && gameObject.transform.eulerAngles.z <= 210)
                {
                    Debug.Log("운수 보통");
                    Chance.GetComponent<Text>().text = "뽑은 기회: 3";
                }
                else if (gameObject.transform.eulerAngles.z > 210 && gameObject.transform.eulerAngles.z <= 270)
                {
                    Debug.Log("운수 조심");
                    Chance.GetComponent<Text>().text = "뽑은 기회: 2";
                }
                else
                {
                    Debug.Log("운수 좋음");
                    Chance.GetComponent<Text>().text = "뽑은 기회: 4";
                }
                end = false;
            }
        }
    }
}
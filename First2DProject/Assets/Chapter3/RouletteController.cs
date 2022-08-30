using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //회전속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        //클릭하면 회전한다.
        if (Input.GetMouseButton(0))
=======
        //클릭하는 동안 회전하고, end를 true로 초기화
        if (Input.GetMouseButton(0)) 
>>>>>>> Stashed changes
        {
            rotSpeed = 5;
=======
        //클릭하는 동안 회전하고, end를 true로 초기화
        if (Input.GetMouseButton(0)) 
        {
            rotSpeed = 10;
            end = true; 
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }
        //속도를 줄인다.
        rotSpeed *= 0.96f;

        //회전속도만큼 룰렛을 회전시킨다.
        gameObject.transform.Rotate(0, 0, rotSpeed);
<<<<<<< Updated upstream
=======

        if (rotSpeed <= 0.01) //속도가 0.01초보다 낮을 때 (멈춤)
        {

            if (end == true)
            {
                if (gameObject.transform.eulerAngles.z > 330 || gameObject.transform.eulerAngles.z <= 30)
                {
                    Debug.Log("운수 나쁨");
                    carMoveChance = 1;
                    Chance.GetComponent<Text>().text = $"뽑은 기회: {carMoveChance}";
                }
                else if (gameObject.transform.eulerAngles.z > 30 && gameObject.transform.eulerAngles.z <= 90)
                {
                    Debug.Log("운수 대통");
                    carMoveChance = 2;
                    Chance.GetComponent<Text>().text = $"뽑은 기회: {carMoveChance}";
                }
                else if (gameObject.transform.eulerAngles.z > 90 && gameObject.transform.eulerAngles.z <= 150)
                {
                    Debug.Log("운수 매우 나쁨");
                    carMoveChance = 1;
                    Chance.GetComponent<Text>().text = $"뽑은 기회: {carMoveChance}";
                }
                else if (gameObject.transform.eulerAngles.z > 150 && gameObject.transform.eulerAngles.z <= 210)
                {
                    Debug.Log("운수 보통");
                    carMoveChance = 3;
                    Chance.GetComponent<Text>().text = $"뽑은 기회: {carMoveChance}";
                }
                else if (gameObject.transform.eulerAngles.z > 210 && gameObject.transform.eulerAngles.z <= 270)
                {
                    Debug.Log("운수 조심");
                    carMoveChance = 2;
                    Chance.GetComponent<Text>().text = $"뽑은 기회: {carMoveChance}";
                }
                else
                {
                    Debug.Log("운수 좋음");
                    carMoveChance = 4;
                    Chance.GetComponent<Text>().text = $"뽑은 기회: {carMoveChance}";
                }
                end = false; 
            }
        }
>>>>>>> Stashed changes
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

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
        float lenght = flag.transform.position.x - car.transform.position.x;

        distance.GetComponent<Text>().text = "�����Ÿ� :" + lenght.ToString("F2");
    }
}

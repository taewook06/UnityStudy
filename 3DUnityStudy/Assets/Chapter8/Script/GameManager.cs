using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //static 다른 스크립트에서 가져다 쓸 수 있음. (싱글톤)

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    GameObject timerText;
    GameObject pointText;
    GameObject generator;

    float time = 30.0f;
    public int point = 0;
    float Light = 160;
    bool StartOn = true;

    public void GetApple()
    {
        point += 100;

    }
    public void GetBomb()
    {
        if(point < 0)
        {
            point *= 2;
        }
        else if( point > 0)
        {
            point /= 2;
        }        
    }

    private void Start()
    {
        timerText = GameObject.Find("Time");
        pointText = GameObject.Find("Point");
        generator = GameObject.Find("ItemGenerator");
    }   
    void isStart()
    {
         StartOn = false;
    }
    private void Update()
    {              
        if(StartOn == true)
        {
            Invoke("isStart", 30.0f);

            Light += Time.deltaTime;
            GameObject.Find("Directional Light").transform.eulerAngles = new Vector3(Light, 0, 0);

            time -= Time.deltaTime;
            timerText.GetComponent<TMP_Text>().text = time.ToString("F1");
            pointText.GetComponent<TMP_Text>().text = point.ToString() + "point";

            if (this.time < 0)
            {
                this.time = 0;
                this.generator.GetComponent<ItemGenerator>().SetParameter(10000.0f, 0, 0);
            }
            else if (0 <= this.time && this.time < 5)
            {
                this.generator.GetComponent<ItemGenerator>().SetParameter(0.9f, -0.04f, 3);
            }
            else if (5 <= this.time && this.time < 10)
            {
                this.generator.GetComponent<ItemGenerator>().SetParameter(0.4f, -0.06f, 6);
            }
            else if (10 <= this.time && this.time < 20)
            {
                this.generator.GetComponent<ItemGenerator>().SetParameter(0.7f, -0.04f, 4);
            }
            else if (20 <= this.time && this.time < 30)
            {
                this.generator.GetComponent<ItemGenerator>().SetParameter(1.0f, -0.03f, 2);
            }
        }        
    }
}

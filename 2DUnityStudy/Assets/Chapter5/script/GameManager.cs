using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject hpGauge;

    // Start is called before the first frame update
    void Start()
    {
        hpGauge = GameObject.Find("Hp");
    }
    void Update()
    {
        if( hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            GameObject.Find("BtnOnOff").GetComponent<StartBtn>().IsStart = false;
            GameObject.Find("GameOver").GetComponent<Text>().text = "Game Over";
        }
    }

    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}

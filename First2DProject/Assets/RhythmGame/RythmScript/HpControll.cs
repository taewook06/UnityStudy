using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpControll : MonoBehaviour
{
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        hpGauge = GameObject.Find("Hp");
    }

    // Update is called once per frame
    void Update()
    {
        if (hpGauge.GetComponent<Image>().fillAmount == 0)
        {

        }
    }
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}

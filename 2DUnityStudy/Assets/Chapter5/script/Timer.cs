using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public Text textTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("BtnOnOff").GetComponent<StartBtn>().IsStart == true)
        {
            LimitTime += Time.deltaTime;
            textTimer.text = "½Ã°£ :" + Mathf.Round(LimitTime);
            if(GameObject.Find("BtnOnOff").GetComponent<StartBtn>().IsStart == true)
            {
                return;
            }
        }
        
        
    }
}

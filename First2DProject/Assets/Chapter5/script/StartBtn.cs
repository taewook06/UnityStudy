using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn : MonoBehaviour
{
    public bool IsStart;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnStart()
    {
        IsStart = true;
        Destroy(GameObject.Find("StartBtn"));
        

    }
}

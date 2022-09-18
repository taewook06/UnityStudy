using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    GameObject button;
    public bool MusicPlay;
    public bool IsStart;
    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnClick()
    {
        MusicPlay = true;
        IsStart = true;
        Destroy(button);
       
    }
}

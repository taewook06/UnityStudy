using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour   
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("ButtonClick").GetComponent<Button>().MusicPlay == true)
        {
            GetComponent<AudioSource>().Play();
            GameObject.Find("ButtonClick").GetComponent<Button>().MusicPlay = false;
        }
    }
}

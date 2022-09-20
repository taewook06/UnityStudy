using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour   
{
    GameObject HitBox;
    GameObject up;
    GameObject down;
    GameObject left;
    GameObject right;   

    // Start is called before the first frame update
    void Start()
    {
        HitBox = GameObject.Find("HitBox");
        up = GameObject.Find("up");
        down = GameObject.Find("down");
        left = GameObject.Find("left");
        right = GameObject.Find("right");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ButtonClick").GetComponent<Button>().IsStart == true)
        {
            if (GameObject.Find("ButtonClick").GetComponent<Button>().MusicPlay == true)
            {
                GetComponent<AudioSource>().Play();
                GameObject.Find("ButtonClick").GetComponent<Button>().MusicPlay = false;
            }
         
        }


    }  
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.transform.tag == "UpArrow")
        {
            GameObject.Find("Hp").GetComponent<HpControll>().DecreaseHp();
            GameObject.Find("NodeBox").GetComponent<NodeHit>().IsUpArrow = false;         
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "DownArrow")
        {
            GameObject.Find("Hp").GetComponent<HpControll>().DecreaseHp();
            GameObject.Find("NodeBox").GetComponent<NodeHit>().IsDownArrow = false;
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "LeftArrow")
        {
            GameObject.Find("Hp").GetComponent<HpControll>().DecreaseHp();
            GameObject.Find("NodeBox").GetComponent<NodeHit>().IsLeftArrow = false;
            Destroy(collision.gameObject);
        }
        if (collision.transform.tag == "RightArrow")
        {
            GameObject.Find("Hp").GetComponent<HpControll>().DecreaseHp();
            GameObject.Find("NodeBox").GetComponent<NodeHit>().IsRightArrow = false;
            Destroy(collision.gameObject);
        }      

    }
}

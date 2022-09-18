using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeHit : MonoBehaviour
{
    public bool IsUpArrow;
    public bool IsDownArrow;
    public bool IsLeftArrow;
    public bool IsRightArrow;

    GameObject UpArrow;
    GameObject DownArrow;
    GameObject LeftArrow;
    GameObject RightArrow;
    // Start is called before the first frame update
    void Start()
    {
        UpArrow = GameObject.Find("RythmGenerator").GetComponent<RyGenerator>().genObj;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ButtonClick").GetComponent<Button>().IsStart == true)
        {
            if (IsUpArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    Destroy(UpArrow);
                    IsUpArrow = false;
                }
            }
            if (IsDownArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    Destroy(DownArrow);
                    IsDownArrow = false;
                }
            }
            if (IsLeftArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Destroy(LeftArrow);
                    IsLeftArrow = false;
                }
            }
            if (IsRightArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Destroy(RightArrow);
                    IsRightArrow = false;
                }
            }
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.transform.tag == "UpArrow")
        {
            IsUpArrow = true;     
        }
        if (collision.transform.tag == "DownArrow")
        {
            IsDownArrow = true;
        }
        if (collision.transform.tag == "LeftArrow")
        {
            IsLeftArrow = true;
        }
        if (collision.transform.tag == "RightArrow")
        {
            IsRightArrow = true;
        }
        //닿지 않았을 때 아무거라도 키를 눌렀을시, Hp차감 
       

    }
    
}

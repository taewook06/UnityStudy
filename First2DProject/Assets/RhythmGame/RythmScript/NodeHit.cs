using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeHit : MonoBehaviour
{
    public bool IsUpArrow;
    public bool IsDownArrow;
    public bool IsLeftArrow;
    public bool IsRightArrow;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
      
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.transform.tag == "UpArrow") //닿으면 IsUpArrow를 true -> RyGenerator스크립트에 신호주기
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

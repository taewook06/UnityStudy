using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeHit : MonoBehaviour
{
    public bool IsUpArrow;
    public bool IsDownArrow;
    public bool IsLeftArrow;
    public bool IsRightArrow;

    public bool Foul;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (GameObject.Find("ButtonClick").GetComponent<Button>().IsStart == true)
        {

            if (((IsUpArrow == false) && (IsDownArrow == false) && (IsLeftArrow == false) && (IsRightArrow == false)) && Input.anyKeyDown) //아무것도 닿지 않았을 때      
            {
                GameObject.Find("Hp").GetComponent<HpControll>().DecreaseHp(); //DecreaseHp = Hp깎임
            }
        }
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

    }
    
}

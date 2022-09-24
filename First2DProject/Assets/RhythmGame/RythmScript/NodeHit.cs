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

            if (((IsUpArrow == false) && (IsDownArrow == false) && (IsLeftArrow == false) && (IsRightArrow == false)) && Input.anyKeyDown) //�ƹ��͵� ���� �ʾ��� ��      
            {
                GameObject.Find("Hp").GetComponent<HpControll>().DecreaseHp(); //DecreaseHp = Hp����
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.transform.tag == "UpArrow") //������ IsUpArrow�� true -> RyGenerator��ũ��Ʈ�� ��ȣ�ֱ�
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

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
        if(Foul == true) //���� �ʾ��� �� �ƹ��Ŷ� Ű�� ��������, Hp����      
        {
            if(Input.anyKey) 
            {
                GameObject.Find("Hp").GetComponent<HpControll>().DecreaseHp(); //DecreaseHp = Hp����
            }
            Foul = false;
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

         // �ƹ��͵� ���� �ʾ��� �� �Ŀ� ��
        if((collision.transform.tag != "UpArrow") && (collision.transform.tag != "DownArrow") && (collision.transform.tag != "LeftArrow") && (collision.transform.tag != "RightArrow"))
        {
            Foul = true;
        }
    }
    
}

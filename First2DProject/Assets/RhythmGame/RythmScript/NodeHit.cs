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

        //���� �ʾ��� �� �ƹ��Ŷ� Ű�� ��������, Hp����       

    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //���� ȭ��ǥ -> ������ �̵�
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-3, 0, 0);
        }
        //������ ȭ��ǥ -> ���� �̵�
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(3, 0, 0);
        }
        
    }
}

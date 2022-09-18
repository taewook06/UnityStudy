using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RyGenerator : MonoBehaviour
{
    float span = 1.0f;
    float delta = 0;

    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;    

    // Start is called before the first frame update
    void Start()
    {
        
            
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("ButtonClick").GetComponent<Button>().IsStart == true)
        {
            //Time.deltaTime <- �����Ӱ� ������ ������ �ð�
            delta += Time.deltaTime;
            if (delta > span) //delta�� 1�ʺ��� ū ���
            {
               GameObject genObj;

                int ArrowNumber = Random.Range(0, 4);

                switch (ArrowNumber)
                {
                    case 0:
                        genObj = Instantiate(up);
                        break;
                    case 1:
                        genObj = Instantiate(down);
                        break;
                    case 2:
                        genObj = Instantiate(left);
                        break;
                    case 3:
                        genObj = Instantiate(right);
                        break;
                }
                delta = 0;

            }
        }
       


    }
    public void GenArrow(float number)
    {
        Instantiate(up);
        Instantiate(down);
        Instantiate(left);
        Instantiate(right);
    }
}

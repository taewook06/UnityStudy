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

            List<string> prefabList = new List<string>();

            //Time.deltaTime <- �����Ӱ� ������ ������ �ð�
            delta += Time.deltaTime;
            if (delta > span) //delta�� 1�ʺ��� ū ���
            {              

                int ArrowNumber = Random.Range(0, 4);

                switch (ArrowNumber)  //�����ϰ� �̵����� ����Ʈ �߰�
                {
                    case 0:                        
                        prefabList.Add("up");
                        break;
                    case 1:                        
                        prefabList.Add("down");
                        break;
                    case 2:                      
                        prefabList.Add("left");
                        break;
                    case 3:                      
                        prefabList.Add("right");
                        break;
                }
                string s1 = prefabList[0]; //���� ����Ʈ�� s1�� ����

                switch(s1) //s1�� ���� ȭ�����
                {
                    case "up":
                        Instantiate(up);
                        break;
                    case "down":
                        Instantiate(down);
                        break;
                    case "left":
                        Instantiate(left);
                        break;
                    case "right":
                        Instantiate(right);
                        break;
                }                
                delta = 0;

            }
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsUpArrow == true) //NodeHit��ũ��Ʈ���� ��ȣ����
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    prefabList.Remove("up");
                    Destroy(up); 
                    GameObject.Find("NodeBox").GetComponent<NodeHit>().IsUpArrow = false;
                }
            }
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsDownArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    prefabList.Remove("down");
                    Destroy(down);
                    GameObject.Find("NodeBox").GetComponent<NodeHit>().IsDownArrow = false;
                }
            }
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsLeftArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    prefabList.Remove("left");
                    Destroy(left);
                    GameObject.Find("NodeBox").GetComponent<NodeHit>().IsLeftArrow = false;
                }
            }
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsRightArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    prefabList.Remove("right");
                    Destroy(right);
                    GameObject.Find("NodeBox").GetComponent<NodeHit>().IsRightArrow = false;
                }
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

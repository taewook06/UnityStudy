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

            //Time.deltaTime <- 프레임과 프레임 사이의 시간
            delta += Time.deltaTime;
            if (delta > span) //delta가 1초보다 큰 경우
            {              

                int ArrowNumber = Random.Range(0, 4);

                switch (ArrowNumber)  //랜덤하게 이동방향 리스트 추가
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
                string s1 = prefabList[0]; //담은 리스트를 s1에 넣음

                switch(s1) //s1에 따라 화살생성
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
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsUpArrow == true) //NodeHit스크립트에서 신호받음
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

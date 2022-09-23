using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RyGenerator : MonoBehaviour
{
    float span;
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

            span = Random.Range(1, 5);

            switch(span)
            {
                case 1:
                    span = 0.4f;
                    break;
                case 2:
                    span = 0.6f;
                    break;
                case 3:
                    span = 0.8f;
                    break;
                case 4:
                    span = 1.0f;
                    break;
            }

            //Time.deltaTime <- 프레임과 프레임 사이의 시간
            delta += Time.deltaTime;
            if (delta > span) //delta가 1초보다 큰 경우
            {              

                int ArrowNumber = Random.Range(0, 4);

                switch (ArrowNumber)
                { 
                    case 0:
                        Instantiate(up);
                        break;
                    case 1:
                        Instantiate(down);
                        break;
                    case 2:
                        Instantiate(left);
                        break;
                    case 3:
                        Instantiate(right);
                        break;
                }
               
                delta = 0;

            }
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsUpArrow == true) //NodeHit스크립트에서 신호받음
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {                  
                    Destroy(GameObject.Find("up(Clone)"));  
                    GameObject.Find("NodeBox").GetComponent<NodeHit>().IsUpArrow = false;
                }
            }
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsDownArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {                   
                    Destroy(GameObject.Find("down(Clone)"));
                    GameObject.Find("NodeBox").GetComponent<NodeHit>().IsDownArrow = false;
                }
            }
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsLeftArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Destroy(GameObject.Find("left(Clone)"));
                    GameObject.Find("NodeBox").GetComponent<NodeHit>().IsLeftArrow = false;
                }
            }
            if (GameObject.Find("NodeBox").GetComponent<NodeHit>().IsRightArrow == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Destroy(GameObject.Find("right(Clone)"));
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

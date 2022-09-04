using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
   
    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime <- 프레임과 프레임 사이의 시간
        delta += Time.deltaTime; 
        if(delta > span) //delta가 1초보다 큰 경우
        {
            GameObject genObj = Instantiate(arrowPrefab);
            delta = 0;
            int px = Random.Range(-6, 7); //-6부터 6 랜덤.

            genObj.transform.position = new Vector3(px, 7, 0);
        }
       
    }   
}

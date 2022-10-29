using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 0.2f;
    float delta = 0;
   
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("BtnOnOff").GetComponent<StartBtn>().IsStart == true)
        {    //Time.deltaTime <- �����Ӱ� ������ ������ �ð�
            delta += Time.deltaTime;
            if (delta > span) //delta�� 1�ʺ��� ū ���
            {
                GameObject genObj = Instantiate(arrowPrefab);
                delta = 0;
                int px = Random.Range(-6, 7); //-6���� 6 ����.

                genObj.transform.position = new Vector3(px, 7, 0);
            }
        }
    }   
}
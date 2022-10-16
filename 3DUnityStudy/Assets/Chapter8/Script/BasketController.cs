using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; //���� ��
            if(Physics.Raycast(ray, out hit , Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x); //Round �ݿø�
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Apple")
       {
            GameManager.instance.GetApple(); //�̱�����
            aud.PlayOneShot(appleSE); //PlayOneShot�� �� ���� ���� ������.
       }
       else
       {
            GameManager.instance.GetBomb();
            aud.PlayOneShot(bombSE);
       }
        Destroy(other.gameObject);
    }
}

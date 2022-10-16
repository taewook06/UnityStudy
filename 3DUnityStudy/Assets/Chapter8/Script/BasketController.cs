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
            RaycastHit hit; //맞은 것
            if(Physics.Raycast(ray, out hit , Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x); //Round 반올림
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Apple")
       {
            GameManager.instance.GetApple(); //싱글톤사용
            aud.PlayOneShot(appleSE); //PlayOneShot는 한 번만 실행 시켜줌.
       }
       else
       {
            GameManager.instance.GetBomb();
            aud.PlayOneShot(bombSE);
       }
        Destroy(other.gameObject);
    }
}

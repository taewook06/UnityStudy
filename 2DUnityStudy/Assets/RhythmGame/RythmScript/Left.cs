using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = Random.Range(1, 5);

        switch (Speed)
        {
            case 1:
                gameObject.transform.Translate(Vector3.down * -0.01f);
                break;
            case 2:
                gameObject.transform.Translate(Vector3.down * -0.03f);
                break;
            case 3:
                gameObject.transform.Translate(Vector3.down * -0.07f);
                break;
            case 4:
                gameObject.transform.Translate(Vector3.down * -0.1f);
                break;
        }
    }
}

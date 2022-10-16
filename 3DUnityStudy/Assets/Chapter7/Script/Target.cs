using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{  

    public int BamNumber = 0;
    public int BoxNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BamNumber == 6 && BoxNumber == 4)
        {           
            GameObject.Find("Succeed").GetComponent<ParticleSystem>().Play();
            GameObject.Find("Succeed (1)").GetComponent<ParticleSystem>().Play();
        }
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Bam")
        {
            BamNumber += 1;
        }
        if (collision.transform.tag == "Box")
        {
            BoxNumber += 1;
        }
    }
    
}

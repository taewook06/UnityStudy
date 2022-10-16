using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamSongController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    public void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().isKinematic = true;
        if (collision.transform.tag == "Target")
        {
            GetComponent<ParticleSystem>().Play();
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamSongGenerator : MonoBehaviour
{
    public GameObject BamSongPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject BamSong = Instantiate(BamSongPrefab);          

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            BamSong.GetComponent<BamSongController>().Shoot(worldDir.normalized * 2000);
        }
    }
}

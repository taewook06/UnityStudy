using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    GameObject _enemy;

    // Update is called once per frame
    void Update()
    {
        if(_enemy == null)
        {
            float angle = Random.Range(0, 360);

            _enemy = Instantiate(enemyPrefab);
            _enemy.transform.position = new Vector3(-0.15f, 1, 10);
            _enemy.transform.Rotate(0, angle, 0);   
        }
    }
}

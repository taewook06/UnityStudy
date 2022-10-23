using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 1. 살아 있으면 움직임.

 2. 앞으로만 이동할 것.

 3. 내 앞에 특정 물체가 있는지 체크할 예정.
 
 4. 만약 특정 물체가 있는데, 그게 적이라면 공격한다.

 5. 벽일 경우 일정 거리만큼 가까워지면 방향 전환.
*/
public class WanderingAI : MonoBehaviour
{
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    [SerializeField] GameObject fireballPrefab;
    GameObject _fireball;
    bool _isAlive;

    // Start is called before the first frame update
    void Start()
    {
        _isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isAlive)
        {
            //살아 있는 경우
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform. forward);
            RaycastHit hit;

            if(Physics.SphereCast(ray, 0.75f, out hit))
            {
                GameObject hitobject = hit.transform.gameObject;

                if(hitobject.GetComponent<PlayerCharacter>())
                {
                    if (_fireball == null)
                    {
                        _fireball = Instantiate(fireballPrefab);
                        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        _fireball.transform.rotation = transform.rotation;
                    }
                }
                else if(hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }
    public void SetAlive(bool alive)
    {
        _isAlive = alive;
    }
}

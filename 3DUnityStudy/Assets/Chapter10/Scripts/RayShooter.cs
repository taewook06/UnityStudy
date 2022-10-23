using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    [SerializeField] GameObject bulletMarkPrefab;
    Camera _camera;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {       
        _camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked; //���콺 Ŀ���� ���.
        Cursor.visible = false;
    }

    void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            Ray ray = _camera.ScreenPointToRay(point);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;

                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                if(target != null)
                {
                    target.ReactToHit();
                }
                else
                {
                    StartCoroutine(SphereIndicator(hit.point));
                }
            }
        }
    }
    IEnumerator SphereIndicator(Vector3 pos)
    {
        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject sphere = Instantiate(bulletMarkPrefab);
        sphere.transform.position = pos;
        sphere.transform.LookAt(player);
    
        yield return new WaitForSeconds(1); //1�ʵڿ�
        
        Destroy(sphere);
    }
}

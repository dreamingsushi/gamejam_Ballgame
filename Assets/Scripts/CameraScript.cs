using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public Transform camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        camera.position = new Vector3(target.position.x, target.position.y, target.position.z - 10);
    }
}

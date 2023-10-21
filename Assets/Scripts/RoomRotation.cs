using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private Transform room;

    private bool levelComplete = false;

    public Vector3 rotationAxis = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        room = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (levelComplete)
        {
            StopRoomRotation();
        }
        else
        {
            
        }
    }

    public void StopRoomRotation()
    {
        room.rotation = Quaternion.RotateTowards(room.rotation, Quaternion.identity, rotationSpeed * Time.deltaTime);
        levelComplete = true;

    }

    public void startRoomRotation()
    {
        room.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}

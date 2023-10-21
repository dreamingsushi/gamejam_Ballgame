using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RoomRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject theFog;

    public BoxCollider2D door;
    public BoxCollider2D invisibleCollider;

    private Transform room;
    

    private bool levelComplete = false;
    private bool stopRotation = false;
    
    public Vector3 rotationAxis = Vector3.up;
    
    public TriggerScript triggerScript;

    // Start is called before the first frame update
    void Start()
    {
        room = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stopRotation)
        {
            StopRoomRotation();
            theFog.SetActive(false);
        }
        else if (triggerScript.startRotate)
        {
            startRoomRotation();
        }

        if (levelComplete)
        {
            door.isTrigger = true;
            invisibleCollider.isTrigger = true;
        }
    }

    public void StopRoomRotation()
    {
        room.rotation = Quaternion.RotateTowards(room.rotation, Quaternion.identity, rotationSpeed * Time.deltaTime);
        stopRotation = true;
        if (room.rotation == Quaternion.identity)
        {
            levelComplete = true;
        }

    }

    public void startRoomRotation()
    {
        room.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }

    
}

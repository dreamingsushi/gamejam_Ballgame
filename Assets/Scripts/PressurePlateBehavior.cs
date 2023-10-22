using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Step"))
        {
            if (!isActivated)
            {
                ActivateLever();
            }
        }
    }
    public bool isActivated = false;
    
    public void ActivateLever()
    {
        isActivated = true;
    }
    //public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateBehavior : MonoBehaviour
{
    public bool isActivated = false;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Step"))
        {
            if (!isActivated)
            {
                ActivateLever();
            }
        }
    }

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

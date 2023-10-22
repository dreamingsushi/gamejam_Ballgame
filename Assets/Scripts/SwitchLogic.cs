using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchLogic : MonoBehaviour
{
    public bool isActivated = false;

    //private bool canInteract = false;
    public bool canPress = false;
    public float interactionRange = 2f;

    private SwitchChecker switchChecker;
    public GameObject checker;

    // Start is called before the first frame update
    void Start()
    {
        switchChecker = checker.GetComponent<SwitchChecker>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canPress = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (canPress && Input.GetKeyDown(KeyCode.E))
        {
            if (!isActivated)
            {
                Debug.Log("Activated");

                isActivated = true;
                switchChecker.GetValue(1);
            }
        }
    }
}
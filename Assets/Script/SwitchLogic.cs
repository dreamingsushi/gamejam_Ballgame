using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchLogic : MonoBehaviour
{
    public bool isActivated = false;

    public GameObject IsSwitchOn;
    public GameObject IsSwitchOff;

    private bool canInteract = false;

    public float interactionRange = 2f;
    /*[SerializeField]
    private GameObject switcher;

    private int switchState;

    [SerializeField]
    private Sprite[] switchSprites;

    private Image switchImage; */

    // Start is called before the first frame update
    void Start()
    {
        IsSwitchOn.SetActive(false);


        /*switchState = 0;

        switchImage = GetComponent<Button>().image;
        switchImage.sprite = switchSprites[switchState];

        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff); */
    }

    /* private void TurnOnAndOff()
    {
        switchState = 1 - switchState;
        switchImage.sprite = switchSprites[switchState];
    } */

    private void OnMouseDown()
    {
        if (!isActivated) 
        {
            ActivateSwitch();
        }

        
    }

    public void ActivateSwitch()
    {
        isActivated = true;
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Other"))
        {
            canInteract = false;
        }
    } */

    // Update is called once per frame
    void Update()
    {
        /*if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            if (!isActivated)
            {
                ActivateSwitch();
            }
        } */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(IsSwitchOn.activeSelf) 
                {
                    IsSwitchOn.SetActive(false);
                }
                else if(!IsSwitchOn.activeSelf) 
                {
                    IsSwitchOn.SetActive(true);
                }
            }
        }
    }
}

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
    /*[SerializeField]
    private GameObject switcher;

    private int switchState;

    [SerializeField]
    private Sprite[] switchSprites;

    private Image switchImage; */

    // Start is called before the first frame update
    void Start()
    {
        switchChecker = checker.GetComponent<SwitchChecker>();
        //IsSwitchOn.SetActive(false);
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

    /* private void OnMouseDown()
    {
        if (!isActivated) 
        {
            ActivateSwitch();
        }

        
    } */

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                isActivated = true;
                Debug.Log("Activated");
            }
        }
    } */

    /*private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Other"))
        {
            canInteract = false;
        }
    } */

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

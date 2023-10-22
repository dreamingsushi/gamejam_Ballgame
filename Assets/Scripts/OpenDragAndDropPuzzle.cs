using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDragAndDropPuzzle : MonoBehaviour
{
    private bool CanPress = false;
    private CheckDragAndDropPuzzle dragdropPuzzle;
    public GameObject dragAndDropPuzzleChecker;
    // Start is called before the first frame update
    void Start()
    {
        dragdropPuzzle = dragAndDropPuzzleChecker.GetComponent<CheckDragAndDropPuzzle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanPress)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Pressed");

                dragdropPuzzle.GetIntValue(1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.gameObject.name);
            CanPress = true;
        }
    }
}

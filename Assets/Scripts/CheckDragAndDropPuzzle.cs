using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDragAndDropPuzzle : MonoBehaviour
{
    private int intValue = 0;
    private int puzzleWinCheck = 0;

    public GameObject EntireRoom;
    public GameObject PuzzleScreen;

    private RoomRotation roomRotation;
    public GameObject TheRoom;

    public GameObject VictoryChecker;
    private CheckWinGame checkWinGame;

    // Start is called before the first frame update
    void Start()
    {
        roomRotation = TheRoom.GetComponent<RoomRotation>();
        checkWinGame = VictoryChecker.GetComponent<CheckWinGame>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetIntValue(int value)
    {
        intValue += value;
        if (intValue >= 1)
        {
            Debug.Log("Open puzzle");
            roomRotation.stopRotation = true;
            EntireRoom.SetActive(false);
            PuzzleScreen.SetActive(true);
        }
    }

    public void GetWinsValue(int value)
    {
        puzzleWinCheck += value;
        Debug.Log(puzzleWinCheck);
        if (puzzleWinCheck >= 6) 
        {
            
            EntireRoom.SetActive(true);
            PuzzleScreen.SetActive(false);
            checkWinGame.CheckVictoryCondition(1);
        }
    }
}

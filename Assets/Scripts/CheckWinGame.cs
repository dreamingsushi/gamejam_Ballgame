using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckWinGame : MonoBehaviour
{
    private float IntValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckVictoryCondition(float value)
    {
        IntValue += value;
        Debug.Log(IntValue);
        if (IntValue >= 2f) 
        {
            SceneManager.LoadScene("VictoryScene");
        }
    }
}

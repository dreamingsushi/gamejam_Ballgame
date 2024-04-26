using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsPanel;
    private bool OptionIsOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        OptionsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("Main Logic");
    }

    public void OnClickOptions()
    {
        if (!OptionIsOpen) 
        {
            OptionsPanel.SetActive(true);
        }
        else if (OptionIsOpen) 
        {
        OptionsPanel.SetActive(false);
        }
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}

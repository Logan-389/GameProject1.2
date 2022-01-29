using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateTransfer : MonoBehaviour
{
    public string theDate;
    public GameObject inputField;
    public GameObject textDisplay;
    public string theCorrectDate;

    public static bool GameIsPausedCode = false;

    public GameObject codeEnterMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameIsPausedCode)
            {
                ResumeCode();
            }
            else
            {
                PauseCode();
            }
        }
    }
    public void ResumeCode()
    {
        codeEnterMenuUI.SetActive(false);
        //Time.timeScale = 1f;
        GameIsPausedCode = false;
    }

    void PauseCode()
    {
        codeEnterMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        GameIsPausedCode = true;
    }

    public void StoreDate()
    {
        theCorrectDate = "0427";
        theDate = inputField.GetComponent<Text>().text;
        if (theDate.Equals(theCorrectDate))
        {
            textDisplay.GetComponent<Text>().text = "The date " + theDate + " is correct!";
        } else
        {
            textDisplay.GetComponent<Text>().text = "The date " + theDate + " is incorrect!";
        }
        
    }
}

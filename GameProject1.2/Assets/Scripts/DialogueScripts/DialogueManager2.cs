using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager2 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject dialogueMenuUI;
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextDialogue()
    {
        if (dialogue1.activeSelf == true)
        {
            dialogue1.SetActive(false);
            dialogue2.SetActive(true);
        } else if (dialogue2.activeSelf == true)
        {
            dialogue2.SetActive(false);
            dialogue3.SetActive(true);
        } else if (dialogue3.activeSelf == true)
        {
            dialogue3.SetActive(false);
            dialogue1.SetActive(true);
            dialogueMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }

    }

}

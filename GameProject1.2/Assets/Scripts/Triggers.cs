using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    //public AudioSource sound1;

    public GameObject Bridge;
    Animator animator_Bridge;

    public GameObject tr_monster;

    public GameObject Door_Left;
    public GameObject Door_Right;
    Animator animator_FinalPuzzle1;
    Animator animator_FinalPuzzle2;

    void Start()
    {

        animator_Bridge = Bridge.GetComponent<Animator>();
        animator_FinalPuzzle1 = Door_Left.GetComponent<Animator>();
        animator_FinalPuzzle2 = Door_Right.GetComponent<Animator>();

    }

    public void OnTriggerStay(Collider col)
    {
        // Grab a referance to the triggered object's tag
        string tag = col.tag;

        // and compares it to the cases below.
        switch (tag)
        {
            case "BridgeAnimation":
                //Debug.Log("BridgeAnimation was triggered");
                animator_Bridge.SetTrigger("tr_bridge_anim");
                animator_Bridge.SetBool("bool_StandingByBridge", true);
                break;

            case "BadEndTrigger":
                Debug.Log("You got the bad end.");
                SceneManager.LoadScene("BadEnd");
                break;
            case "GoodEndTrigger":
                Debug.Log("You got the good end.");
                SceneManager.LoadScene("GoodEnd");
                break;
            case "FinalPuzzleTrigger":
                Debug.Log("Final Puzzle.");
                animator_FinalPuzzle1.SetTrigger("tr_FinalPuzzle");
                animator_FinalPuzzle2.SetTrigger("tr_FinalPuzzle");
                animator_FinalPuzzle1.SetBool("bool_StandingByEnd1", true);
                animator_FinalPuzzle2.SetBool("bool_StandingByEnd2", true);
                break;


        }
    }

    public void OnTriggerExit(Collider col)
    {

        // Grab a referance to the triggered object's tag
        string tag = col.tag;

        // and compares it to the cases below.
        switch (tag)
        {
            case "BridgeAnimation":
               // Debug.Log("BridgeAnimation was triggered (on exit)");
                animator_Bridge.SetTrigger("tr_bridge_anim");
                animator_Bridge.SetBool("bool_StandingByBridge", false);
                break;
            case "FinalPuzzleTrigger":
                animator_FinalPuzzle1.SetTrigger("tr_FinalPuzzle");
                animator_FinalPuzzle2.SetTrigger("tr_FinalPuzzle");
                animator_FinalPuzzle1.SetBool("bool_StandingByEnd1", false);
                animator_FinalPuzzle2.SetBool("bool_StandingByEnd2", false);
                break;

        }
    }
}

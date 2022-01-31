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
    Animator animator_Door_Left;
    public GameObject Door_Right;
    Animator animator_Door_Right;

    void Start()
    {
        animator_Bridge = Bridge.GetComponent<Animator>();
        animator_Door_Left = Door_Left.GetComponent<Animator>();
        animator_Door_Right = Door_Right.GetComponent<Animator>();
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
            case "DoorAnimation":
                Debug.Log("Door opened");
                animator_Door_Left.SetTrigger("tr_door_anim");
                animator_Door_Right.SetTrigger("tr_door_anim");
                animator_Door_Left.SetBool("bool_StandingByDoorLeft", true);
                animator_Door_Right.SetBool("bool_StandingByDoorRight", true);
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
            case "Door Animation":
                Debug.Log("Door opened");
                animator_Door_Left.SetTrigger("tr_door_anim");
                animator_Door_Right.SetTrigger("tr_door_anim");
                animator_Door_Left.SetBool("bool_StandingByDoorLeft", false);
                animator_Door_Right.SetBool("bool_StandingByDoorRight", false);
                break;

        }
    }
}

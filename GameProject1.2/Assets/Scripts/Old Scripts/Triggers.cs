using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    //public AudioSource sound1;

    public GameObject Chair;
    Animator animator_Chair;

    public GameObject Office_Space;
    Animator animator_Room;

    public GameObject Letter;
    Animator animator_Letter;

    void Start()
    {
        animator_Chair = Chair.GetComponent<Animator>();
        animator_Room = Office_Space.GetComponent<Animator>();
        animator_Letter = Letter.GetComponent<Animator>();
    }

    public void OnTriggerStay(Collider col)
    {
        // Grab a referance to the triggered object's tag
        string tag = col.tag;

        // and compares it to the cases below.
        switch (tag)
        {
            case "LetterAnimation":
                Debug.Log("LetterAnimation was triggered");
                animator_Letter.SetTrigger("tr_letter_anim");
                animator_Letter.SetBool("bool_Currently_Standing2", true);
                break;

            case "RoomAnimation":
                Debug.Log("RoomAnimation was triggered");
                animator_Room.SetTrigger("tr_room_anim");
                animator_Room.SetBool("bool_Currently_Standing", true);
                break;

            case "ChairAnimation":
                Debug.Log("ChairAnimation was triggered");
                animator_Chair.SetTrigger("tr_chair_anim");
                animator_Chair.SetBool("bool_Currently_Standing1", true);
                Debug.Log("\n Chair Boolean is true \n");
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
            case "LetterAnimation":
                Debug.Log("LetterAnimation was triggered");
                animator_Letter.SetTrigger("tr_letter_anim");
                animator_Letter.SetBool("bool_Currently_Standing2", false);
                break;

            case "RoomAnimation":
                Debug.Log("RoomAnimation was triggered");
                animator_Room.SetTrigger("tr_room_anim");
                animator_Room.SetBool("bool_Currently_Standing", false);
                break;

            case "ChairAnimation":
                Debug.Log("ChairAnimation was triggered");
                animator_Chair.SetTrigger("tr_chair_anim");
                animator_Chair.SetBool("bool_Currently_Standing1", false);
                break;

        }
    }
}

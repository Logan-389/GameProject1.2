using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    /*
    public GameObject Chair;
    Animator animator_Chair;

    public GameObject Office_Space;
    Animator animator_Room;

    public GameObject Letter;
    Animator animator_Letter;
    */

    public GameObject Bridge;
    Animator animator_Bridge;

    void Start()
    {
        /*
        animator_Chair = Chair.GetComponent<Animator>();
        animator_Room = Office_Space.GetComponent<Animator>();
        animator_Letter = Letter.GetComponent<Animator>();
        */

        animator_Bridge = Bridge.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            /*
            animator_Chair.SetBool("bool_cube_blue", true);
            animator_Room.SetBool("bool_room", true);
            animator_Letter.SetBool("bool_letter", true);
            */
            animator_Bridge.SetBool("bool_bridge", true);
            Debug.Log("You pressed e");
        }

        if (Input.GetKeyUp("e"))
        {
            /*
            animator_Chair.SetBool("bool_cube_blue", false);
            animator_Room.SetBool("bool_room", false);
            animator_Letter.SetBool("bool_letter", false);
            */
        }
    }
}

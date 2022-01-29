using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    public GameObject Bridge;
    Animator animator_Bridge;


    void Start()
    {
        animator_Bridge = Bridge.GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            animator_Bridge.SetBool("bool_bridge", true);
            Debug.Log("You pressed e");

        }

        if (Input.GetKeyUp("e"))
        {
            /*
            animator_Bridge.SetBool("bool_bridge", false);
            */
        }
    }
}

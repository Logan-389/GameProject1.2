using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseOver : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    public Camera FreeCam;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        //var ray = FreeCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        var ray = FreeCam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
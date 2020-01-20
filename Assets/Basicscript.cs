using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Basicscript : MonoBehaviour
{
    public GameObject camera;
    private GameObject currentObj;
    private Button[] buttons;
    private int children;

    // Start is called before the first frame update
    void Start()
    {

        buttons = GetComponentsInChildren<Button>();
        //initialize 
        //buttons = temporary;
        children = transform.GetChildCount();






    }

    // Update is called once per frame
    void Update()
    {


        //change to touch ?
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            for (int i = 0; i < children; i++)
            {
                buttons[i] = transform.GetChild(i).GetComponent<Button>();

                
                //asks if we pressed on the desired UI element (the shop)
                if (EventSystem.current.currentSelectedGameObject == buttons[i].gameObject)
                {
                    camera.GetComponent<ZoomIn>().stopClick = true;

                }


            }






        }
        else
        {
            camera.GetComponent<ZoomIn>().stopClick = false;
        }
    }


    public Button[] getButtons()
    {


        return buttons;
    }

  
}

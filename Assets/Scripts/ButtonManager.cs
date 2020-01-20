using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button[] temp;
    public Sprite layout;

   

    // Start is called before the first frame update
    void Start()
    {
        //load them into grass content
        foreach (Transform child in transform)
        {
            Button temporary = child.GetComponent<Button>();
            temporary.image.sprite = layout;

            //child is your child transform
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        



    }


   


}

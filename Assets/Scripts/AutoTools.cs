using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Point of this script is to act as the Auto tool to whatever the player is holding.. (i.e holding water, holding plant.. )

public class AutoTools : MonoBehaviour
{
    
    public Button[] temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tillAll()
    {
        GameObject farmLand = GameObject.Find("Plots");
        foreach (Transform child in farmLand.transform)
        {
            
            Button temporary = child.GetComponent<Button>();
            temporary.GetComponent<TileInteraction>().toolUse("harvest");
            //temporary.onClick.Invoke();


            //child is your child transform
        }
    }

}

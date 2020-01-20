using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempManager : MonoBehaviour
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


   public bool checkForMultiples(int current)
    {
        //wanna check if another one is also selected
        for (int i = 0; i < temp.Length; i++)
        {
            bool currentTool = temp[i].GetComponent<HotbarManager>().selected;


            //skip
            print(temp[i].GetComponent<HotbarManager>().selected); 
               
            

            if (currentTool == true)
            {
                
                temp[i].GetComponent<HotbarManager>().inactivateTool();
               
            }
            



            //child is your child transform
        }
        return false;
    }
    
}



using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    private bool isShopOpen = true;
    public GameObject shop;

    public GameObject ourInventory;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void openShop()
    {
        shop.SetActive(isShopOpen);
        isShopOpen = !isShopOpen;
    }

    public void purchase()
    {
        string veggie = GetComponent<Button>().name;

        Basicscript tempo = GameObject.Find("ImageComponent").GetComponent<Basicscript>();


        

        //grab list of stuff we have
        Button[] list = ourInventory.GetComponentsInChildren<Button>();
        

        Button[] veggies = tempo.getButtons();
        Manager manage = GameObject.Find("EventSystem").GetComponent<Manager>();
        
        foreach(Button vegetable in veggies)
        {
            //string of price
            string pricey = vegetable.GetComponentInChildren<Text>().text;
            
            //price of veggie
            int price = int.Parse(pricey);

           

            

          
            //if it exists
            if (manage.getMoney() >= price)
            {
                //print("veggie name " + veggie + " vegetable.name " + vegetable.name);
                //we have it?
                if (veggie.Equals(vegetable.name))
                {
                    
                    //goes to inventory to check if we a) have the item--> ADD+1 b) New item --> ADD+1
                     int num = checkInventory(list, vegetable.name.Substring(1, vegetable.name.Length - 1));


                    //print("veggie " + veggie + " vegetable " + vegetable.name);
                    list[num].GetComponent<InventoryManager>().addVegetable(vegetable.image.sprite,1);   
                    manage.updateCash(price * -1);
                    
                }
                //add it
                else
                {
                    
                }
                
                
            }
        }
       
        
    }





    private int checkInventory(Button[] list, string veggie)
    {
        //list is 
        for (int i = 0; i < list.Length; i++)
        {

            //grab image name
            Image currentSlot = list[i].GetComponent<Button>().image;
            //print(currentSlot.sprite.name);

            if (currentSlot.sprite.name.Equals(veggie))
            {
                return i;
            }
            
            if (currentSlot.sprite.name.Equals("Background"))
            {
                print("Background");
                return i;
            }

           
        }
        return -1;   
    }



}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileInteraction : MonoBehaviour
{
    public GameObject tempo;
    private Button currentButton;
    public Button plantButton;
    private Veggie currentVeggie;
    private float elapsed;
    

    public GameObject canvas;


    //veggies
    public GameObject pumpkin;
    public GameObject carrot;
    public GameObject eggplant;
    public GameObject strawberry;
    public GameObject potato;
    public GameObject corn;
    public GameObject beets;
    public GameObject avacado;
    public GameObject orange;
    public GameObject turmeric;

    public bool plantable = false;
    public bool waterable = false;

    private int currentQuantity;

    private Button button;



    // Start is called before the first frame update
    void Start()
    {
        currentButton = GetComponent<Button>();
        GameObject canvas = GameObject.Find("Panel");
       


    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void setTile()
    {

        string current = tempo.GetComponent<Manager>().whatAreWe;
        GameObject newButton;
        

        Text quantity;

        //Button temporary = tempo.GetComponent<Manager>().currentVeggie;

        //find button
        button = tempo.GetComponent<Manager>().currentVeggie;

        

        //are we harvesting or watering?!
        if (current.Equals("harvest") || current.Equals("water")) 
        {
            toolUse(current);

            return;
        }

        
        quantity = button.GetComponentInChildren<Text>();
        currentQuantity = int.Parse(quantity.text);
        //current = current.ToLower();



        //try to condense this into 1 single function
        switch (current)
        {


            case "Eggplant":
                //load the sprite
               

                if (plantable && currentQuantity > 0)
                {
                    //summon a button
                    newButton = Instantiate(eggplant) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;
                   
                }
                break;

            case "Carrot":
               
                if (plantable && currentQuantity > 0)
                {

                    newButton = Instantiate(carrot) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;

                    //updating text (quantity)
                    currentQuantity--;


                }
                print(currentQuantity);
                break;

            case "Strawberry":
                if (plantable && currentQuantity > 0)
                {
                    newButton = Instantiate(strawberry) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;

                }
                break;

            case "Pumpkin":

                if (plantable && currentQuantity > 0)
                {
                    newButton = Instantiate(pumpkin) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;
                }
                break;

            case "Potato":
                if (plantable && currentQuantity > 0)
                {
                    newButton = Instantiate(potato) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;

                }
                break;


            case "Corn":
                if (plantable && currentQuantity > 0)
                {
                    newButton = Instantiate(corn) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;

                }
                break;
            case "Beets":
                if (plantable && currentQuantity > 0)
                {
                    newButton = Instantiate(beets) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;

                }
                break;
            case "Avocado":
                if (plantable && currentQuantity > 0)
                {
                    newButton = Instantiate(avacado) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;

                }
                break;

            case "Orange":
                if (plantable && currentQuantity > 0)
                {
                    newButton = Instantiate(orange) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;

                }
                break;

            case "Turmeric":
                if (plantable && currentQuantity > 0)
                {
                    newButton = Instantiate(turmeric) as GameObject;
                    newButton.transform.SetParent(canvas.transform, false);
                    newButton.transform.position = currentButton.transform.position;
                    currentQuantity--;

                }
                break;





        }

        quantity.text = currentQuantity.ToString();


        //removes it from the inventory
        button.GetComponent<InventoryManager>().checkInv();
        print(current);



    }


    //this is probably temporary but who knows, I could just put it into the same method as above.
    public void toolUse(string current)
    {

        
        switch (current)
        {
            case "harvest":
                Sprite temporary = Resources.Load("unwatered", typeof(Sprite)) as Sprite;

                currentButton.image.sprite = temporary;
                plantable = false;
                waterable = true;
                break;

            case "water":
                if (waterable)
                {
                    temporary = Resources.Load("watered", typeof(Sprite)) as Sprite;



                    currentButton.image.sprite = temporary;
                    plantable = true;
                }
                break;



        }

    }
}

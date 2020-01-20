using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    
    public string currentAction;
    public string currentVeggie;
    public GameObject manage;
    public GameObject shop;

    public Sprite background;

    private Sprite currentImage;

    private Button currentButton;

    private Text quantity;


    //stuff for shop items
    private int amount;






    // Start is called before the first frame update
    void Start()
    {
        
        currentButton = this.GetComponent<Button>();
        quantity = GetComponentInChildren<Text>();
        amount = int.Parse(quantity.text);

        currentImage = currentButton.image.sprite;
        //print("This is the quantity " + quantity);
        
    }


   

   

    // Update is called once per frame
    void Update()
    {
      
    }

    //change what we could be able to plant
    public void changeSlot()
    {
        // GetComponent<Button>().onClick.AddListener(delegate { changeSlot("Pumpkin");});


        Button current = gameObject.GetComponent<Button>();
        GameObject hand = GameObject.Find("hand");
        print("current button " + current);
        manage.GetComponent<Manager>().setCurrentVeggie(current);

        currentImage = current.image.sprite;
        currentAction = currentImage.name;

        //sets the image
        hand.GetComponent<Image>().sprite = current.GetComponent<Image>().sprite;
        //updates what we are currently doing


        //updates the manager (though I may think of just tying everything into manager. TRY TO eliminate the other.
        hand.GetComponent<HotbarManager>().currentAction = currentAction;
        hand.GetComponent<HotbarManager>().currentlySelected();
        manage.GetComponent<Manager>().whatAreWe = currentAction;



    }

    public void checkInv()
    {
        quantity = GetComponentInChildren<Text>();
        
        amount = int.Parse(quantity.text);

        if (quantity.text != null)
        {

            if (amount == 0)
            {
                

               currentButton.image.sprite = background;
                currentButton.image.sprite.name = "Background";
                currentAction = null;
            }


        }

    }


    // adds vegetable to inventory
    public void addVegetable(Sprite img, int numb)
    {

        amount = int.Parse(quantity.text);
        int newInv = amount + numb;

        this.GetComponent<Image>().sprite = img;

        quantity.text = newInv.ToString();


    }
}

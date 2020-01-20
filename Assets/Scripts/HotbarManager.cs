using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotbarManager : MonoBehaviour
{
    public bool selected = false;
    public string currentAction;
    public string currentVeggie;
    public GameObject manage;
    public GameObject shop;

    private GameObject frame;

    private int shopOpen = -1;

    private bool enough = false;
    private Button currentButton;

    private Text quantity;


    //stuff for shop items
    private int amount;





    // Start is called before the first frame update
    void Start()
    {
        frame = GameObject.Find("Frame");
        //manage.GetComponent<Manager>().whatAreWe = "harvest";
        currentButton = GetComponent<Button>();
        quantity = GetComponentInChildren<Text>();

    }

    // Update is called once per frame
    void Update()
    {


    

    }


    public void currentlySelected()
    {
        selected = !selected;
        manage.GetComponent<Manager>().whatAreWe = currentAction;
        //set current veggie
      

        frame.transform.position = GetComponent<Button>().transform.position;

      
    }

    //select what we're doing
    void setAction(string action)
    {
        currentAction = action;
        
    }


    public void inactivateTool()
    {
        selected = false;
    }

    //open shop
    public void toggleShop()
    {
        //shop.SetActive(shopOpen);
        shop.transform.position += new Vector3(0, shopOpen*750, 0);
        
        
        shopOpen = shopOpen*-1;
    }

    








    
}

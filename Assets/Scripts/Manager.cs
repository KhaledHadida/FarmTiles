using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public string whatAreWe;
    public GameObject buyStuff;
    public GameObject currency;

    //what we currently are holding 
    public Button currentVeggie;

    public GameObject shop;
    private TextMeshProUGUI score;


    // Start is called before the first frame update
    void Start()
    {
         score = currency.GetComponent<TextMeshProUGUI>();
        //put our shop in middle of screen
        shop.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateMySlots(string name)
    {
        buyStuff.GetComponent<TempManager>().checkForMultiples(int.Parse(name));
    }

    public void updateCash(float val)
    {
        
        score.text = (float.Parse(score.text) + val).ToString();
    }

    public int getMoney()
    {
        return int.Parse(score.text);
    }

    public void setCurrentVeggie(Button veggie)
    {
        currentVeggie = veggie;
        print(currentVeggie);
    }
}

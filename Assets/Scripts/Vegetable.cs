using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vegetable : MonoBehaviour
{
    public Veggie currentVeggie;
    private float elapsed;
    private Sprite currentSprite;
    private Button currentButton;
    private bool harvestable;


    //particles
    private Object particleDestroy;

    private string currentAmount;
  


    // Start is called before the first frame update
    void Start()
    {
        
        //sets the image initially
        currentSprite = currentVeggie.currentSprite;
        currentButton = GetComponent<Button>();
        currentButton.image.sprite = currentSprite;
        currentAmount = currentButton.GetComponentInChildren<Text>().text;

        //particles
        particleDestroy = Resources.Load("BreakParticle");



    }

    // Update is called once per frame
    void Update()
    {
 

        elapsed += Time.deltaTime;

      
            setTimer((int)(currentVeggie.timerSpeed - elapsed));
        
     



        //loop for each picture, for each interval, plant grows.
        for (int i = currentVeggie.image.Length; i > 0; i--)
        {
            if (elapsed >= (currentVeggie.timerSpeed / i))
            {
                
                currentSprite = currentVeggie.image[i-1];
                currentButton.image.sprite = currentSprite;
            }
        }


        if (currentVeggie != null && elapsed >= currentVeggie.timerSpeed)
        {
            
            //elapsed = 0f;

            harvestable = true;
        }


        //hide timer
        if (getTimer() <= 0)
        {

            currentButton.GetComponentInChildren<Text>().enabled = false;
        }

    }


    public void harvestThisPlant()
    {

        
        
        
        if (harvestable)
        {

            GameObject thePlayer = GameObject.Find("EventSystem");
            Manager playerScript = thePlayer.GetComponent<Manager>();
            playerScript.updateCash(currentVeggie.value);
            

            Destroy(gameObject);
            GameObject explosion = (GameObject)Instantiate(particleDestroy);
            explosion.transform.position = new Vector3(transform.position.x,transform.position.y,-60);
        }
    }

    //sets timer
    public void setTimer(int amt)
    {
       
            currentButton.GetComponentInChildren<Text>().text = amt.ToString();
        
    }
    //get timer.
    public int getTimer()
    {
        string example = currentButton.GetComponentInChildren<Text>().text;

        return int.Parse(example);
    }

 



}

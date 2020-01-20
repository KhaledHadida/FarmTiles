using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticlesS : MonoBehaviour
{

    
    protected Transform mytransform;

    private Button currentButton;
    //private object 
    private Object particleDestroy;


    // Start is called before the first frame update
    void Start()
    {
        currentButton = GetComponentInChildren<Button>();
        //load the exploding particle
        particleDestroy = Resources.Load("BreakParticle");

        

        //  Instantiate(particle, new Vector3(0,0,-1000), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void execute(Vector3 pos)
    {
        //Instantiate(particle, new Vector3(pos.x-25,pos.y+25, -1065) ,Quaternion.identity);
        GameObject explosion = (GameObject)Instantiate(particleDestroy);
        

    }
}

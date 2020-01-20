using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandle : MonoBehaviour
{
   
    public Canvas canv;
    private float panSpeed = 100;
    private float zoomSize = 100;
    private Camera currentCam;

    private bool bDragging;
    private Vector3 oldPos, panOrigin;


    // Start is called before the first frame update
    void Start()
    {
        currentCam = GetComponent<Camera>();
        //just to offset it to the centre because it doesnt start like that
        Vector3 temp = new Vector3(canv.transform.position.x, canv.transform.position.y, 0);
        currentCam.transform.position += temp;
       
    }

    // Update is called once per frame
    void Update()
    {
     

       

        handleDragging();
        handleZoom();
        
    }

    public void handleDragging()
    {
        if (Input.GetMouseButtonDown(0))
        {
            oldPos = transform.position;
            panOrigin = Camera.main.ScreenToViewportPoint(Input.mousePosition);                    //Get the ScreenVector the mouse clicked
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition) - panOrigin;    //Get the difference between where the mouse clicked and where it moved
            transform.position = oldPos + -pos * panSpeed;                                         //Move the position of the camera to simulate a drag, speed * 10 for screen to worldspace conversion
        }

    }

    public void handleZoom()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<Camera>().orthographicSize -= zoomSize;

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<Camera>().orthographicSize += zoomSize;
            panSpeed += 50;

        }
    }
}

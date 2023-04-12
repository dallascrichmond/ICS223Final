using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    public Vector2 cameraChangeMax;
    public Vector2 cameraChangeMin;
    private CameraMovement cam;
    private bool TriggeredOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && TriggeredOnce == false)
        {
            cam.minPosition += cameraChangeMin;
            cam.maxPosition += cameraChangeMax;
            TriggeredOnce = true;
        }
        else if (other.CompareTag("Player") && TriggeredOnce == true)
        {
            cam.minPosition -= cameraChangeMin;
            cam.maxPosition -= cameraChangeMax;
            TriggeredOnce = false;
        }
    }

}

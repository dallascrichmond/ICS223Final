using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoomMove : MonoBehaviour
{
    public Vector2 cameraChangeMax;
    public Vector2 cameraChangeMin;
    public Vector3 playerChange;
    private CameraMovement cam;
    private bool TriggeredOnce = false;
    public bool needText;
    public string locationName1;
    public string locationName2;
    public GameObject text;
    public TextMeshProUGUI placeText;

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
        if (other.CompareTag("Player") && TriggeredOnce == false && !other.isTrigger)
        {
            cam.minPosition += cameraChangeMin;
            cam.maxPosition += cameraChangeMax;
            other.transform.position += playerChange;
            TriggeredOnce = true;
            if (needText)
            {
                StartCoroutine(placeNameCo(locationName2));
            }
        }
        else if (other.CompareTag("Player") && TriggeredOnce == true && !other.isTrigger)
        {
            cam.minPosition -= cameraChangeMin;
            cam.maxPosition -= cameraChangeMax;
            other.transform.position -= playerChange;
            TriggeredOnce = false;
            if (needText)
            {
                StartCoroutine(placeNameCo(locationName1));
            }
        }
    }

    private IEnumerator placeNameCo(string name)
    {
        text.SetActive(true);
        placeText.text = name;
        yield return new WaitForSeconds(4f);
        text.SetActive(false);

    }

}

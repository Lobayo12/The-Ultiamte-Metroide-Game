using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{

    public GameObject fullMapCam;
    public GameObject miniMapCam;
    public GameObject miniMapBorder;
    public GameObject miniMapTexte;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(!UIController.instance.fullscreenMap.activeInHierarchy)
            {
                UIController.instance.fullscreenMap.SetActive(true);
                Time.timeScale = 0f;
                fullMapCam.SetActive(true);
                miniMapCam.SetActive(false);
                miniMapBorder.SetActive(false);
                miniMapTexte.SetActive(false);




            }
            else
            {
                UIController.instance.fullscreenMap.SetActive(false);
                Time.timeScale = 1f;
                fullMapCam.SetActive(false);
                miniMapCam.SetActive(true);
                miniMapBorder.SetActive(true);
                miniMapTexte.SetActive(true);


            }
        }
    }
}

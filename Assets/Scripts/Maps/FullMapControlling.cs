using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullMapControlling : MonoBehaviour
{

    public MapCameraController mapCam;

    public float zoomSpeed;
    private float startSize;
    public float maxZoom, minZoom;

    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();

        startSize = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f).normalized * cam.orthographicSize * Time.unscaledDeltaTime;

        if(Input.GetKey(KeyCode.E))
        {
            cam.orthographicSize -= zoomSpeed * Time.unscaledDeltaTime;
        }

        if (Input.GetKey(KeyCode.R))
        {
            cam.orthographicSize += zoomSpeed * Time.unscaledDeltaTime;
        }

        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minZoom, maxZoom);
    }


    private void OnEnable()
    {
        transform.position = mapCam.transform.position;
    }
}

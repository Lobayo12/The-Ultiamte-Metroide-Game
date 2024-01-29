using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingDirection : MonoBehaviour
{
    [SerializeField]
    private Camera mainCam;
    private Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePosition = transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) + Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

    }
}

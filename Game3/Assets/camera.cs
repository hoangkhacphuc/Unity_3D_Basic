using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    Vector3 rot;
    float tile;

    void Update()
    {
        Camera cam = Camera.main;
        if (Input.GetMouseButtonDown(0))
        {
            rot = cam.transform.eulerAngles;
            rot.y = rot.y % 180;
        }
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            tile = Screen.width / (Screen.width - Input.mousePosition.x);
            rot.y += -mouseX * tile;
            if (rot.y <= 0)
                rot.y = 0;
            if (rot.y >= 90)
                rot.y = 90;
            cam.transform.rotation = Quaternion.Euler(0, rot.y, 0);
        }
    }

}

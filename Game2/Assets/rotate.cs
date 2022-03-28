using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float speed = 12.5f;
    public Vector3 posClick;
    public Vector3 old;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.tag == "Player")
                {
                    posClick = hit.point;
                    old = hit.transform.eulerAngles;
                }
            }
        }
        if (Input.GetMouseButton(0)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.tag == "Player")
                {
                    float angle = Vector3.SignedAngle(hit.point, posClick, Vector3.up);
                    // float angle2 = Vector3.Angle(oldPos, posClick);
                    
                    // float signedAngle = Vector3.SignedAngle(hit.point, posClick, Vector3.up);
                    // hit.transform.Rotate(0, 0, (angle - angle2)  * speed, Space.World);
                    // oldPos = hit.point;

                    hit.transform.eulerAngles = old + new Vector3(0, 0, angle * speed );
                    Debug.Log(hit.transform.eulerAngles + "     " + angle + "     " );
                }
            }
        }
    }

}

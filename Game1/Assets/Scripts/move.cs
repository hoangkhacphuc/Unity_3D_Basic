using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 posMove;

    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.tag == "Cube")
                {
                    posMove = hit.point - hit.transform.position;
                    hit.transform.position += new Vector3(posMove.x, 0, posMove.z);
                }
            }
        }
    }
}

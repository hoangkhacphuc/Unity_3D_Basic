using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody rigidbody;
    public float runningSpeed = 2f;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "Player")
            {
                float rl = hit.transform.position.x - transform.position.x;
                rl = rl == 0 ? 0 : rl > 1 ? 1 : -1;
                float ub = hit.transform.position.z - transform.position.z;
                ub = ub == 0 ? 0 : ub > 1 ? 1 : -1;
                rigidbody.velocity = new Vector3(rl, 0, ub) * Time.deltaTime * runningSpeed;
                //rigidbody.MovePosition(transform.position + new Vector3(rl, 0, ub) * Time.deltaTime * runningSpeed);
            }
        }    
    }
}

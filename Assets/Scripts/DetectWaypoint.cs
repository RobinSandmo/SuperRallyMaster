using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectWaypoint : MonoBehaviour
{
    public bool allowTeleport = false;
    private GameObject wayPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && allowTeleport == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.transform.rotation = wayPoint.transform.rotation;
            this.transform.position = wayPoint.transform.position;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
            if(collider.gameObject.tag == "waypoints")
        {
            wayPoint = collider.gameObject;
            //Debug.Log(wayPoint.name);
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "boundry")
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.transform.rotation = wayPoint.transform.rotation;
            this.transform.position = wayPoint.transform.position;
        }

    }

}


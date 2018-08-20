using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interador : MonoBehaviour {

    Ray dire;
    public float dist;
    GameObject ativ;

    void Start () {
        
	}
	
	void Update () {

        dire = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
        RaycastHit hit;
        

        if(Physics.Raycast(dire,out hit, dist))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * dist, Color.yellow);
            Debug.Log("Did Hit");

            if (hit.collider.gameObject.GetComponent<interagivel>())
            {
                hit.collider.gameObject.GetComponent<interagivel>().utiliz = true;
                ativ = hit.collider.gameObject;

            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * dist, Color.white);
            Debug.Log("Did not Hit");
            if(ativ != null)
            {
                ativ.GetComponent<interagivel>().utiliz = false;
            }
            

        }
        
	}

}

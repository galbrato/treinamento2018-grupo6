using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour {

    public static bool doorkey;
    public bool open;
    public bool close;
    public bool inTrigger;
    public GameObject player;
    public Animator animate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            inTrigger = true;
    
        }      
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            inTrigger = false;
        }
    }



    void Start()
    {
        animate = GetComponent<Animator>();
    }


    void Update()
    {
        if (inTrigger)
        {
            if (close)
            {
                if (doorkey)
                {
                    if (Input.GetButtonDown("Fire2"))
                    {

                        open = true;
                        close = false;
                        animate.SetBool("abrindo", close);
                        animate.SetBool("fechando", open);
                        
                    }
                }
            }
            else
            {
                if (Input.GetButtonDown("Fire2"))
                {
                    open = false;
                    close = true;

                    animate.SetBool("abrindo", close);
                    animate.SetBool("fechando", open);
                   
                    
                }
            }
        }
    }

    private void OnGUI()
    {
        if (inTrigger)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to close");
            }

            else
            {
                if (doorkey)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Press E to open");
                }
                else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "It´s closed, need key to open");
                }
            }
        }
    }
}

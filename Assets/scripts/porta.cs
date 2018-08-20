using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : interagivel {

    public bool doorkey;
    public bool open;
    public bool close;
    public GameObject player;
    public Animator animate;





    void Start()
    {
        animate = GetComponent<Animator>();
    }


    void Update()
    {
        if (utiliz)
        {
            fazer();
        }
    }

    public override void fazer()
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

    private void OnGUI()
    {
        if (utiliz)
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

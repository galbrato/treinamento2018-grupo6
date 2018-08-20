using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz : MonoBehaviour {

    public inter bot;
    public Light luzes;
    

	void Start () {

        luzes = this.GetComponent<Light>();
            
	}
	
	void Update () {
        if(bot.lig == true)
        {
            luzes.enabled = true;
        }
        else
        {
            luzes.enabled = false;
        }
        
    }
}

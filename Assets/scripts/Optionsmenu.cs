using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Optionsmenu : MonoBehaviour {

    public AudioMixer audiomixer;
    public Dropdown resolutionDropdown;
    int resolutionindex = 0;
 

    Resolution[] resolution;
     void Start()
    {
        resolution = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        for(int i = 0; i <resolution.Length; i++)
        {
            string option = resolution[i].width + " X " + resolution[i].height;
            options.Add(option);

            if(resolution[i].height == Screen.currentResolution.height && resolution[i].width == Screen.currentResolution.width)
            {
                resolutionindex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = resolutionindex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetResolution( int index)
    {
        Resolution newresolution = resolution[index];
        Screen.SetResolution(newresolution.width, newresolution.height, Screen.fullScreen);
    }

    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }
     public void SetFullScreen( bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

}

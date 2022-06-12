using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SetResolution : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;
    void Start()
    {
        /*
         * First we cleared our dropdown resolution
         * Create a list of string for our resolution options
         * A for loop that loop through each of our resolution array and for each option
         * Created a string formated in the following: "width" + "x" + "height" of the resolution
         * Lastly add the option to our options list
         * Then add them to our dropdown list
         * 
         * To set the resolution to the correct one right away we use an if statement to check resolution wide is equal
         * To screen current width resolution same for height
         */
        resolutions = Screen.resolutions;
       // resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + " @ " + resolutions[i].refreshRate + "hz";
            options.Add(option);

            if (resolutions[i].width == Screen.width &&
                resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }// end of for loop
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }// end of start

    /*
     * This method basically update the resolution as desired.
     */
    public void SetResolutions ( int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    
}// end of class

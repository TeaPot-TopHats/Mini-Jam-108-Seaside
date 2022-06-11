using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFullScreenToggle : MonoBehaviour
{
    /*
     * A void to toggle full screen in game
     */
    public void setFullScreen(bool Fullscreen)
    {
        Screen.fullScreen = Fullscreen; 
    }
}

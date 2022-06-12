using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused)
        {
            Resume();
            LockMouseCursor();
        }
        else
        {
            Pause();
            UnlockMouseCursor();
        }
    }
    /*
   * Resume method basiclly restart the game and let the time flow normally
   */
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }// end of reusme method

    /*
     * Pause method basiclly pasues the game and set the time flow to zero.
     */
    public void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }// end of pause method

    void UnlockMouseCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void LockMouseCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
}

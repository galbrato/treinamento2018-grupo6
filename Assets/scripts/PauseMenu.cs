using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject Menu;
    public GameObject player;

	public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Menu.gameObject.SetActive(false);
        player.gameObject.GetComponent<Pause>().abfec = !player.gameObject.GetComponent<Pause>().abfec;

    }
}

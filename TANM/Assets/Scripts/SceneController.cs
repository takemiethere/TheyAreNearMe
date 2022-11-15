using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject GameOverUI;
    private float time = 0.0f;
    
    public static bool OpenGameoverUI = false;
    public static bool OpenwinnerUI = false;
    
    // Start is called before the first frame update
    void Start()
    {
        OpenGameoverUI = false;
        OpenwinnerUI = false;
        PauseMenu.SetActive(false);
    }

    public void ResumeGame()
    {
        PauseMenu.SetActive(false); //ปิดหน้าต่างหยุด
        Time.timeScale = 1; //เวลาในเกมเดินต่อ
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1 && OpenGameoverUI!=true)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0 && OpenGameoverUI!=true)
        {
            ResumeGame();
        }
    }

    public void LoadScene(int num)
    {
        SceneManager.LoadSceneAsync(num);
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GotoPlayGame()
    {
        SceneManager.LoadScene("PlayGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

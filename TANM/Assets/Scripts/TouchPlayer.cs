using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlayer : MonoBehaviour
{
    public GameObject gameOverUI;
    public bool touchP = false;

    // Start is called before the first frame update
    void Start()
    {
        touchP = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (touchP == true)
        {
            GameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Enter");
        if (other.gameObject.tag == "Player")
        {
            touchP = true;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        SceneController.OpenGameoverUI = true;
        gameOverUI.SetActive(true);
        Cursor.visible = true;
    }
}

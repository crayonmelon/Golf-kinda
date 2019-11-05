using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public Material[] materials;
    public GameObject PauseMenuUI;
    public GameObject Player;
    public TMP_Dropdown m_Dropdown;
    public string loadMenu = "LevelSelect";

    Renderer rend;

    private void Start()
    {
        rend = Player.GetComponent<Renderer>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
            
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        print("menu");
        SceneManager.LoadScene(loadMenu);
    }

    public void EndGame()
    {
        print("end");
        Application.Quit();

    }

    public void ChangePlayerMaterial()
    {
        if(m_Dropdown.value == 0)
        {
            print("value 1");
            rend.material = materials[0];
        }
        else if (m_Dropdown.value == 1)
        {
            print("value 2");
            rend.material = materials[1];
        }
        else if (m_Dropdown.value == 2)
        {
            print("value 3");
            rend.material = materials[2];
        }
    }
}

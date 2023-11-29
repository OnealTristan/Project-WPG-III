using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseBtnLvl : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public Button pauseBtn;
    public Button resumeBtn;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        Button pauseB = pauseBtn.GetComponent<Button>();
        Button resumeB = resumeBtn.GetComponent<Button>();

        pauseB.onClick.AddListener(pause);
        resumeB.onClick.AddListener(resume);
    }

    void pause ()
	{
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
	}

    void resume ()
	{
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using OnefallGames;

public class pausemenu : MonoBehaviour

{
    [SerializeField] public GameObject pauseMenuPanel = null;
    public CanvasGroup cg;
    public GameObject PauseButton;
    //public GameObject PauseMenuCanvas;



    public void PlayClickButtonSound()
    {
        ServicesManager.Instance.SoundManager.PlaySound(ServicesManager.Instance.SoundManager.button);
    }

   public void Hidepausebutton() //hides pause button and shows pause menu
   {
        //cg.alpha = 1f;
        PauseButton.SetActive(false);

   }

    public void ShowPauseButton() //shows pause button and hides pause menu
    {
        //cg.alpha = 0f;
    }

    

    private void Update()
    {
        //PauseMenuCanvas = GameObject.Find("PauseMenuCanvas").GetComponent<GameObject>();
        //cg = GameObject.Find("PauseMenuCanvas").GetComponent<CanvasGroup>();
       //PauseButton = GameObject.Find("pausebutton").GetComponent<GameObject>();
        //pauseMenuPanel = GameObject.Find("pausedMenuPanel").GetComponent<GameObject>();
    }
    public void pause()
    {
        Hidepausebutton();
        PlayClickButtonSound();
        //pauseMenuPanel.SetActive(true);
        //PauseButton.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        ShowPauseButton();
        PlayClickButtonSound();
        //pauseMenuPanel.SetActive(false);
        //PauseButton.SetActive(true);
        Time.timeScale = 1f;
    }

    public void restart()
    {
        PlayClickButtonSound();
        Time.timeScale = 1f;
        SceneManager.LoadScene("Ingame");
    }

    //public void Loadscene()
    //{
    //    //PlayClickButtonSound();
    //    SceneManager.LoadScene("Loading");
    //    //yield return new WaitForSeconds(0.1f);
    //    //SceneManager.LoadScene("Home");
    //}

    //public void Homebtn()
    //{
    //    PlayClickButtonSound();
    //    Time.timeScale = 1f;
    //    SceneManager.LoadScene("Home");
    //}

    public void HomeBtn()
    {
        ViewManager.Instance.PlayClickButtonSound();
        Time.timeScale = 1f;
        ViewManager.Instance.LoadScene("Home", 0.25f);
    }
    //public void home()
    //{
    //    ViewManager.Instance.PlayClickButtonSound();
    //    SceneManager.LoadScene("Home");
    //}


}

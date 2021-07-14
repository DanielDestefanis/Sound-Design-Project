using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseControl : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject PausePanel;
    public GameObject AreYouSurePanel;
    public GameObject TutorialPanel;
    public GameObject YouWinPanel;
    public Canvas Canvas; 

    public bool pause;

    public bool ignoreListenerPause;

    public AudioSource ResumeUI;
    public AudioSource RestartUI;
    public AudioSource QuitUI;

    public AudioSource AreYouSureYes;
    public AudioSource AreYouSureNo;
    public AudioSource YouWin;



             

    public void Start()
    {
        PausePanel.SetActive(false);
        AreYouSurePanel.SetActive(false);
        Resume();      
        

    }
       
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
            
           
        }       
    }

   public void PauseGame()
    {
        if(gameIsPaused)
        {
            Time.timeScale = 0;
                                   
            transform.parent.GetComponent<FirstPersonMovement>().enabled = false;
            GetComponent<MouseCamLook>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            PausePanel.SetActive(true);
            AreYouSurePanel.SetActive(false);
            TutorialPanel.SetActive(true);

            AudioListener.pause = true;

            ResumeUI.ignoreListenerPause = true;
            RestartUI.ignoreListenerPause = true;
            QuitUI.ignoreListenerPause = true;
            AreYouSureYes.ignoreListenerPause = true;
            AreYouSureNo.ignoreListenerPause = true;
            YouWin.ignoreListenerPause = true;
            
        }
            
        else
        {
            Resume();         
        }
      
    }
    public void Resume()
    {
        Time.timeScale = 1;
        transform.parent.GetComponent<FirstPersonMovement>().enabled = true;
        GetComponent<MouseCamLook>().enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        PausePanel.SetActive(false);
        AreYouSurePanel.SetActive(false);

        AudioListener.pause = false;       
    }

    public void QuitButton()
    {
        AreYouSurePanel.SetActive(true);
        PausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {

        SceneManager.LoadScene("MYLEVEL");

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            YouWinPanel.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;            

            transform.parent.GetComponent<FirstPersonMovement>().enabled = false;
            GetComponent<MouseCamLook>().enabled = false;



        }
    }


    }

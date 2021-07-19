using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI : MonoBehaviour
{
    //The contents of the Canvas
    public Canvas Canvas;
    public GameObject YouWinPanel;
    public GameObject TutorialPanel;
    public Text GoalText;
    public Text TimerText;
    
    //Timer for tutorial panel
    private float tutorialPanelTimer = 10f;

    //Timer for level timer
    private float Timer;
   
    //Variable for if the player is playing
    private bool playing = true;

    //Counts number of pressure plates player has activated in the courtyard area
    private int pressurePlateCount = 0;


    public AudioSource goalTextSound;
    public AudioSource endMusic;
    

    public void Start()
    {
        //Hiding the YouWin Panel on level start
        YouWinPanel.gameObject.SetActive(false);

        //Showing the tutorial panel on level start
        TutorialPanel.gameObject.SetActive(true);

        goalTextSound = GetComponent<AudioSource>();

    }

    public void Update()
    {
        //if playing is playing, timer is displayed on screen, and counts up in minutes, seconds and milliseconds
        if (playing == true)
        {
            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60f);
            int seconds = Mathf.FloorToInt(Timer % 60f);
            int milliseconds = Mathf.FloorToInt((Timer * 100f) % 100f);
            TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        }

        //when the tutorial panel timer is at 0, hide the panel
        tutorialPanelTimer -= Time.deltaTime;
        if (tutorialPanelTimer <= 0)
        {
            TutorialPanel.gameObject.SetActive(false);
            tutorialPanelTimer = 0.1f;
        }


    }

    public void OnTriggerEnter(Collider other)
    {
        //updates the goal text based on what goal is completed
        if (other.CompareTag("PressurePlate"))
        {
            GoalText.text = "Reach the Courtyard";
            goalTextSound.Play(); 
            gameObject.GetComponent<BoxCollider>().enabled = false;          
        }

        if (other.CompareTag("CourtyardEntry"))
        {
            GoalText.text = "Find the pressure\n\n" + "plates \n\n" + "Pressure Plates: " + pressurePlateCount + "/3"; 
            goalTextSound.Play();
            Destroy(other);
        }


        if(other.CompareTag("PressurePlateOpenArea"))
        {
            pressurePlateCount++;            
            GoalText.text = "Find the pressure\n\n" + "plates \n\n" + "Pressure Plates: " + pressurePlateCount + "/3";            
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }

        if(pressurePlateCount == 3)
        {
            if(other.CompareTag("PressurePlateOpenArea"))
            {
                GoalText.text = "Enter the tower";
                goalTextSound.Play();
            }
            
            
            
        }

        if(other.CompareTag("TowerEntry"))
        {
            GoalText.text = "Ascend";
            goalTextSound.Play();
            Destroy(other);
        }

        if(other.CompareTag("TowerTop"))
        {
            GoalText.text = "open the chest";
            //goalTextSound.Play();
            endMusic.Play();
            Destroy(other);
        }
        if (other.CompareTag("Finish"))
        {
            GoalText.text = "";
            
        }


    }


}

 
    



   
   

   
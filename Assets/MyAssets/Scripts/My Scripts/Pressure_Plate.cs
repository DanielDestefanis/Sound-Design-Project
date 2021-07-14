using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pressure_Plate : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator myAnimationController2;
    public Text GoalText;

    public AudioSource goalTextSound;
    public AudioSource pressurePlateSound;
    public AudioSource doorOpenSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            myAnimationController.SetBool("open", true);
            myAnimationController2.SetBool("down", true);

            GoalText.text = "Reach the Courtyard";
            goalTextSound.Play();
            gameObject.GetComponent<BoxCollider>().enabled = false;

            pressurePlateSound.Play();
            doorOpenSound.Play();
             
        }

        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("open", true);
            myAnimationController2.SetBool("down", true);
            pressurePlateSound.Play();
            doorOpenSound.Play();                       
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }

     
    }
}

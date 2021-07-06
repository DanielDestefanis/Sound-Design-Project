using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pressure_Plate : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator myAnimationController2;
    public Text GoalText;



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            myAnimationController.SetBool("open", true);
            myAnimationController2.SetBool("down", true);
            GoalText.text = "Find the holy treasure \n\n Reach the Courtyard";
        }

        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("open", true);
            myAnimationController2.SetBool("down", true);
        }

     
    }
}

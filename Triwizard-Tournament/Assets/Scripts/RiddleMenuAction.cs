using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleMenuAction : MonoBehaviour
{
    public GameObject thisMenu;

    //Correct choice, player continues and no points deducted.
    public void Correct()
    {
        thisMenu.SetActive(false);
    }

    //Wrong choice, deduct point by 1, if player has had 3 deductions, then game over.
    // ** NOT IMPLEMENTED YET **
    public void Wrong()
    {
        thisMenu.SetActive(false);
    }
}

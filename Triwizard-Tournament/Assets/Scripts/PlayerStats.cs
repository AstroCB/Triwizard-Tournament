using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private static int score = 0;
    private bool lost = false;

    public void UpdateScore(){
        score+=1;
    }

    public void Lost(){
        lost = true;
    }

    public bool HasLost(){
        return lost;
    }

    public void Reset(){
        score = 0;
        lost = false;
    }

    public int GetScore(){
        return score;
    }
}

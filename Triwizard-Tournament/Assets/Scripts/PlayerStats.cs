using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private static bool lost = false;
    
    public bool HasLost(){
        return lost;
    }

    public void Lost(){
        lost = true;
    }

    public void Reset(){
        lost = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseText : MonoBehaviour
{
    public Text txt;
    public PlayerStats stats;

    // Update is called once per frame
    void Update()
    {
        if (stats.HasLost()){
            txt.text = "You Lost!";
        } else {
            txt.text = "You Won!";
        }
    }
}

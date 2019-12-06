using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public GameObject endMenu;
    private float countdownTimer = 600f; //10 minutes, 600 seconds
    private Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countdownTimer -= Time.deltaTime;
        timerText.text = countdownTimer.ToString("f2");
        if (countdownTimer <= 0) {
            
        }
    }
}

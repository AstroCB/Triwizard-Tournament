using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public GameObject endMenu;
    public GameObject camera;
    private float countdownTimer = 600f; //10 minutes, 600 seconds
    private Text timerText;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        endMenu.SetActive(false);
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver) {
            countdownTimer -= Time.deltaTime;

            //Format time to look like minutes : seconds
            string minutes = ((int)countdownTimer / 60).ToString();
            string seconds = (countdownTimer % 60).ToString("f0");
            if (seconds == "60") {
                seconds = "0";
                minutes = (((int)countdownTimer / 60) + 1).ToString();
            }

            if (seconds.Length == 1) {
                timerText.text = minutes + ":0" + seconds;
            } else {
                timerText.text = minutes + ":" + seconds;
            }

            if (countdownTimer <= 0) {
                timerText.text = "Time!";
                
                endMenu.transform.position = camera.transform.position + camera.transform.forward * 0.75f;
                endMenu.transform.rotation = camera.transform.rotation;
                endMenu.SetActive(true);
                gameOver = true;
            }
        }
    }
}

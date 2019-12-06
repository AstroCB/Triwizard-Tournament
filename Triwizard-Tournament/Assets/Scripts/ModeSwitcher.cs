using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwitcher : MonoBehaviour
{
    private GvrControllerInputDevice controller;
    private bool menuActive = false;
    private float timer = 0.0f;
    private static readonly float APP_LONG_PRESS_DURATION = .65f;
    private bool actionComplete = false;

    public GameObject menu;
    public GameObject camera;
    public GameObject countdownBox;


    // Start is called before the first frame update
    void Start()
    {
        controller = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
        menu.SetActive(false);
        countdownBox.SetActive(true);
        timer = 0.0f;
        actionComplete = false;
        menuActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.GetButtonDown(GvrControllerButton.App)){
            timer = 0;
        }

        else if (controller.GetButton(GvrControllerButton.App)){
            timer += Time.deltaTime;
            if (timer >= APP_LONG_PRESS_DURATION && !actionComplete)
            {
                // Do "long press" actions here
                menuActive = !menuActive;
                menu.transform.position = camera.transform.position + camera.transform.forward * 0.75f;
                menu.transform.rotation = camera.transform.rotation;
                menu.SetActive(menuActive);
                actionComplete = true;
            }
        }

        else if (controller.GetButtonUp(GvrControllerButton.App)) {
            actionComplete = false;
        }
        
    }
}

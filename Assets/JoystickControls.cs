using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Space");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            print("Button 0 = Square");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            print("Button 1 = X");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            print("Button 2 = Circle");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            print("Button 3 = Triangle");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            print("Button 4 = L1 Bumper");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            print("Button 5 = R1 Bumper");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton6))
        {
            print("Button 6 = L2 Trigger");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            print("Button 7 = R2 Trigger");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton8))
        {
            print("Button 8 = SHARE");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            print("Button 9 = OPTION");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton10))
        {
            print("Button 10 = L3");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton11))
        {
            print("Button 11 = R3");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton12))
        {
            print("Button 12 = PS BUTTON");
        }

        if(Input.GetKeyDown(KeyCode.JoystickButton13)) // NOTHING WORKS
        {
            print("Button 13");
        }






        
    } // END UPDATE


































}

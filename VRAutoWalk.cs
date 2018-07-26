/*

Name of Module : Navigation.cs
Date Created : 25.03.2018
Author's Name : Abhinav Hinger
Synopsis of Module : This Module allows user to move automatically in the Virtual World using
head movements.It takes input from Device(Accelerometer) and Outputs whether Character should move

Input Parameters : vrCamera , toggleAngle , speed
Output Parameters :bool moveForward

 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRAutoWalk : MonoBehaviour {

    /*
    This transform(reference data type) attached to the Main Camera is the one 
    that gets Moved on Interaction
    */
    public Transform vrCamera;

    //Switching Angle below which User Starts Moving Forward
    public float toggleAngle = 30.0f;

    //Constant Speed with which User moves Once it looks below Toggle Angle
    public float speed = 3.0f;

    //Decides whether Character Moves or Not 
    public bool moveForward;

    //This is the Character that moves in the Virtual World following Laws of Physics and Collision
    private CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*If vrCamera's angle with x-axis is more than toggleAngle then user starts moving Forward */
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }

        /*When bool moveForward is TRUE then CharacterController will move forward with Predefined Constant 
        Speed
        */
        if (moveForward)
        {
            /*
            This method identifies where is vrCamera pointing at with respect to global origin (0,0,0) which
            is later needed to identify in which direction do we need to Move the CharacterController
            */
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            //This method of CharacterController moves it forward with a certain Speed
            cc.SimpleMove(forward * speed);
        }
    }
}

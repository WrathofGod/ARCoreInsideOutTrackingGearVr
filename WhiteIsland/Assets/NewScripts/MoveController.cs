﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour { // By using the touchpad you can fly through the Scene.

    public Vector2 touchPadDirection;
    public float distance = 2;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        touchPadDirection = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);

        if (touchPadDirection.y > 0.4f) // this code moves the player forward when the upper part of the touchpad is pressed
        {
            transform.position = transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
        }

        /* This code could be used to stear in all four directions
        if ((touchPadDirection.x >= 0.5f || touchPadDirection.y >= 0.5 || touchPadDirection.x <= -0.5f || touchPadDirection.y <= -0.5) && OVRInput.Get(OVRInput.Button.One)) // If touchpad is gently touched
        {
            touchPadDirection = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);
            
        }
        */
    }     
}

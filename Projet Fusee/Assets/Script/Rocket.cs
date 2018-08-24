using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public Rigidbody RocketRigidBody;
    [SerializeField] public float ForceUpward = 200;
    [SerializeField] public float ForceSideWay = 200;
    // Use this for initialization
    void Start () {
        RocketRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        FlightInputManeger();
        HorizontalInputManager();
	}

    private void HorizontalInputManager()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            RocketRigidBody.AddForceAtPosition(new Vector3(ForceSideWay, 0, 0),new Vector3(),new ForceMode());
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            RocketRigidBody.AddForceAtPosition(new Vector3(-ForceSideWay, 0, 0), new Vector3(),new ForceMode());
        }
    }

    private void FlightInputManeger()
    {
        if (Input.GetAxis("Jump")>0)
        {
            RocketRigidBody.AddRelativeForce(0, ForceUpward, 0);
        }
    }
}

﻿using UnityEngine;

public class Sensor : MonoBehaviour
{
	private Robot robot;

	void Awake ()
	{
		robot = GetComponentInParent<Robot> ();
	}

	void OnTriggerStay (Collider other)
	{
		robot.updateSensorState (this.name, true);
	}

	void OnTriggerExit (Collider other)
	{
		robot.updateSensorState (this.name, false);
	}
}

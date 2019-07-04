using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	public GameObject newObject;
	public GameObject theTrigger;
	public GameObject oldObject;

	void onTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			newObject.SetActive (true);
			theTrigger.SetActive (false);
			oldObject.SetActive (true);
		}
	}
}

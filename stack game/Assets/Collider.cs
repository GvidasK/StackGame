using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
	public GameObject Cube ;
	void OnCollision	(Collision col)
	{
		if (col.gameObject.name == "trigger")
		{
			Destroy(col.gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;

public class CubeInvisibility : MonoBehaviour {
	void Start(){
		Transform Cube = transform.Find("Cube (2)");
		Cube.gameObject.SetActive(false);
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player"){
			Transform step = transform.Find("Cube (2)");
			step.gameObject.SetActive(true);

		}
	}
}
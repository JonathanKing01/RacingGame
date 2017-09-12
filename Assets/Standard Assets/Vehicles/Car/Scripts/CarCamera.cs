using UnityEngine;
using System.Collections;

public class CarCamera : MonoBehaviour {

	public int scrollAmount = 1;

	void Update () {
		scrollWheelZoom ();
	}

	void scrollWheelZoom(){
		// Set max/min scroll stages for camera
		int max = 10;
		int min = 0;

		//Transform the camera by the step size for +ve and -ve scroll input
		if (Input.GetAxis ("Mouse ScrollWheel") > 0) {
			if(scrollAmount > min){
				GetComponent<Transform> ().localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y - 1f, transform.localPosition.z + 1f);
				transform.Rotate (-1, 0, 0);
				scrollAmount--;
			}
		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0) {
			if (scrollAmount < max) {
				GetComponent<Transform> ().localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y + 1f, transform.localPosition.z - 1f);
				transform.Rotate (1, 0, 0);
				scrollAmount++;
			}
		}
	}
}

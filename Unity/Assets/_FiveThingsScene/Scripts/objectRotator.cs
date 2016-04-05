using UnityEngine;
using System.Collections;

public class objectRotator : MonoBehaviour {

	// Allow editing of the rotation values from the Unity Editor
	public float rotateX = 15f;
	public float rotateY = 30f;
	public float rotateZ = 45f;

	// Update is called once per frame
	void Update () {
		// rotate the object that the script is attached to
		gameObject.transform.Rotate (new Vector3 (rotateX, rotateY, rotateZ) * Time.deltaTime, Space.Self);
	}
}

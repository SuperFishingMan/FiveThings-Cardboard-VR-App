using UnityEngine;
using System.Collections;

public class objectRotator : MonoBehaviour {

	// Allow editing of the rotation values from the Unity Editor
	public float rotateX = 15f;
	public float rotateY = 30f;
	public float rotateZ = 45f;

	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * Update runs once per frame.
	 * Rotate the object by a specified number of degrees around its local axis every frame
	 */
	void Update () {
		gameObject.transform.Rotate (new Vector3 (rotateX, rotateY, rotateZ) * Time.deltaTime, Space.Self);
	}
}

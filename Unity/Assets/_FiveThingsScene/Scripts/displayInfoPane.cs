using UnityEngine;
using System.Collections;

public class displayInfoPane : MonoBehaviour {
	
	private GameObject head;
	private GameObject infoPane;
	private Vector3 originalPosition;
	private Quaternion originalRotation;

	// Use this for initialization
	void Start () {

		infoPane = gameObject
				.transform
				.Find ("InfoPane")
				.gameObject;

		originalPosition = infoPane.transform.position;
		originalRotation = infoPane.transform.rotation;
	}

	void LateUpdate() {
		infoPane.transform.rotation = originalRotation;
		infoPane.transform.position = originalPosition;
	}
	public void displayInfo() {
		infoPane.SetActive (true);
		ParticleSystem particles = gameObject.GetComponentInChildren<ParticleSystem>();
		particles.Stop();

	}
}

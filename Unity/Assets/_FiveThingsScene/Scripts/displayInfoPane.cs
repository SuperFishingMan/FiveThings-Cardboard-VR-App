using UnityEngine;
using System.Collections;
/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * This class displays the infoPane when a 3d game object is selected.
	 */
public class displayInfoPane : MonoBehaviour {
	
	private GameObject head;
	private GameObject infoPane;
	private Vector3 originalPosition;
	private Quaternion originalRotation;

	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * Initialize our vars
	 */
	void Start () {
		infoPane = gameObject
				.transform
				.Find ("InfoPane")
				.gameObject;
		// Cache the starting position of the infoPane (As placed in the editor)
		originalPosition = infoPane.transform.position;
		originalRotation = infoPane.transform.rotation;
	}

	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * LateUpdate will perform its tasks after all other frame tasks have completed.
	 * Because the 3d game object is rotating every frame, we tell the child infoPanel to maintain its
	 * original rotation
	 */
	void LateUpdate() {
		infoPane.transform.rotation = originalRotation;
		infoPane.transform.position = originalPosition;
	}

	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * Display the info panel and stop the particle emission to help the user realize they have already selected this game object.
	 */
	public void displayInfo() {
		infoPane.SetActive (true);
		ParticleSystem particles = gameObject.GetComponentInChildren<ParticleSystem>();
		particles.Stop();

	}
}

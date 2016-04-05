using UnityEngine;
using System.Collections;

public class dismissWin : MonoBehaviour {

	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * Closes the "Great Job!" screen, and removes the window entirely from the scene. 
	 */
	public void dismissWinScreen() {
		if( gameObject != null ) {
			gameObject.SetActive (false);
			Destroy (gameObject);
		}
			
	}

}

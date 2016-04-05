using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DismissInfo : MonoBehaviour {
	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * Deactivate the infoPane in the scene. This is different from Destroy(), because it can be reactivated later.
	 */
	public void dismissInfo() {
		gameObject.SetActive (false);
	}	
}
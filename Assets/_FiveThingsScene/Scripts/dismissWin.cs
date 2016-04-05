using UnityEngine;
using System.Collections;

public class dismissWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void dismissWinScreen() {
		if( gameObject != null ) {
			gameObject.SetActive (false);
			Destroy (gameObject);
		}
			
	}

}

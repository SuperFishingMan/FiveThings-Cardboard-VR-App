using UnityEngine;
using System.Collections;

public class MovingCharacterController : MonoBehaviour {
  // For a full explanation of the API, look at ExampleCharacterController.cs from the Demo Scenes in Cardboard Controls.
 

	// Scorekeeping
	public static int objectsFound = 0;

  public float speed = 17f;
  public float reticleMaxLength = 2f;

  private static CardboardControl cardboard;
  private bool moving = false;
	private GameObject winScreen;
	

//  private float reticleTimer = 0f;

  void Start() {
    cardboard = GameObject.Find("CardboardControlManager").GetComponent<CardboardControl>();
		// Add functions to CardboardControl event delegates
    cardboard.trigger.OnDown += ToggleMove;
    cardboard.trigger.OnUp += ToggleMove;
    cardboard.trigger.OnClick += Interact;
	
	//define our Win Screen
	winScreen = gameObject.transform.Find ("WinScreen").gameObject;

  }

  void Interact(object sender) {
    cardboard.reticle.Show();
  }

  void ToggleMove(object sender) {
    moving = !moving;
  }

	void displayWinScreen() {
		winScreen.SetActive (true);
	}
  void Update() {
    // If you don't need as much control over what happens when moving is toggled,
    // you can replace this with cardboard.trigger.IsHeld() and remove ToggleMove()
    if (moving) {
      Vector3 movement = Camera.main.transform.forward;
      transform.position += movement * speed * Time.deltaTime;
    }
		if( objectsFound >= 5 && winScreen != null) {
			displayWinScreen ();
		}
  }
}

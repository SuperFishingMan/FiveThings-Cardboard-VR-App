using UnityEngine;
using System.Collections;

/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * For a full explanation of the Cardboard Controls API, look at ExampleCharacterController.cs from the Demo Scenes in Cardboard Controls.
	 * 
	 * This class controls the movement of the character using the Cardboard SDK via Cardboard Controls.
	 */
public class MovingCharacterController : MonoBehaviour
{
	// Scorekeeping count
	public static int objectsFound = 0;

	// Initial movement speed (units per frame)
	public float speed = 17f;
	// Initial distance for a collision that will activate the reticle on the display
	public float reticleMaxLength = 2f;

	// Instantiate the cardboard-controls class
	private static CardboardControl cardboard;
	// Are we moving?
	private bool moving = false;
	// Refers to the "Great Job!" screen when all objects have been found.
	private GameObject winScreen;

	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * When the app starts, initialize the variables, add functionality to the CardboardControl delegates.
	 */
	void Start ()
	{
		cardboard = GameObject.Find ("CardboardControlManager").GetComponent<CardboardControl> ();
		// Add functions to CardboardControl event delegates
		cardboard.trigger.OnDown += ToggleMove;
		cardboard.trigger.OnUp += ToggleMove;
		cardboard.trigger.OnClick += Interact;
	
		//here's our Great Job dialog
		winScreen = gameObject.transform.Find ("WinScreen").gameObject;

	}

	/**
	 * @param {object} sender --> to my knowledge, this is just a convention for delegates in C#,
	 * we are not doing anything with the sender.
	 * 
	 * If the reticle is hidden, clicking will show the reticle.
	 */
	void Interact (object sender)
	{
		cardboard.reticle.Show ();
	}

	/**
	 * @param {object} sender --> to my knowledge, this is just a convention for delegates in C#,
	 * we are not doing anything with the sender.
	 * 
	 * Turn moving on and off.
	 */
	void ToggleMove (object sender)
	{
		moving = !moving;
	}

	/**
	 * Displays the win screen.
	 */
	void displayWinScreen ()
	{
		winScreen.SetActive (true);
	}

	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * Every frame, we check to see if we are supposed to be moving, and use the object transform to propel forward using the speed setting we set above.
	 * Every frame, check to see if we should be displaying the win screen.
	 */
	void Update ()
	{
		// If you don't need as much control over what happens when moving is toggled,
		// you can replace this with cardboard.trigger.IsHeld() and remove ToggleMove()
		if (moving) {
			Vector3 movement = Camera.main.transform.forward;
			transform.position += movement * speed * Time.deltaTime;
		}
		// When we identify and read all of the information on the objects, display the win screen.
		// Since the winScreen will be destroyed after we see it initially, we check for a null value incase an object count slips through.
		if (objectsFound >= 5 && winScreen != null) {
			displayWinScreen ();
		}
	}
}

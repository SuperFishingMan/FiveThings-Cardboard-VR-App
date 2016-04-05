using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * This class displays in game notifications after a player selects a game object, 
	 * and keeps them up to date on how many more they need to find.
	 */
public class notifications : MonoBehaviour {

	// Public vars are set in Editor.
	public GameObject parent;
	// the notification is a single object, we change its text dynamically during runtime.
	public GameObject notification;
	public Text notificationText;

	/**
	 * See Unity docs for API documentation 
	 * - select an API call and press CMD + ' (or ctrl + ' on windows)
	 * 
	 * I'm using a tag system to tell me if an object has been found already or not.
	 * This function checks the tag and displays a message if conditions are met.
	 * After two seconds, the notification is dismissed, and the object that was selected is tagged as 'found'.
	 */
	public void displayNotification(){
		if( parent.tag == "Display Objects" && parent.tag != "foundObject") {
			
			// increment the count
			MovingCharacterController.objectsFound++;
			// display the notification
			notification.SetActive (true);
			// display the right notification text
			switch (MovingCharacterController.objectsFound) {
			case 1:
				notificationText.text = "Nice job, just 4 left!";
				Invoke ("dismissNotification", 2);
				break;
			case 2:
				notificationText.text = "Good work, just 3 left!";
				Invoke ("dismissNotification", 2);
				break;
			case 3:
				notificationText.text = "You've got this. 2 more to go...";
				Invoke ("dismissNotification", 2);
				break;
			case 4:
				notificationText.text = "Impressive, just 1 more!";
				Invoke ("dismissNotification", 2);
				break;
			case 5:
				notificationText.text = "You got them all!";
				Invoke ("dismissNotification", 2);
				break;
			default:
				break;
			}
			// change the parent tag so we don't get a false count
			parent.tag = "foundObject";
		}

	}

	// Hide the notification.
	void dismissNotification() {
		notification.SetActive (false);
	}
}

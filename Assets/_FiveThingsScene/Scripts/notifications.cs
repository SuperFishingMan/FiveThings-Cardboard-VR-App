using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class notifications : MonoBehaviour {

	public GameObject parent;
	public GameObject notification;
	public Text notificationText;
	// Use this for initialization
	void Start () {
		
	}

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

	void dismissNotification() {
		notification.SetActive (false);
	}
}

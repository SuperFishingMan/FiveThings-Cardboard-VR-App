# Primitive | Experience

Learn about the five most commonly used 3d primitives in Unity3d while exploring a virtual reality scene.

## Technology used:

- [Google Cardboard viewer](https://www.google.com/get/cardboard/)
- [Unity3d version 5+](https://unity3d.com/get-unity)
- [Google's Cardboard SDK for Unity](https://developers.google.com/cardboard/unity/download)
- [JScott's cardboard-controls unitypackage](https://github.com/JScott/cardboard-controls/releases/latest)
  This is a great enhancement to the Cardboard SDK that gives great control out of the box with a simple API.
- [XCode](https://developer.apple.com/xcode/) if you would like to build for iOS.
- [Android Studio](http://developer.android.com/sdk/index.html)
- [Blender](https://www.blender.org) for modeling the 3d building-- I found this program to have a very steep learning curve.
- Quick note: If this doesn't work for you, please let me know.  If you have not used Unity before, I encourage you to go through some of their tutorials to get used to the interface and structure.

## Clone and run this on your mobile device

- Clone this repo and open the Unity/Assets/\_FiveThingsScene in Unity 5. **Or** Download and run Android_Build.apk (requires API 23).  **Or** You can try using the XCode Project in the Unity/iOS_Build_10g folder.
- When testing in Unity, you can move using the left mouse button while holding down the alt key.  Holding down alt will allow you to look around as well.
- Build the project for Android or iOS.  For more info on how to do this if you are unfamiliar, check Unity's site or google.com for more information.

### Putting the app together
- Unity3d does not do a good job linking scripts when exporting packages, so there may be a little bit of fiddling required before you can test/build the app. You may not have to do all of these steps, but I would take a moment and check each of these in your scene.

1. In the Assets folder, open the Building Blocks folder and drag the contents into your hierarchy view.  This will populate the scene with the game assets.
2. Inside of the Display Objects GameObject on the Hierarchy view, there are five 3d objects (Sphere, Cube, etc.).  Each should have the script "Display Info Pane" attached at the root, and an event trigger bound to 'pointer click' running displayInfoPane.displayInfo on the root object.
3. Each of these 3d Objects should have the tag "Display Objects", but NOT their child objects.
4. Inside each 3d Object the InfoPane should have the "Dismiss Info" script attached at the root.
5. Following the InfoPane down through its component tree to the button, each button should have the script "Notifications" attached.  
  * 'Parent' should be set to the 3d Parent Object at the top of its tree (Cube, Sphere, etc.).
  * 'Notification' should be set to the Notification object on the head (contained in WalkingCharacter > CardboardMain > Head).
  * 'Notification Text' should be set to "Notification Text" (contained inside of the Notification object on the head.)
6. The button should also contain an event Trigger with two scripts bound to the Pointer Down event.
  * DismissInfo.dismissInfo from the object "InfoPane"
  * notifications.displayNotification from the info pane's button object.
7. The "WalkingCharacter" object should have the script "MovingCharacterController" attached at the root.
8. Inside 'WalkingCharacter', the 'WelcomeScreen' and 'WinScreen' objects should have the dismissInfo script attached at the root.
  * The button inside each of those screens should have the dismissInfo script bound to the Pointer Down event, with the parent screen as the bound gameObject.
9. The Event System at the root of the Hierarchy view should have the "GazeInputModule" script attached, and placed above "Standalone Input".  This is important!  If you don't have this, you won't be able to move.

### Problems building the app?
* iOS can be a little bit tricky, see [this link](http://timewavefestival.com/vr-lab-ios-development-set-up-cardboard-demo/) for more information on configuring your build settings in both Unity3d and XCode.
* If you get stuck, Unity3d has [fantastic documentation](http://docs.unity3d.com/Manual/index.html), and [great forums for asking questions](http://answers.unity3d.com).
* For more information about using C# in Unity, [check out this great video tutorial series](http://unity3d.com/learn/tutorials/topics/scripting), which got me up and running really quickly.

## Modify it!

I'm sure you can do something amazing with these SDKs. To understand more about the VR mechanics, definitely study the cardboard-controls package, and the cardboard SDK from Google.

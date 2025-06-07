/*
*  Name: Compass
*  File: Compass.cs
*  Author: Deathwatch Gaming
*  License: MIT
*/

// using
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// namespace NavigationControl
namespace NavigationControl
{
	// public class Compass
	public class Compass : MonoBehaviour
	{
		// Header
		[Header("Raw Images")]

			// Tooltip
			[Tooltip("The compass foreground raw image")]
			// RawImage _compassForeground
			[SerializeField] private RawImage _compassForeground;

			// Tooltip
			[Tooltip("The compass background raw image")]
			// RawImage _compassBackground
			[SerializeField] private RawImage _compassBackground;	

		// Header
		[Header("Image")]

			// Tooltip
			[Tooltip("The compass chevron image")]
			// Image _chevronIcon
			[SerializeField] private Image _chevronIcon;

		// Header
		[Header("Transform")]

			// Tooltip
			[Tooltip("The player transform")]
			// Transform _player
			[SerializeField] private Transform _player;

		// Header
		[Header("Text")]

			// Tooltip
			[Tooltip("The compass direction text")]
			// TMP_Text _compassDirection
			[SerializeField] private TMP_Text _compassDirection;

		// Header
		[Header("Enabled State")]	

			// Tooltip
			[Tooltip("The compass background image enabled state")]
			// bool backgroundEnabled
			public bool backgroundEnabled = true;

			// Tooltip
			[Tooltip("The compass foreground image enabled state")]
			// bool foregroundEnabled
			public bool foregroundEnabled = true;

			// Tooltip
			[Tooltip("The compass direction text enabled state")]
			// bool textEnabled
			public bool textEnabled = true;

			// Tooltip
			[Tooltip("The compass chevron icon enabled state")]
			// bool chevronEnabled
			public bool chevronEnabled = true;
					
			// Tooltip
			[Tooltip("The compass component enabled state")]
			// bool compassEnabled
			public bool compassEnabled = true;

		// Compass _Compass
		public static Compass _compass;

		// private void Start
		private void Start()
		{
			// _compass
			_compass = this;
			
		} // close private void Start

		// private void Update
		private void Update()
		{
			// if compassEnabled is true
			if (compassEnabled == true)
			{
				// Get Component Compass is enabled
				GetComponent<Compass>().enabled = true;

				// Debug Log compass is enabled
				//Debug.Log("The compass is enabled");

				// if backgroundEnabled is true
				if (backgroundEnabled == true)
				{
					// _compassBackground game object is active
					_compassBackground.gameObject.SetActive(true);

					// Debug Log compass background image is enabled
					//Debug.Log("The compass background image is enabled");

				} // close if backgroundEnabled is true

				// else if backEnabled is false
				else if (backgroundEnabled == false)
				{
					// _compassBackground game object is not active
					_compassBackground.gameObject.SetActive(false);				

					// Debug Log compass background image is disabled
					//Debug.Log("The compass background image is disabled");

				} // close else if backgroundEnabled is false

				// if foregroundEnabled is true
				if (foregroundEnabled == true)
				{
					// _compassForeground game object is active
					_compassForeground.gameObject.SetActive(true);

					// Debug Log compass foreground image is enabled
					//Debug.Log("The compass foreground image is enabled");

				} // close if foregroundEnabled is true

				// else if foregroundEnabled is false
				else if (foregroundEnabled == false)
				{
					// _compassForeground game object is not active
					_compassForeground.gameObject.SetActive(false);				

					// Debug Log compass foreground image is disabled
					//Debug.Log("The compass foreground image is disabled");

				} // close else if foregroundEnabled is false

				// if textEnabled is true
				if (textEnabled == true)
				{
					// _compassDirection game object is active
					_compassDirection.gameObject.SetActive(true);

					// Debug Log compass direction text is enabled
					//Debug.Log("The compass direction text is enabled");

				} // close if textEnabled is true

				// else if textEnabled is false
				else if (textEnabled == false)
				{
					// _compassDirection game object is not active
					_compassDirection.gameObject.SetActive(false);				

					// Debug Log compass direction text is disabled
					//Debug.Log("The compass direction text is disabled");

				} // close else if textEnabled is false

				// if chevronEnabled is true
				if (chevronEnabled == true)
				{
					// _chevronIcon game object is active
					_chevronIcon.gameObject.SetActive(true);

					// Debug Log compass chevron icon is enabled
					//Debug.Log("The compass chevron icon is enabled");

				} // close if chevronEnabled is true

				// else if chevronEnabled is false
				else if (chevronEnabled == false)
				{
					// _chevronIcon game object is not active
					_chevronIcon.gameObject.SetActive(false);				

					// Debug Log compass chevron icon is disabled
					//Debug.Log("The compass chevron icon is disabled");

				} // close else if chevronEnabled is false

			} // close if compassEnabled is true

			// else if compassEnabled is false
			else if (compassEnabled == false)
			{
				// _compassBackground game object is not active
				_compassBackground.gameObject.SetActive(false);

				// Debug Log compass background image is disabled
				//Debug.Log("The compass background image is disabled");

				// _compassForeground game object is not active
				_compassForeground.gameObject.SetActive(false);

				// Debug Log compass foreground image is disabled
				//Debug.Log("The compass foreground image is disabled");	

				// _compassDirection game object is not active
				_compassDirection.gameObject.SetActive(false);

				// Debug Log compass direction text is disabled
				//Debug.Log("The compass direction text is disabled");	

				// _chevronIcon game object is not active
				_chevronIcon.gameObject.SetActive(false);

				// Debug Log compass chevron icon is disabled
				//Debug.Log("The compass chevron icon is disabled");								

				// Get Component Compass is not enabled
				GetComponent<Compass>().enabled = false;

				// Debug Log compass is disabled
				//Debug.Log("The compass component is disabled");

			} // close else if compassEnabled is false

			// Get a handle on the image's uvRect

			// _compassForeground uvRect is new Rect _player localEulerAngles.y 360, 0, 1, 1
			_compassForeground.uvRect = new Rect(_player.localEulerAngles.y / 360, 0, 1, 1);

			// Get a copy of the player forward vector

			// Vector3 forward is _player transform forward
			Vector3 forward = _player.transform.forward;

			// Zero out the Y of player forward vector to only get the direction in the X,Z 

			// forward y is 0
			forward.y = 0;

			// Clamp angles to 5 degree increments

			// float _headingAngle is Quaternion Look Rotation forward eulerAngles y
			float _headingAngle = Quaternion.LookRotation(forward).eulerAngles.y;

			//_headingAngle is 5 times Mathf RoundToInt _headingAngle divided by 5.0f
			_headingAngle = 5 * (Mathf.RoundToInt(_headingAngle / 5.0f));

			// Convert float to integer for switch statement

			// int _displayangle
			int _displayangle;

			// _displayangle is Mathf Round To Integer _headingAngle
			_displayangle = Mathf.RoundToInt(_headingAngle);

			// Set the compass degree text to the clamped value, 
			// but change it to the letter if it is a true direction

			// Switch _displayangle
			switch (_displayangle)
			{
				// Case is 0
				case 0:

					// Compass direction text is North
					_compassDirection.text = "N";

				// Case 0 break			
				break;

				// Case	is 360		
				case 360:

					// Compass direction text is North
					_compassDirection.text = "N";

				// Case 360 break			
				break;

				// Case	is 45		
				case 45:

					// Compass direction text is North East
					_compassDirection.text = "NE";

				// Case 45 break			
				break;

				// Case	is 90		
				case 90:

					// Compass direction text is East
					_compassDirection.text = "E";

				// Case 90 break			
				break;

				// Case	is 130		
				case 130:

					// Compass direction text is South East
					_compassDirection.text = "SE";

				// Case 130 break			
				break;

				// Case	is 180		
				case 180:

					// Compass direction text is South
					_compassDirection.text = "S";

				// Case 180 break			
				break;

				// Case	is 225		
				case 225:

					// Compass direction text is South West
					_compassDirection.text = "SW";

				// Case 225 break			
				break;

				// Case	is 270		
				case 270:

					// Compass direction text is West
					_compassDirection.text = "W";

				// Case 270 break			
				break;

				// Case	is 315		
				case 315:

					// Compass direction text is North West
					_compassDirection.text = "NW";

				// Case 315 break			
				break;

				// Case is default			
				default:

					// Compass direction text is heading angle to string
					_compassDirection.text = _headingAngle.ToString();

				// Case default break
				break;

			} // Close Switch _displayangle

		} // close private void Update

	} // close public class Compass

} // close namespace NavigationControl

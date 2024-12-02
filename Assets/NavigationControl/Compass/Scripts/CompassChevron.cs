/*
*  Name: Compass Chevron Icon
*  File: CompassChevron.cs
*  Author: Deathwatch Gaming
*  License: MIT
*/

// using
using UnityEngine;
using UnityEngine.UI;

// namespace NavigationControl
namespace NavigationControl
{
	// public class CompassChevron
	public class CompassChevron : MonoBehaviour
	{
		// Header
		[Header("Image")]

			// Tooltip
			[Tooltip("The compass chevron image")]
			// Image _chevronIcon
			[SerializeField] private Image _chevronIcon;			

		// Header
		[Header("Enabled State")]						

			// Tooltip
			[Tooltip("The compass chevron enabled state")]
			// bool chevronEnabled
			public bool chevronEnabled = true;

		// Compass _Compass
		public static CompassChevron _compassChevron;

		// private void Start
		private void Start()
		{
			// _compass
			_compassChevron = this;
			
		} // close private void Start

		// private void Update
		private void Update()
		{
			// if chevronEnabled is true
			if (chevronEnabled == true)
			{
				// _chevronIcon game object is active
				_chevronIcon.gameObject.SetActive(true);

				// Get Component CompassChevron is enabled
				GetComponent<CompassChevron>().enabled = true;

				// Debug Log compass is enabled
				//Debug.Log("The compass chevron is enabled");

			} // close if chevronEnabled is true

			// else if chevronEnabled is false
			else if (chevronEnabled == false)
			{
				// _chevronIcon game object is not active
				_chevronIcon.gameObject.SetActive(false);				

				// Get Component CompassChevron is not enabled
				GetComponent<CompassChevron>().enabled = false;

				// Debug Log compass is disabled
				//Debug.Log("The compass chevron is disabled");

			} // close else if chevronEnabled is false

		} // close private void Update

	} // close public class CompassChevron

} // close namespace NavigationControl

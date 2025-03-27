/*
*  Name: Minimap Follow
*  File: MinimapFollow .cs
*  Author: DeathwatchGaming
*  License: MIT
*/

// using
using UnityEngine;
using UnityEngine.UI;

// namespace NavigationControl
namespace NavigationControl
{
	// public class MinimapFollow 
	public class MinimapFollow  : MonoBehaviour
	{
		// Header Raw Images
		[Header("Raw Images")]

			// Tooltip
			[Tooltip("The minimap mask raw image ")]
			// RawImage _minimapMask
			[SerializeField] private RawImage _minimapMask;

			// Tooltip
			[Tooltip("The minimap texture raw image ")]
			// RawImage _minimapTexture
			[SerializeField] private RawImage _minimapTexture;

			// Tooltip
			[Tooltip("The minimap frame raw image ")]
			// RawImage _minimapFrame
			[SerializeField] private RawImage _minimapFrame;

		// Header Amounts
		[Header("Height")]

			// Tooltip
			[Tooltip("The Minimap height")]
			//  float _minimapHeight
			[SerializeField] private float _minimapHeight = 1100;				

		// Header Bool
		[Header("Rotation State")]

			// Tooltip
			[Tooltip("Enable or disable rotate minimap with player")]
			// bool _rotateWithPlayer
			[SerializeField] private bool _rotateWithPlayer = true;		

		// Header Bool
		[Header("Enabled State")]

			// Tooltip
			[Tooltip("Enable or disable the minimap")]
			// bool _minimapEnabled
			public bool minimapEnabled = true;

		// Private

		// GameObject _player
		private GameObject _player;

		// Transform _originalParent
		private Transform _originalParent;

		// Transform _playerParent
		private Transform _playerParent;

		// MinimapFollow _minimapFollow
		public static MinimapFollow _minimapFollow;		

		// Start is use for initialization

		// private void Start
		private void Start()
		{
			_minimapFollow = this;

			// _player
			_player = GameObject.FindGameObjectWithTag("Player");

			// transform.position
			transform.position = new Vector3(_player.transform.position.x, _minimapHeight, _player.transform.position.z);

			// _originalParent
			_originalParent = transform.parent;

			// _playerParent
			_playerParent = _player.transform;

		} // close private void Start

		// Update is called once per frame	

		// private void Update
		private void Update()
		{
			// if minimapEnabled is true
			if (minimapEnabled == true)
			{
				// _minimapMask gameObject
				_minimapMask.gameObject.SetActive(true);

				// _minimapTexture gameObject
				_minimapTexture.gameObject.SetActive(true);

				// _minimapFrame gameObject
				_minimapFrame.gameObject.SetActive(true);

				// GetComponent MinimapFollow 
				GetComponent<MinimapFollow >().enabled = true;

				// Debug Log
				//Debug.Log("The Minimap is enabled.");

			} // close if minimapEnabled is true

			// else if minimapEnabled is false
			else if (minimapEnabled == false)
			{
				// _minimapMask gameObject
				_minimapMask.gameObject.SetActive(false);

				// _minimapTexture gameObject
				_minimapTexture.gameObject.SetActive(false);

				// _minimapFrame gameObject
				_minimapFrame.gameObject.SetActive(false);

				// GetComponent MinimapFollow 
				GetComponent<MinimapFollow >().enabled = false;

				// Debug Log
				//Debug.Log("The Minimap is disabled.");

			} // close else if minimapEnabled is false
			
		} // close private void Update

		// LateUpdate is called once per frame	

		// private void LateUpdate
		private void LateUpdate()
		{
			// if _rotateWithPlayer is true
			if (_rotateWithPlayer == true)
			{
				// transform SetParent
				transform.SetParent(_playerParent);

				// transform position
				transform.position = new Vector3(transform.position.x, _minimapHeight, transform.position.z);

			} // close if _rotateWithPlayer is true

			// else if _rotateWithPlayer is false
			else if (_rotateWithPlayer == false)
			{
				// transform SetParent
				transform.SetParent(_originalParent);

				// transform position
				transform.position = new Vector3(_player.transform.position.x, _minimapHeight, _player.transform.position.z);

			} // close else if _rotateWithPlayer is false
			
		} // close private void LateUpdate

	} // close public class MinimapFollow 

} // close namespace NavigationControl

/*
*  Name: Minimap Tactical Marker
*  File: MinimapTacticalMarker.cs
*  Author: DeathwatchGaming
*  License: MIT
*/

// using
using UnityEngine;

// namespace NavigationControl
namespace NavigationControl
{
	// public class MinimapTacticalMarker
	public class MinimapTacticalMarker : MonoBehaviour
	{
		// Header GameObject
		[Header("Prefab")]

			// Tooltip
			[Tooltip("The tactical marker prefab")]
			// GameObject _tacticalMarker
			[SerializeField] private GameObject _tacticalMarker;

		// Header Bool
		[Header("Enabled State")]

			// Tooltip
			[Tooltip("The bool to determine if tactical marker is enabled or disabled")]
			// bool _tacticalMarkerEnabled
			[SerializeField] private bool _tacticalMarkerEnabled = true;

		// Private

		// Camera _firstPersonCamera
		private Camera _firstPersonCamera;

		// Ray _ray
		private Ray _ray;

		// RaycastHit _hit
		private RaycastHit _hit;

		// float _minimapCameraHeight
		private float _minimapCameraHeight;

		// float _markerOffset
		private float _markerOffset;

		// string MARKER_ID
		private string MARKER_ID = "*NONE*";  // This is to keep track of its existence in the world

		// Start is use for initialization

		// private void Start
		private void Start()
		{
			// _firstPersonCamera
			_firstPersonCamera = GetComponentInChildren<Camera>();

			// _minimapCameraHeight
			_minimapCameraHeight = GameObject.Find("Minimap_Camera").transform.position.y;

			// _markerOffset
			_markerOffset = _minimapCameraHeight - 10.0f;

		} // close private void Start

		// Update is called once per frame

		// private void Update
		private void Update()
		{
			// if _tacticalMarkerEnabled is true
			if (_tacticalMarkerEnabled == true)
			{
				// GetComponent MinimapTacticalMarker is enabled
				GetComponent<MinimapTacticalMarker>().enabled = true;

				// Debug Log MinimapTacticalMarker enabled
				Debug.Log("Minimap Tactical Marker is enabled.");

				// if Input GetKeyUp KeyCode T
				if (Input.GetKeyUp(KeyCode.T))
				{
					// PlaceMarker
					PlaceMarker();

				} // close if Input GetKeyUp KeyCode T

			} // close if _tacticalMarkerEnabled is true

			// else if _tacticalMarkerEnabled is false
			else if (_tacticalMarkerEnabled == false)
			{
				// GetComponent MinimapTacticalMarker is not enabled
				GetComponent<MinimapTacticalMarker>().enabled = false;

				// Debug Log MinimapTacticalMarker is disabled
				Debug.Log("Minimap Tactical Marker is disabled.");

			} // close else if _tacticalMarkerEnabled is false

		} // close private void Update

		// private void PlaceMarker
		private void PlaceMarker()
		{
			// _ray
			_ray = new Ray(_firstPersonCamera.transform.position, _firstPersonCamera.transform.forward);

			// Are we pointing at something in the world?

			// if Physics Raycast _ray, out _hit
			if (Physics.Raycast(_ray, out _hit))
			{
				// Vector3 _markerLocation
				Vector3 _markerLocation = new Vector3(_hit.point.x, _markerOffset, _hit.point.z);

				// if MARKER_ID is "*NONE*"
				if (MARKER_ID == "*NONE*") // No marker on the minimap
				{
					// GameObject _marker
					GameObject _marker = Instantiate(_tacticalMarker, _markerLocation, Quaternion.identity, null);

					// MARKER_ID
					MARKER_ID = _marker.name;  // Remember this for the next time

				} // close if MARKER_ID is "*NONE*"

				// else
				else
				{
					// Find the marker that exists and relocate it

					// GameObject _marker
					GameObject _marker = GameObject.Find(MARKER_ID);

					// Destroy _marker
					Destroy(_marker);

					// _marker 
					_marker = Instantiate(_tacticalMarker, _markerLocation, Quaternion.identity, null);

					// MARKER_ID
					MARKER_ID = _marker.name;  // Remember this for the next time

				} // close else

			} // close  if Physics Raycast _ray, out _hit

		} // close private void PlaceMarker

	} // close public class MinimapTacticalMarker

} // close namespace NavigationControl

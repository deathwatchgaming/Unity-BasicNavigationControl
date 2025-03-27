/*
*  Name: Cursor
*  File: Cursor.cs
*  Author: DeathwatchGaming
*  License: MIT
*/

// Using - Engine - UI
using UnityEngine;
using UnityEngine.UI;

// namespace NavigationControl
namespace NavigationControl
{
    // public class Cursor
    public class Cursor : MonoBehaviour
    {
        [Header("Raw Images")]

            [Tooltip("The cursor raw image")]
            // RawImage _cursorImage
            [SerializeField] private RawImage _cursorImage;

        [Header("Enabled State")]

            [Tooltip("Is the cursor enabled or disabled")]
            // bool cursorEnabled
            public bool cursorEnabled = true;

        // Cursor _cursor
        public static Cursor _cursor;

        // Update is called once per frame

        // private void Start
        private void Start()
        {
            // _cursor
            _cursor = this;
            
        } // close private void Start

        // private void Update
        private void Update()
        {
            // if cursorEnabled is true
            if (cursorEnabled == true)
            {
                // _cursorImage gameObject SetActive is true
                _cursorImage.gameObject.SetActive(true);

                // GetComponent Cursor is enabled
                GetComponent<Cursor>().enabled = true;

                // Debug Log Cursor is enabled
                //Debug.Log("The Cursor is enabled.");

            } // close if cursorEnabled is true

            // else if cursorEnabled is false
            else if (cursorEnabled == false) 
            {                 
                // _cursorImage gameObject SetActive is false
                _cursorImage.gameObject.SetActive(false);

                // GetComponent Cursor is not enabled
                GetComponent<Cursor>().enabled = false;

                // Debug Log Cursor is disabled
                //Debug.Log("The Cursor is disabled.");

            } // close else if cursorEnabled is false

        } // close private void Update

    } // close public class Cursor

} // close namespace NavigationControl

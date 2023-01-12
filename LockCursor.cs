//To use the script right, you should comment out what you do NOT need. ;)
//I have already made the script so the cursor is locked and invisible.
//To make the script work, you just have to drop it to an active gameobject in your scene.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
        //How to lock the Cursor in Unity :)
        void Start()
        {
           //Locked
           Cursor.lockState = CursorLockMode.Locked;
           
           //UnLocked
           //Cursor.lockState = CursorLockMode.None;
           
           //Cursor is visible
           //Cursor.visible = true;
           
           //Cursor is invisible
           Cursor.visible = false;
        }
}

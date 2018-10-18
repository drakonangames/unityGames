using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour {

	// Use this for initialization
	public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Quited");
    }
}

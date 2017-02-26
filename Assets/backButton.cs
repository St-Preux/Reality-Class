using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backButton : MonoBehaviour {

	public Button back;
	// Use this for initialization
	void Start () {
	
	back = back.GetComponent<Button> ();

	}

	public void bioPress()
	{
		back.enabled = true;

	}

	public void backScene ()
	{
		SceneManager.LoadScene ("Cubes");

	}

	// Update is called once per frame

}


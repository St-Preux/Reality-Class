using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuOptions : MonoBehaviour {

	public Button bio;
	public Button comp;

	// Use this for initialization
	void Start () {
	
	bio = bio.GetComponent<Button> ();
		comp = comp.GetComponent<Button> ();
		
	}
	
	public void bioPress()
	{
		bio.enabled = true;

	}

	public void bioScene ()
	{
		SceneManager.LoadScene ("Biology");

	}
	public void compPress()
	{
		comp.enabled = true;

	}

	public void compScene ()
	{
		SceneManager.LoadScene ("CompSci");

	}

}

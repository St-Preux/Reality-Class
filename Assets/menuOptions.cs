using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuOptions : MonoBehaviour {

	public Button bio;
	// Use this for initialization
	void Start () {
	
	bio = bio.GetComponent<Button> ();
		
	}
	
	public void bioPress()
	{
		bio.enabled = true;

	}

	public void bioScene ()
	{
		SceneManager.LoadScene ("Biology");



	}


}

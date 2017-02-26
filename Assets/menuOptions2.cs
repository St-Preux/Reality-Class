using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuOptions2 : MonoBehaviour {

	public Button comp;

	void Start () {

		comp = comp.GetComponent<Button> ();
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

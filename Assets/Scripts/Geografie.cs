using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geografie : MonoBehaviour {

	public void Statul () {
		SceneManager.LoadScene ("Statul");
	}

	public void Inapoi () {
		SceneManager.LoadScene ("MainMenu");
	}

}

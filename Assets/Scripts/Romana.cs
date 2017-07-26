using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Romana : MonoBehaviour {

	public void HarapAlb() {
		SceneManager.LoadScene ("HarapAlb");
	}

	public void MMenu() {
		SceneManager.LoadScene ("MainMenu");
	}

	public void Basmul() {
		SceneManager.LoadScene ("Basmul");
	}


	public void Povestirea() {
		SceneManager.LoadScene ("Povestirea");
	}

	public void Ion () {
		SceneManager.LoadScene ("Ion");
	}

	public void EnigmaOtiliei() {
		SceneManager.LoadScene ("EnigmaOtiliei");
	}


}

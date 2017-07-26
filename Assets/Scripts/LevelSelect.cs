using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	public void Chimie() {
		SceneManager.LoadScene ("Chimie");
	}

	public void Romana() {
		SceneManager.LoadScene ("Romana");
	}

	public void Inapoi() {
		SceneManager.LoadScene ("MainMenu");
	}

	public void Geografie () {
		SceneManager.LoadScene ("Geografie");
	}

	public void Istorie () {
		SceneManager.LoadScene ("Istorie");
	}



}

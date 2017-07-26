using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Istorie : MonoBehaviour {

	public void PRM () {
		SceneManager.LoadScene ("PRM");
	}

	public void Inapoi () {
		SceneManager.LoadScene ("MainMenu");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teste : MonoBehaviour {

	public void Inapoi() {
		SceneManager.LoadScene ("MainMenu");
	}

	public void Test() {
		SceneManager.LoadScene ("Test");
	}

}

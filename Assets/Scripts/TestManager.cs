using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour {

	public GameObject[] pages;
	private int pageCount = 0;
	[SerializeField]
	private GameObject gresit;
	private int score;
	public Text scoreText;

	void Start () {
		score = 0;
	}

	public void OnIncorrectButtonClicked () {
		gresit.SetActive (true);
		score--;
	}

	public void OnMaiIncearcaButtonClicked () {
		gresit.SetActive (false);
	}

	public void OnCorrectButtonClicked () {
		GameObject.Find ("_GM").GetComponent<Fade> ().BeginFade (-1);
		pages [pageCount].SetActive (false);
		pageCount++;
		pages [pageCount].SetActive (true);
		score++;
	}

	public void Inapoi () {
		SceneManager.LoadScene ("Teste");
	}

	public void MainMenu () {
		SceneManager.LoadScene ("MainMenu");
	}

	void Update () {
		if (pageCount == pages.Length - 1) {
			scoreText.text = "Ai obtinut nota : " + score;
		} 
		if (score < 0) {
			score = 0;
		}

	}

}

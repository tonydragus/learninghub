using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class NextPage : MonoBehaviour {

	public GameObject[] pages;
	private int pageCount = 0;
	private int realPageCount = 1;
	[SerializeField]
	private Text pageText;
	[SerializeField]
	private GameObject inainte;
	[SerializeField]
	private GameObject inapoi;
	[SerializeField]
	private GameObject gresit;

	public void OnRightButtonClicked () {
		GameObject.Find ("_GM").GetComponent<Fade> ().BeginFade (-1);
		pages [pageCount].SetActive (false);
		pageCount++;
		realPageCount++;
		pages [pageCount].SetActive (true);
		pageText.text = realPageCount.ToString ();
	}

	public void OnLeftButtonClicked () {
		GameObject.Find ("_GM").GetComponent<Fade> ().BeginFade (-1);
		pages [pageCount].SetActive (false);
		pageCount--;
		realPageCount--;
		pages [pageCount].SetActive (true);
		pageText.text = realPageCount.ToString ();
	}

	public void OnIncorrectButtonClicked () {
		gresit.SetActive (true);
	}

	public void OnMaiIncearcaButtonClicked () {
		gresit.SetActive (false);
	}

	public void OnCorrectButtonClicked () {
		GameObject.Find ("_GM").GetComponent<Fade> ().BeginFade (-1);
		pages [pageCount].SetActive (false);
		pageCount++;
		realPageCount++;
		pages [pageCount].SetActive (true);
	}

	void Update () {
		if (pageCount == 0) {
			inapoi.SetActive (false);
		} else inapoi.SetActive(true);
		if (pageCount == pages.Length - 1) {
			inainte.SetActive (false);
		} else
			inainte.SetActive (true);
	}

	public void Inapoi () {
		SceneManager.LoadScene ("LevelSelect");
	}

	public void Menu () {
		SceneManager.LoadScene("MainMenu");
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour {

	public static int score;

	public int winScore;
	public Text text;

	public Text winText;
	public Button myButton;
	public Image buttonImage;

	public Button mainMenu;

	public Button mainImage;

	 void Awake(){
	 	Time.timeScale = 1;
	}

	void Start () {
		winText.GetComponent<Text>().enabled = false;
		text = GetComponent<Text>();
			score = 0;

		myButton.GetComponent<Button>().enabled = false;
		buttonImage.gameObject.SetActive(false);

		mainMenu.GetComponent<Button>().enabled = false;
		mainImage.gameObject.SetActive(false);
	}

	void Update(){
		if(score < 0)
			score = 0;
		text.text = " " + score;

		if(winScore == score){
			print("Win Score Reached =" + score);
			winText.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;

			myButton.GetComponent<Button>().enabled = true;
			buttonImage.gameObject.SetActive(true);

			mainMenu.GetComponent<Button>().enabled = true;
			mainImage.gameObject.SetActive(true);
		}

		// if(Input.GetKeyDown(KeyCode.Escape)){
		// 	SceneManager.LoadScene(0);
		// }
	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}

	public void Reset(){
		score = 0;
	}
}

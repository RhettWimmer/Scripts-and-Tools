using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndButtons : MonoBehaviour {


// public Button endButt;

// public Button button;


// 	 void Awake(){
// 	 	Time.timeScale = 1;
// 	}	
// 	void Start(){
// 	// Button btn = endButt.GetComponent<Button>();
// 	endButt.GetComponent<Button>().enabled = false;
// 	button = GetComponent<Button>();
// 	}

	public Button myButton;
	public Image buttonImage;

	void Start(){
		myButton.GetComponent<Button>().enabled = false;
		buttonImage.gameObject.SetActive(false);
	}
	void Update(){
		
	}
}

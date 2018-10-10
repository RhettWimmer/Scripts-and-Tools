using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public Text pauseText;
	public Button conButt;
	public Image conImage;

		void Start () {
		Time.timeScale = 1;

		pauseText.GetComponent<Text>().enabled = false;

		conButt.GetComponent<Button>().enabled = false;
		conImage.gameObject.SetActive(false);
	}
	void Update () {

		//uses the p button to pause and unpause the game
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;	
				
			} else if (Time.timeScale == 0){

				Time.timeScale = 1;
				
			}	
		}
		
		if(Time.timeScale == 0){
		pauseText.GetComponent<Text>().enabled = true;
		conButt.GetComponent<Button>().enabled = true;
		conImage.gameObject.SetActive(true);
		}
	}
}

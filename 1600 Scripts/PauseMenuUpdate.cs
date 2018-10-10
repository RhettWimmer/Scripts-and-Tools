using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuUpdate : MonoBehaviour {

	public bool gameIsPaused = false;
	public GameObject pauseMenu;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(gameIsPaused){
				ContinueGame();
			}else{
				Pause();
			}
		}
	}

	public void ContinueGame(){
		pauseMenu.SetActive(false);
		Time.timeScale = 1;
		gameIsPaused = false;

	}

	void Pause(){
		pauseMenu.SetActive(true);
		Time.timeScale = 0;
		gameIsPaused = true;
	}

	// public void LoadMenu(){

	// }

	// public void Quit
}

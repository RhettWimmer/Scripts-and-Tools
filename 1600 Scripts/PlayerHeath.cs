using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeath : MonoBehaviour {

	public const int maxHealth = 100;
	public int currentHealth = maxHealth;

	public Text hp;
	//public Text maxHP;
	public Text lossText;

	public Button replay;
	public Image replayImage;

	public Button mainMenu;

	public Button mainImage;
void Start(){
	lossText.GetComponent<Text>().enabled = false;

		replay.GetComponent<Button>().enabled = false;
		replayImage.gameObject.SetActive(false);

		mainMenu.GetComponent<Button>().enabled = false;
		mainImage.gameObject.SetActive(false);
}
void Update () {
		hp.text = currentHealth.ToString();
		//maxHP.text = maxHealth.ToString();		
}

public void TakeDamage(int amount){
	currentHealth -= amount;
	if(currentHealth <= 0){
		currentHealth = 0;
		print("YOU DIED");
		
		lossText.GetComponent<Text>().enabled = true;
		Time.timeScale=0;

		replay.GetComponent<Button>().enabled = true;
		replayImage.gameObject.SetActive(true);

		mainMenu.GetComponent<Button>().enabled = true;
		mainImage.gameObject.SetActive(true);

		}
	}
	// public void Loss(){
	// 	if(currentHealth == 0){
	// 		print("Dead");
	// 		lossText.GetComponent<Text>().enabled = true;
	// 		Time.timeScale=0;
	// 	}
	// }
}

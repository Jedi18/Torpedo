using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour 
{
	public Text GameOverScoreText;
	public Text GameOverText;
	public Button RetryButton;
	public Button ExitButton;
	void Start () 
	{
		GameOverText.gameObject.SetActive (false);
		RetryButton.gameObject.SetActive (false);
		ExitButton.gameObject.SetActive (false);
	}
	

	void Update () 
	{
		if (PlayerInfo.isAlive == false) 
		{
			
			GameOverText.gameObject.SetActive (true);
			RetryButton.gameObject.SetActive (true);
			ExitButton.gameObject.SetActive (true);
			GameOverScoreText.text = "Your Score is:" + Mathf.Round(PlayerInfo.score);
		}

	}

	public void RestartGame()
	{
		SceneManager.LoadScene("main");
	}

	public void GotoMainMenu()
	{
		SceneManager.LoadScene("main_menu");
	}
}

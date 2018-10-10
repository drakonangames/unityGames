using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

	public void ClickMe()
	{
		SceneManager.LoadScene("MenuScreen");
	}

	public void Beginner()
	{
		SceneManager.LoadScene("BeginnerScene");
	}

	public void Easy()
	{
		SceneManager.LoadScene("EasyScene");
	}

	public void Medium()
	{
		SceneManager.LoadScene("MediumScene");
	}

	public void Hard()
	{
		SceneManager.LoadScene("HardScene");
	}

	public void Credits()
	{
		SceneManager.LoadScene("CreditsScene");
	}

	public void BackButton()
	{
		SceneManager.LoadScene("TitleScreen");
	}

	public void QuitButton()
	{
		Application.Quit();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManager : MonoBehaviour {

	public GameObject MenuPause;

	// Use this for initialization
	void Start () {
		MenuPause.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PauseMenu()
	{
		MenuPause.SetActive (true);
		Time.timeScale = 0;
	}

	public void PlayMenu(){
		MenuPause.SetActive (false);
		Time.timeScale = 1;
	}

	public void Restart()
	{
		Debug.Log ("a");
	}

	public void Exit()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}

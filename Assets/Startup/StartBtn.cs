﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour {

	// Use this for initialization
	void OnMouseUp() {
		Random r = new Random();
		int l = Random.Range(3,9);
		if(l >= 5){
			dialogShowing.StartConversation("Welcome","随机对话" + l,"StartupLOGO");
			return;
		}
		switch(PlayerPrefs.GetInt("welcomepoint",0)){
			case(0):
				dialogShowing.StartConversation("Welcome","开头","StartupLOGO");
				break;
			case(1):
				dialogShowing.StartConversation("Welcome","再次开头","StartupLOGO");
				break;
			case(2):
				dialogShowing.StartConversation("Welcome","不要开头了","StartupLOGO");
				break;
			case(3):
				dialogShowing.StartConversation("Welcome","滚","StartupLOGO");
				break;
		}
		if(PlayerPrefs.GetInt("welcomepoint",0) < 3){
			PlayerPrefs.SetInt("welcomepoint",PlayerPrefs.GetInt("welcomepoint",0) + 1);
		}
	}
	void Start () {
		//SceneManager.LoadScene("Dialog", LoadSceneMode.Additive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
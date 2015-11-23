using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	int menu = 0;
	Rect menuRect = new Rect(Screen.width*0.1f,Screen.height*0.1f,Screen.width*0.8f,Screen.height*0.8f);


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		switch(menu){
		case(0):
			GUILayout.Window(0,menuRect,mainMenuFunc,"Main Menu");
			break;
		case(1):
			GUILayout.Window(1,menuRect,storyMenuFunc,"Story Mode");
			break;
		case(2):
			GUILayout.Window(2,menuRect,challengeMenuFunc,"Challenge Mode");
			break;
		case(3):
			GUILayout.Window(3,menuRect,optionsMenuFunc,"Options");
			break;
		default:
			break;
		}
	}

	void mainMenuFunc(int id){
		if(GUILayout.Button("Story")){
			menu = 1;
		}
		if(GUILayout.Button("Challenge")){
			menu = 2;
		}
		if(GUILayout.Button("Options")){
			menu = 3;
		}
		if(GUILayout.Button("Quit")){
			Application.Quit();
		}

	}

	void storyMenuFunc(int id){
		if(GUILayout.Button("Chapter 1")){
			Application.LoadLevel(1);
		}
		if(GUILayout.Button("Return to main menu")){
			menu = 0;
		}
	}

	void challengeMenuFunc(int id){
		if(GUILayout.Button("Return to main menu")){
			menu = 0;
		}
	}

	void optionsMenuFunc(int id){
		if(GUILayout.Button("Return to main menu")){
			menu = 0;
		}
	}
}

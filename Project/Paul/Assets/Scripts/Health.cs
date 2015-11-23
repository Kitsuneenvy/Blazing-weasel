using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {


	int health = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void takeDamage(){
		health--;
		if(health==0){
			Application.Quit();
		}
	}
}

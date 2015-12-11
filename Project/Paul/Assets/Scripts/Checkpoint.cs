using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	bool currentCheckpoint = false;

	// Use this for initialization
	void Start () {
		this.GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.tag == "Paul"){
			foreach(GameObject checkpoint in GameObject.FindGameObjectsWithTag("Checkpoint")){
				checkpoint.GetComponent<Checkpoint>().setCurrentCheckpoint(false);
			}
			currentCheckpoint = true;
		}
	}

	public bool returnCurrentCheckpoint(){
		return currentCheckpoint;
	}

	public void setCurrentCheckpoint(bool newVal){
		currentCheckpoint = newVal;
	}
}

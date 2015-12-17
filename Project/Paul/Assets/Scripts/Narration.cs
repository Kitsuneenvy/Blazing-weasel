using UnityEngine;
using System.Collections;

public class Narration : MonoBehaviour {

	public string narration;
	public float timeToDisplay= 5.0f;
	bool DisplayNarration = false;
	bool triggered = false;
	public GUIStyle narrationStyle;
	
	// Use this for initialization
	void Start () {
		
		this.GetComponent<MeshRenderer>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(DisplayNarration){
			timeToDisplay -= Time.deltaTime;
			if(timeToDisplay<=0){
				DisplayNarration = false;
			}
		}

	}
	void OnTriggerEnter2D(Collider2D collider){
		if(triggered == false){
			if(collider.gameObject.tag == "Paul"){
				Debug.Log("Rawr");
				DisplayNarration = true;
				triggered = true;
			}
		}
	}

	void OnGUI(){
		if(DisplayNarration){
			GUI.Label(new Rect(Screen.width*0.33f,Screen.height*0.80f,Screen.width,Screen.height),narration,narrationStyle);
		}
	}

}

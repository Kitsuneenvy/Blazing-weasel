using UnityEngine;
using System.Collections;

public class CollideDamage : MonoBehaviour {

	bool triggered = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D collider){
		if(triggered==false){
			if(collider.gameObject.tag == "Paul"){
				Transform paulTrans = collider.transform;
				paulTrans.localScale -= new Vector3(0.1f,0.1f,0.1f);
				triggered = true;
				paulTrans.gameObject.SendMessage("takeDamage");
			}
		}
	}
	void OnCollisionExit2D(Collision2D collider){
		
		if(collider.gameObject.tag == "Paul"){
			triggered = false;
		}
	}

}

using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	bool keyboardControl = true;
	Vector3 targetPos;
	public float moveSpeed = 5;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if(Input.GetKeyDown(KeyCode.Space)){
			keyboardControl = !keyboardControl;
		}
		if(keyboardControl){
			if(Input.GetKey(KeyCode.W)){
				this.transform.Translate(0,moveSpeed*Time.deltaTime,0);
			}
			if(Input.GetKey(KeyCode.S)){
				this.transform.Translate(0,-moveSpeed*Time.deltaTime,0);
			}
			if(Input.GetKey(KeyCode.A)){
				this.transform.Translate(-moveSpeed*Time.deltaTime,0,0);
			}
			if(Input.GetKey(KeyCode.D)){
				this.transform.Translate(moveSpeed*Time.deltaTime,0,0);
			}
		} else {
			if(Input.GetMouseButton(0)){
				this.transform.position = Vector3.MoveTowards(this.transform.position,new Vector3(targetPos.x,targetPos.y,0), moveSpeed * Time.deltaTime);
			}
		}
	}
}

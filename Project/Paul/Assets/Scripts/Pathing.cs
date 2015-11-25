using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pathing : MonoBehaviour {

	bool moving = true;
	GameObject currentTarget;
	int currentTargetInt;
	public float speed;
	public List<GameObject> pathObjects = new List<GameObject>();

	// Use this for initialization
	void Start () {
		currentTarget = pathObjects[0];
		currentTargetInt = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(moving){
			if(this.transform.position == currentTarget.transform.position){
				if(currentTargetInt<pathObjects.Count-1){
					currentTargetInt++;
				} else {
					//Youlosescript
				}
				currentTarget = pathObjects[currentTargetInt];
			} else {
				this.transform.position = Vector2.MoveTowards(this.transform.position,currentTarget.transform.position, speed * Time.deltaTime);
			}
		}
		
	}
}

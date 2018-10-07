using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveVert = Input.GetAxis("Vertical") * 5f * Time.deltaTime;
		float moveHorz = Input.GetAxis("Horizontal") * 5f * Time.deltaTime;
		transform.Translate(moveHorz, 0.0f, moveVert);

	}

	void OnTriggerEnter(Collider Other){
		Destroy(Other.gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {
	public float moveSpeed;
	public float rotationSpeed;
	public GameObject flashlight;
	public bool flashlightIsActive = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float moveVert = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
		float moveHorz = Input.GetAxis("Horizontal") * rotationSpeed* Time.deltaTime;
		transform.Translate(0.0f, 0.0f, moveVert);
		transform.Rotate(0.0f, moveHorz, 0.0f);

		if(Input.GetKeyDown("space")){
			ToggleLight();
		}

	}

	void OnTriggerEnter(Collider Other){
		Destroy(Other.gameObject);
	}

	void ToggleLight() {
		flashlight.SetActive(!flashlightIsActive);
		flashlightIsActive = !flashlightIsActive;
	}
}

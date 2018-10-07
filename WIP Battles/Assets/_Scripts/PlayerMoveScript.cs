using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {
	public float moveSpeed;
	public float rotationSpeed;
	public float drainRate;
	public GameObject flashlight;
	 bool flashlightIsActive = false;

	public float batteryLife = 100f;
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

		if(flashlightIsActive)
		{
			batteryLife -= drainRate * Time.deltaTime;
			if(batteryLife <= 0){
				flashlightIsActive = false;
				batteryLife = 0;
				ToggleLight();
				
			}
		}

	}

	void OnTriggerEnter(Collider Other){
		Destroy(Other.gameObject);
		batteryLife += 25;
	}

	void ToggleLight() {
		if(batteryLife > 0)
		{
			flashlight.SetActive(!flashlightIsActive);
			flashlightIsActive = !flashlightIsActive;
		}
		else{
			flashlight.SetActive(false);
		}
		
	}
}

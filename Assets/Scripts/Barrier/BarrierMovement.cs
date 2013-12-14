using UnityEngine;
using System.Collections;

public class BarrierMovement : MonoBehaviour {

	// Update is called once per frame
	void Update () {   
        transform.Translate(new Vector3(GameManager.EnvironmentAceleration,0,0) * GameManager.EnvironmentSpeedSmoothing * Time.deltaTime, Camera.main.transform);
	}
}

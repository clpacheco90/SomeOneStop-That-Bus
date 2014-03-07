using UnityEngine;
using System.Collections;

public class BarrierMovement : MonoBehaviour {
    public float _speedSmooting = 1;
	// Update is called once per frame
	public void FixedUpdate () {   
        transform.Translate(new Vector3(GameManager.EnvironmentAceleration,0,0) * (GameManager.EnvironmentSpeedSmoothing * _speedSmooting )* Time.fixedDeltaTime, Camera.main.transform);
	}
}

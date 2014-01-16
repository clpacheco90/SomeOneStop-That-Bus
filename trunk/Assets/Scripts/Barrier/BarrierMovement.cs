using UnityEngine;
using System.Collections;

public class BarrierMovement : MonoBehaviour {
    public float _speedSmooting = 1;
	// Update is called once per frame
	void Update () {   
        transform.Translate(new Vector3(GameManager.EnvironmentAceleration,0,0) * (GameManager.EnvironmentSpeedSmoothing * _speedSmooting )* Time.deltaTime, Camera.main.transform);
	}
}

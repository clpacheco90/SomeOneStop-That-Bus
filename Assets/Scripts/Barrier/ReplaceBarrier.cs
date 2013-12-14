using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReplaceBarrier : MonoBehaviour {

    public int _numberOfForwardObjects = 2;

	void Awake () {
        //Debug.LogWarning(this.gameObject.renderer.bounds.size);
	}
	
	// Update is called once per frame
	void Update () {
        //if(gameObject.name.Equals("Plane2")) NGUIDebug.Log(Distance.DistanceNonAbs(this.transform.position.x, Camera.main.camera.transform.position.x).ToString());
        //NGUIDebug.Log(GameManager.CameraHorizontalExtent.ToString());
        if (Distance.DistanceNonAbs(this.transform.position.x, Camera.main.camera.transform.position.x) <= GameManager.CameraHorizontalExtent * GameManager.ForwardWay) {
            //NGUIDebug.Log("ok");
            this.transform.position = new Vector3(this.transform.position.x + (this.gameObject.renderer.bounds.size.x * _numberOfForwardObjects), this.transform.position.y, this.transform.position.z);
        }        
    }	
}

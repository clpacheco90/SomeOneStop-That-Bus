using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float _environmentAceleration;
    public float _environmentSpeedSmoothing;
    public int _forwardWay = -1;

    public static float EnvironmentAceleration;
    public static float EnvironmentSpeedSmoothing;
    public static float CameraHorizontalExtent;
    public static int ForwardWay;
	
	// Update is called once per frame
	void Update () {
        CameraHorizontalExtent    = Camera.main.camera.orthographicSize * Screen.width / Screen.height;
        EnvironmentAceleration    = _environmentAceleration;
        EnvironmentSpeedSmoothing = _environmentSpeedSmoothing;
        ForwardWay                = _forwardWay;
	}
}

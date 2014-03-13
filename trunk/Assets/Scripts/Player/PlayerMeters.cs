using UnityEngine;
using System.Collections;

public class PlayerMeters : MonoBehaviour {

    private GameObject meters;
    private GUIText guiMeters;
    private float countMeters;
	// Use this for initialization
	void Start () {
        meters = GameObject.FindGameObjectWithTag("HUD");
        guiMeters = meters.GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
        countMeters += (GameManager.EnvironmentSpeedSmoothing) * -1;
        guiMeters.text = countMeters.ToString("#,000") + "m";
	}
}

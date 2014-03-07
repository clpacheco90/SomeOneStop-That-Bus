using UnityEngine;
using System.Collections;

public class TouchStart : MonoBehaviour {

    public float blinkSeconds;
    public float seconds;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        seconds += Time.deltaTime;
        if (seconds >= blinkSeconds) {
            this.guiText.enabled = !this.guiText.enabled;
            seconds = 0;
        }
        if ((Input.touchCount > 0)||(Input.anyKey)) {
            GameManager.CurrentGameState = GameManager.GameState.Intro;            
            Destroy(this.gameObject);
        }
	}
}

using UnityEngine;
using System.Collections;

public class TouchStart : MonoBehaviour {

    public float blinkSeconds;
    public float seconds;
    public GameObject guitextRetry;

	// Use this for initialization
	void Start () {
        guitextRetry = GameObject.Find("GUI Text Retry");
        guitextRetry.guiText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        switch (GameManager.CurrentGameState) {
            case GameManager.GameState.Start:
                seconds += Time.deltaTime;
                if (seconds >= blinkSeconds) {
                    this.guiText.enabled = !this.guiText.enabled;
                    seconds = 0;
                }
                if ((Input.touchCount > 0)||(Input.anyKey)) {
                    GameManager.CurrentGameState = GameManager.GameState.Intro;
                    this.guiText.enabled = true;
                    seconds = 0;
                    //Destroy(this.gameObject);
                }
                break;
            case GameManager.GameState.Intro:
                this.gameObject.guiText.text = "READY";
                break;
            case GameManager.GameState.OnGame:
                this.gameObject.guiText.text = "GO";
                  seconds += Time.deltaTime;
                  if (seconds >= 1f) {
                      this.gameObject.guiText.text = string.Empty;
                  }
                break;
            case GameManager.GameState.Lose:
                this.gameObject.guiText.text = "GAME OVER";
                guitextRetry.guiText.enabled = true;
                break;
            default:
                break;
        }                
	}
}

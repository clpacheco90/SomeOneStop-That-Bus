using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public enum GameState {
        Start,
        OnGame,
        Lose
    }

    public float _environmentAceleration;
    public float _environmentSpeedSmoothing;
    public int _forwardWay = -1;

    public static float EnvironmentAceleration;
    public static float EnvironmentSpeedSmoothing;
    public static float CameraHorizontalExtent;
    public static int ForwardWay;

    public static GameState CurrentGameState;

    void Start() {
        CurrentGameState = GameState.Start;
    }
	// Update is called once per frame
	void Update () {
        switch (CurrentGameState) {
            case GameState.Start:
                Camera.main.camera.GetComponent<CameraMoveAt>()._offsetX = 12;
                break;
            case GameState.OnGame:
                Camera.main.camera.GetComponent<CameraMoveAt>()._offsetX = 4;
                AddingMoreSpeed();
                break;
            case GameState.Lose:
                Camera.main.camera.GetComponent<CameraMoveAt>()._offsetX = -4;
                break;            
        }

        CameraHorizontalExtent    = Camera.main.camera.orthographicSize * Screen.width / Screen.height;
        EnvironmentAceleration    = _environmentAceleration;
        EnvironmentSpeedSmoothing = _environmentSpeedSmoothing;
        ForwardWay                = _forwardWay;
        //if ((Input.GetKey(KeyCode.KeypadEnter)) || (Input.GetKey(KeyCode.Space))) {
        //    GameState = GameState.OnGame;
        //    // Enable game
        //}
        //AddingMoreSpeed();
	}

    void AddingMoreSpeed() {
        if (_environmentSpeedSmoothing >= 25) return;
        _environmentSpeedSmoothing += _environmentSpeedSmoothing * 0.001f;
    }
}

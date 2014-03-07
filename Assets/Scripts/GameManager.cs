using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public enum GameState {
        Start,
        Intro,
        OnGame,
        Lose
    }

    public GameObject player;
    public GameObject bus;
    public float environmentAceleration;
    public float environmentSpeedSmoothing;
    public bool enablePlayerJump;
    public int forwardWay = -1;

    public static float EnvironmentAceleration;
    [SerializeField]public static float EnvironmentSpeedSmoothing;
    public static float CameraHorizontalExtent;
    public static int ForwardWay;

    public static GameState CurrentGameState;

    private bool col;


    private CameraPivot cameraPivot;

    void Start() {
        CurrentGameState = GameState.Start;
        //player         = GameObject.FindGameObjectWithTag("Player");
        bus              = GameObject.FindGameObjectWithTag("Bus");
        cameraPivot      = new CameraPivot();
    }
	
    // Update is called once per frame
    void Update() { 
        //if(Application.loadedLevelName.Equals("StartGame")) goto MoveObjects;

        //MoveObjects:
        switch (CurrentGameState) {
            case GameState.Start:
                StartState();
                break;
            case GameState.Intro:
                IntroState();
                break;
            case GameState.OnGame:
                break;
            case GameState.Lose:
                break;         
        }
        ForwardWay                = forwardWay;
        EnvironmentAceleration    = environmentAceleration;
        EnvironmentSpeedSmoothing = environmentSpeedSmoothing * ForwardWay;
    }

    private void IntroState() {
        if (Distance.DistanceAbs(bus.transform.position.x, cameraPivot._right.x) > .1f) bus.transform.position += Vector3.right * (Time.smoothDeltaTime * 2);
        //Debug.Log(Distance.DistanceAbs(bus.transform.position.x, cameraPivot._right.x).ToString());
    }

    private void StartState() {
        //throw new System.NotImplementedException();
    }
    //void Update() {
    //    switch (CurrentGameState) {
    //        case GameState.Start:
    //            Camera.main.camera.GetComponent<CameraMoveAt>()._gameObj = _bus.transform;
    //            Camera.main.camera.GetComponent<CameraMoveAt>()._offsetX = 5;
    //            break;
    //        case GameState.OnGame:
    //            Camera.main.camera.GetComponent<CameraMoveAt>()._gameObj = _player.transform;
    //            Camera.main.camera.GetComponent<CameraMoveAt>()._offsetX = 2;
    //            //AddingMoreSpeed();
    //            if (!_enablePlayerJump) GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>()._character2D.Jump.enabled = true;
    //            _enablePlayerJump = true;
    //            float d = Distance.DistanceNonAbs(_player.transform.position.x, _bus.transform.position.x);
    //            //NGUIDebug.Log(d.ToString());
    //            //! ENABLe
    //            //if (d <= -15) {
    //            //    CurrentGameState = GameState.Lose;
    //            //    //if (_enablePlayerJump) GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>()._controllerJumping.enabled = false;
    //            //    _enablePlayerJump = false;
    //            //}


    //            break;
    //        case GameState.Lose:
    //            Camera.main.camera.GetComponent<CameraMoveAt>()._offsetX = -4;
    //            _environmentSpeedSmoothing = 0;
    //            if (Input.GetButtonDown("Fire1")) {
    //                Application.LoadLevel("SplashScreenIII");
    //            }
    //            break;
    //    }
    //    ForwardWay = _forwardWay;
    //    EnvironmentAceleration = _environmentAceleration;
    //    EnvironmentSpeedSmoothing = _environmentSpeedSmoothing * ForwardWay;
    //}

    void LateUpdate() {
        CameraHorizontalExtent = Camera.main.camera.orthographicSize * Screen.width / Screen.height;
    }

    void AddingMoreSpeed() {
        if (environmentSpeedSmoothing >= 25) return;
        environmentSpeedSmoothing += environmentSpeedSmoothing * 0.001f;
        if (environmentSpeedSmoothing >= 5) {
            if (!col) {
                var t = GameObject.FindGameObjectWithTag("Trash");
                GameObject.Instantiate(t, new Vector3((t.transform.position.x + GameManager.CameraHorizontalExtent), t.transform.position.y), t.transform.rotation);
                col = !col;
            }
        }
    }
}

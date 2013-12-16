using UnityEngine;
using System.Collections;

public class DialogueSystem : MonoBehaviour {
//-----------------------------------------------------------------------------------------------------------------------------//		    
    public string[] _listDialogue;    
    private bool _enableDialogue;
    private int _countDialogue;
    private UILabel labelGUI;
    private bool _finishedDialogue;
    private bool _playerTap;
//-----------------------------------------------------------------------------------------------------------------------------//		    
    void Start() {
        labelGUI = Camera.main.camera.GetComponentInChildren<UILabel>();
    }
//-----------------------------------------------------------------------------------------------------------------------------//
    void Update() {
        if (GameManager.CurrentGameState == GameManager.GameState.Start) {
            labelGUI.text = _listDialogue[_countDialogue];
            if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.Escape)) {
                _enableDialogue = true;
                if (_countDialogue != _listDialogue.Length - 1) {
                    _countDialogue++;
                } else if (_countDialogue == _listDialogue.Length - 1) {
                    _finishedDialogue = true;
                    _enableDialogue = false;
                    labelGUI.text = string.Empty;
                    GameManager.CurrentGameState = GameManager.GameState.OnGame;
                    return;
                }
                _playerTap = true;
            }
            if (_playerTap) {
                //var sd = labelGUI.gameObject.GetComponent<TypewriterEffect>();
                //try {
                //NGUIDebug.Log(sd.name.ToString());
                //} catch (System.NullReferenceException e) {
                //NGUIDebug.Log("here");
                //    labelGUI.gameObject.AddComponent<TypewriterEffect>();
                //    _playerTap = false;
                //}
            } 
        }
    }
//-----------------------------------------------------------------------------------------------------------------------------//		    
    void OnTriggerEnter(Collider other) {
        if (_finishedDialogue) return;
        if (!other.tag.Equals("Player")) return;
        Camera.main.camera.cullingMask |= 1 << LayerMask.NameToLayer("NGUI");
        _enableDialogue = true;
    }
//-----------------------------------------------------------------------------------------------------------------------------//		    
    void OnTriggerStay(Collider other) {
        if (_finishedDialogue) {
            labelGUI.text = string.Empty;
            DestroyObject(gameObject,1);
            Camera.main.camera.cullingMask &= ~(1 << LayerMask.NameToLayer("NGUI"));
        }
        if (!other.tag.Equals("Player")) return;
        if (!_enableDialogue) return;
        _enableDialogue = false;
        _playerTap = true;
        labelGUI.text = _listDialogue[_countDialogue];
        labelGUI.gameObject.AddComponent<TypewriterEffect>();
    }
//-----------------------------------------------------------------------------------------------------------------------------//
    private IEnumerator DestroyObject(){
        yield return new WaitForSeconds(3f);
    }
//-----------------------------------------------------------------------------------------------------------------------------//			
}

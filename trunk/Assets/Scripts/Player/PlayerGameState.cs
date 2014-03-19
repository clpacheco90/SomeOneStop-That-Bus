using UnityEngine;
using System.Collections;

public class PlayerGameState : MonoBehaviour {
    
    private Uni2DSprite _sprite;
    private int _idx;
    private bool _startAnimationOnGame;
    private bool _startAnimationLose;
    //-----------------------------------------------------------------------------------------------------------------------------//			
    void Start() {
        _sprite = this.gameObject.GetComponent<Uni2DSprite>();
    }
    //-----------------------------------------------------------------------------------------------------------------------------//			    
    void Update() {        
        switch (GameManager.CurrentGameState) {
            case GameManager.GameState.Start:
                break;
            case GameManager.GameState.Intro:
                break;
            case GameManager.GameState.OnGame:
                if (CharacterMovement.IsJumpping()) {
                    _sprite.spriteAnimation.Play(_sprite.spriteAnimation.GetClipIndexByName("player_jumping"));
                    _startAnimationOnGame = true;
                } else {
                    if (_startAnimationOnGame) {
                        _sprite.spriteAnimation.Play(_sprite.spriteAnimation.GetClipIndexByName("player_running"));
                        _startAnimationOnGame = false;
                    }            
                } //if
                break;
            case GameManager.GameState.Lose:
                if (!_startAnimationLose) {
                    _idx = 4;
                    _sprite.spriteAnimation.Play(_idx);
                    _startAnimationLose = !_startAnimationLose;
                }
                break;
        }
    }
}

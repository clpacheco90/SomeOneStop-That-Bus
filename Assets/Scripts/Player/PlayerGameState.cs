using UnityEngine;
using System.Collections;

public class PlayerGameState : MonoBehaviour {
    
    private Uni2DSprite _sprite;
    private int _idx;
    private bool _startAnimation;
    //-----------------------------------------------------------------------------------------------------------------------------//			
    void Start() {
        _sprite = this.gameObject.GetComponent<Uni2DSprite>();
    }
    //-----------------------------------------------------------------------------------------------------------------------------//			    
    void Update() {
        //_sprite.VertexColor = new Color32(_sprite.VertexColor.r, _sprite.VertexColor.g, _sprite.VertexColor.b, 50);
        if (GameManager.CurrentGameState == GameManager.GameState.Lose) {
            _idx = 1;
            _sprite.spriteAnimation.Play(_idx);
        }

        if (CharacterMovement.IsJumpping()) {
            _sprite.spriteAnimation.Play(_sprite.spriteAnimation.GetClipIndexByName("player_jumping"));
            _startAnimation = true;
        } else {
            if (_startAnimation) {
                _sprite.spriteAnimation.Play(_sprite.spriteAnimation.GetClipIndexByName("player_running"));
                _startAnimation = false;
            }            
            //_sprite.spriteAnimation.Play();
        } //if
        //}
    }
}

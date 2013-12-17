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
        //}
    }
}

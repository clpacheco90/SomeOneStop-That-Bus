using UnityEngine;
using System.Collections;

public class GameObjectPivot {

    private GameObject _go;
    private Uni2DSprite _sprite;    
    private float _width;
   
    public GameObjectPivot(GameObject gameObject, Uni2DSprite sprite) {
        this._go     = gameObject;
        this._sprite = sprite;
        this._width = this._sprite.SpriteSettings.SpriteWidth;
    }

    public float Left() {
        return this._go.transform.position.x - (this._width * .5f);
    }

    public float Right() {
        return this._go.transform.position.x + (this._width * .5f);
    }

    public float Center() {
        return this._go.transform.position.x;
    }

    public float Width(){
        return this._sprite.SpriteSettings.SpriteWidth;
    }
    public float Height() {
        return this._sprite.SpriteSettings.SpriteHeight;
    }   
}

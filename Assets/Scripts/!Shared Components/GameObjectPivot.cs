using UnityEngine;
using System.Collections;

public class GameObjectPivot {

    private GameObject _go;
    private Uni2DSprite _sprite;    
   
    public GameObjectPivot(GameObject gameObject, Uni2DSprite sprite) {
        this._go     = gameObject;
        this._sprite = sprite;
    }

    public float Left() {
        return this._go.transform.position.x - (this._sprite.SpriteSettings.SpriteWidth * .5f);
    }

    public float Right() {
        //return Camera.main.ScreenToWorldPoint(new Vector3(this._go.transform.position.x + this._sprite.SpriteSettings.SpriteWidth, this._go.transform.position.y + this._sprite.SpriteSettings.SpriteHeight, Camera.main.nearClipPlane));
        return this._go.transform.position.x + (this._sprite.SpriteSettings.SpriteWidth * .5f);
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

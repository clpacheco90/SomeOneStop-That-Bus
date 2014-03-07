using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReplaceBarrier : MonoBehaviour {

    public GameObject _rightObject;
    public GameObject _leftObject;
    public GameObjectPivot _gop;
    public GameObjectPivot _lgop;
    private CameraPivot _cp;

	public void Start () {
        this._gop = new GameObjectPivot(this.gameObject, this.gameObject.GetComponent<Uni2DSprite>());
        this._cp = new CameraPivot();
	}

    public void Join() {
        this._gop = new GameObjectPivot(this.gameObject, this.gameObject.GetComponent<Uni2DSprite>());
        if (_rightObject != null) {
            _rightObject.transform.position = new Vector3(this.gameObject.transform.position.x + _gop.Width(), _rightObject.transform.position.y, _rightObject.transform.position.z);
        }
        if (_leftObject != null) {
            _lgop = new GameObjectPivot(_leftObject, _leftObject.GetComponent<Uni2DSprite>());
        }
    }

	// Update is called once per frame
    public void Update() {
        //return;
        if (this._gop.Right() <= _cp._left.x) {
            if (_leftObject != null) {
                _lgop = new GameObjectPivot(_leftObject, _leftObject.GetComponent<Uni2DSprite>());
                this.transform.position = new Vector3(_leftObject.transform.position.x + _lgop.Width() , this.transform.position.y, this.transform.position.z);
            } else {
                this.transform.position = new Vector3(_cp._right.x + (_gop.Width() * .5f), this.transform.position.y, this.transform.position.z);
            }            
        }
    }
}

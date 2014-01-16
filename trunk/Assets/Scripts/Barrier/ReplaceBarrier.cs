using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReplaceBarrier : MonoBehaviour {

    public GameObject _rightObject;
    public GameObject _leftObject;
    public GameObjectPivot _gop;
    public GameObjectPivot _lgop;


	void Awake () {
        this._gop = new GameObjectPivot(this.gameObject, this.gameObject.GetComponent<Uni2DSprite>());
        if (_rightObject != null) {
            _rightObject.transform.position = new Vector3(this.gameObject.transform.position.x + _gop.Width(), _rightObject.transform.position.y, _rightObject.transform.position.z);
        }
        if (_leftObject != null) {
            _lgop = new GameObjectPivot(_leftObject, _leftObject.GetComponent<Uni2DSprite>());
        }
	}
	
	// Update is called once per frame
	public virtual void Update () {
        //return;
        if (this._gop.Right() <= CameraPivot.Left().x) {            
            //! this works
            if (_leftObject != null) {
                _lgop = new GameObjectPivot(_leftObject, _leftObject.GetComponent<Uni2DSprite>());
                this.transform.position = new Vector3(_leftObject.transform.position.x + _lgop.Width(), this.transform.position.y, this.transform.position.z);
            } else {
                this.transform.position = new Vector3(CameraPivot.Right().x + (_gop.Width() * .5f), this.transform.position.y, this.transform.position.z);
            }
            //? Need test
            //if (transform.tag.Equals("Trash")) {
            //    System.Random r = new System.Random();
            //    this.transform.position = new Vector3(this.transform.position.x + (_bX * _numberOfForwardObjects) + r.Next(1, 7), this.transform.position.y, this.transform.position.z);
            //    this.transform.rotation = new Quaternion(0, 0, 0, 0);
            //}
            //_instance = Instance.New;
        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReplaceObjectManager : MonoBehaviour {

    public Transform[] _childrens;
    [HideInInspector]
    public bool _flagOutside;

    public class GameObjectChildren {
        public GameObject GameObject { get; set; }
        public GameObjectPivot GameObjectPivot { get; set; }
    }

    public List<GameObjectChildren> _gameObjectChild = new List<GameObjectChildren>();


	// Use this for initialization
	public void Awake () {
        _childrens = new Transform[this.gameObject.transform.childCount];
        for (int i = 0; i < this.gameObject.transform.childCount; i++) _childrens[i] = this.gameObject.transform.GetChild(i);

        for (int i = 0; i < this.gameObject.transform.childCount; i++) {
            var replaceBarrier = _childrens[i].GetComponent<ReplaceBarrier>();
            if (i < this.gameObject.transform.childCount - 1 && i > 0) {
                replaceBarrier._leftObject = _childrens[i - 1].gameObject;
                replaceBarrier._rightObject = _childrens[i + 1].gameObject;
            } else if (i == 0) {
                replaceBarrier._leftObject = _childrens[this.gameObject.transform.childCount - 1].gameObject;
                replaceBarrier._rightObject = _childrens[i + 1].gameObject;
            } else if (i == this.gameObject.transform.childCount - 1) {
                replaceBarrier._leftObject = _childrens[i - 1].gameObject;
                replaceBarrier._rightObject = _childrens[0].gameObject;
            }
        }
	}	
}

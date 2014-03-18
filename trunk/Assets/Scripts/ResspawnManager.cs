using UnityEngine;
using System.Collections;

public class ResspawnManager : MonoBehaviour {

    [System.NonSerialized]public bool initializePrefab = true;
    public GameObject[] levels;
	// Use this for initialization
	void Start () {
        CameraPivot c = new CameraPivot();
        this.transform.position = new Vector3(c._right.x,this.transform.position.y,this.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.CurrentGameState != GameManager.GameState.OnGame) return;
        if (initializePrefab) {
            GameObject go = (GameObject)Instantiate(levels[0]);
            go.transform.parent = this.transform;
            initializePrefab = false;
        }
	}
}

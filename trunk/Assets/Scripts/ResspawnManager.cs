using UnityEngine;
using System.Collections;

public class ResspawnManager : MonoBehaviour {

    /*[System.NonSerialized]*/public bool initializePrefab = true;
    public GameObject[] levels;

    private byte nol;
    private byte rand;
    private byte auxRand;
	// Use this for initialization
	void Start () {
        CameraPivot c           = new CameraPivot();
        this.transform.position = new Vector3(c._right.x,this.transform.position.y,this.transform.position.z);
        nol                     = System.Convert.ToByte(levels.Length);
        rand                    = System.Convert.ToByte(Random.Range(0, nol));
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.CurrentGameState != GameManager.GameState.OnGame) return;
        
        if (initializePrefab) {            
            GameObject go       = (GameObject)Instantiate(levels[rand]);
            go.transform.parent = this.transform;
            initializePrefab    = false;
            auxRand             = System.Convert.ToByte(Random.Range(0, nol));
            rand                = (rand == auxRand) ? System.Convert.ToByte(Random.Range(0, nol)) : auxRand; // Give one more chance to random a number;
        }
	}
}

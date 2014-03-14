using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

    private GameObject[] blocks;
    private bool initializeMovement = true;
	// Use this for initialization
	void Start () {
        blocks = GameObject.FindGameObjectsWithTag("Block");
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.CurrentGameState != GameManager.GameState.OnGame) return;
        if (initializeMovement) {
            foreach (GameObject b in blocks) {
                b.SetActive(true);
            }
            initializeMovement = false;
        }
        

	}
}

using UnityEngine;
using System.Collections;

public class PlayerSound : MonoBehaviour {

    public AudioSource _jump;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.CurrentGameState == GameManager.GameState.OnGame) {
            if (Input.GetButtonDown("Jump")) _jump.Play();  
        }
	}
}

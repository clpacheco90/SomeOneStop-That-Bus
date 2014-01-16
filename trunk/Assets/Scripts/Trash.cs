using UnityEngine;
using System.Collections;

public class Trash : MonoBehaviour {

    public AudioSource _clip;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D(Collision2D c) {
        if (c.gameObject.CompareTag("Player")) {
            c.gameObject.transform.position = new Vector3(Mathf.Lerp(c.gameObject.transform.position.x, c.gameObject.transform.position.x - .5f, 10), c.gameObject.transform.position.y, c.gameObject.transform.position.z);
            GameManager.EnvironmentSpeedSmoothing = 2;
            
            _clip.Play();
            //NGUIDebug.Log("HIT");
        }
    }

}

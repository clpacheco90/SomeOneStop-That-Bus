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

    void OnTriggerEnter(Collider c) {
        if (c.CompareTag("Player")) {
            c.gameObject.transform.position = new Vector3(Mathf.Lerp(c.gameObject.transform.position.x, c.gameObject.transform.position.x - .5f, 10), c.gameObject.transform.position.y, c.gameObject.transform.position.z);
            _clip.Play();
            //NGUIDebug.Log("HIT");
        }
    }

}

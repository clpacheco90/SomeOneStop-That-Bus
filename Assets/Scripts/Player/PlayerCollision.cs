using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public int numberOfHits = 1;

	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
        if (numberOfHits > 0) return;
        GameManager.CurrentGameState = GameManager.GameState.Lose;
	}

    //void OnCollisionEnter(Collision collision) {
    //    if (!collision.gameObject.CompareTag("Block")) return;
    //    numberOfHits--;
    //}

    void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Block")) return;
        numberOfHits--;
    }

    //void OnControllerColliderHit(ControllerColliderHit hit) {
    //    if (!hit.gameObject.CompareTag("Block")) return;
    //    //this.gameObject.transform.position += new Vector3(this.gameObject.transform.position.x + 3, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    //    numberOfHits--;
    //}

}

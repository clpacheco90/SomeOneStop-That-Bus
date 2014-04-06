using UnityEngine;
using System.Collections;

public class RespawnCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
        CameraPivot c = new CameraPivot();
        this.transform.position = new Vector3(c._left.x, this.transform.position.y, this.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("EndZone")) return;
        Destroy(other.gameObject.transform.parent.gameObject);
        this.gameObject.transform.parent.gameObject.GetComponent<ResspawnManager>().initializePrefab = true;
        //GetComponent<ResspawnManager>().initializePrefab = true;

    }
}

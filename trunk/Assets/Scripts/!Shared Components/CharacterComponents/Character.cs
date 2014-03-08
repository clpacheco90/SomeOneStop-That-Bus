using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
//-----------------------------------------------------------------------------------------------------------------------------//
    public bool _godMode;
    public int _live = 3;
    public ControllerMovement _movement = new ControllerMovement();
    public ControllerJumping _jump      = new ControllerJumping();

    private GameObject _respawnPoint;
//-----------------------------------------------------------------------------------------------------------------------------//
	public virtual void Awake () {
	}
//-----------------------------------------------------------------------------------------------------------------------------//
	public virtual void Start () {
		//Debug.Log("Start >> " + this.gameObject.name);
        //_respawnPoint = GameObject.FindGameObjectWithTag("Respawn");
	}
//-----------------------------------------------------------------------------------------------------------------------------//
	public virtual void Update () {
        GOD_MODE_OFF();
	}	
//-----------------------------------------------------------------------------------------------------------------------------//
	public virtual void FixedUpdate(){
		//if(Vector3.Distance(transform.position, spawn.transform.position < spawnRadius){
		//}
	}	
//-----------------------------------------------------------------------------------------------------------------------------//
	public virtual void OnTriggerStay(Collider other){		
		//Debug.DrawLine(this.transform.position,other.transform.position,Color.red);
	}
//-----------------------------------------------------------------------------------------------------------------------------//
	public virtual void OnTriggerExit(Collider other){
		//Debug.Log(other.name);
        //if (other.tag.Equals("Enemy")){
        //    _live--;
        //}
	}	
//-----------------------------------------------------------------------------------------------------------------------------//
	public virtual void OnTriggerEnter(Collider other){				
	}	
//-----------------------------------------------------------------------------------------------------------------------------//
    public void IsHit() {
        _live = 0;
    }
//-----------------------------------------------------------------------------------------------------------------------------//
    private void GOD_MODE_OFF() {
        if (_godMode) return;             
        if (_live <= 0) {
            Debug.Log(gameObject.name + "is DEAD");
            gameObject.transform.position = _respawnPoint.transform.position;
            _live = 3;
        }
    }
//-----------------------------------------------------------------------------------------------------------------------------//
}
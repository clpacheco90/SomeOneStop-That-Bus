using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {
    //-----------------------------------------------------------------------------------------------------------------------------//	
	public CharacterController _characterController;
    public ControllerMovement _controllerMovement = new ControllerMovement();
	public ControllerJumping _controllerJumping   = new ControllerJumping();
    //-----------------------------------------------------------------------------------------------------------------------------//	
	delegate void Controllers(ControllerMovement cm, ControllerJumping cj, CharacterController cc);
	private Controllers controllers;
    //-----------------------------------------------------------------------------------------------------------------------------//	
	void Awake () {	
		this._characterController = this.gameObject.GetComponent<CharacterController>();
        controllers              += CharacterMovement.GravityMovementX;
        controllers              += CharacterMovement.ApplyGravity;
        controllers              += CharacterMovement.ApplyJumping;
		controllers              += CharacterMovement.RefreshMovement;
	}
    //-----------------------------------------------------------------------------------------------------------------------------//	
	void Update () {
        //NGUIDebug.Log(_controllerMovement.direction.ToString());        
        //Debug.Log(PlayerController.IsTapping() && CharacterMovement.IsMoving());
		controllers(_controllerMovement,_controllerJumping,_characterController);
	}
    //-----------------------------------------------------------------------------------------------------------------------------//	
	void FixedUpdate(){
        _controllerMovement.direction = Vector3.zero;
		_controllerMovement.transform = transform;
	}
}

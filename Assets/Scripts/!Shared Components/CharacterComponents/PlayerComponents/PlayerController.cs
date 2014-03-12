using UnityEngine;
using System.Collections;

public class PlayerController : Character  {
//-----------------------------------------------------------------------------------------------------------------------------//		
	public bool _canControl = true; //If false, you can't control the player
	private CharacterController _controller;
    private float _extraHeightAux;
    private float _gravityAux;
//-----------------------------------------------------------------------------------------------------------------------------//	
	public override void Awake () {
		_movement.direction = this.transform.TransformDirection (Vector3.right);		
		_controller 		= this.GetComponent<CharacterController>();
		_movement.transform = this.gameObject.transform;
        _extraHeightAux     = _jump.extraHeight;
        _gravityAux         = _movement.gravity;
		base.Awake();
	}
//-----------------------------------------------------------------------------------------------------------------------------//			
    public override void Update() {
		//Debug.Log( "On the ground: " + controller.isGrounded );
        _movement.transform.position = new Vector3(_movement.transform.position.x, _movement.transform.position.y, _movement.transform.position.z);
		CharacterMovement.UpdateSmoothedMovementDirection(ref _movement,_jump,_controller,_canControl);
		CharacterMovement.ApplyGravity(ref _movement,ref _jump, _controller, _canControl);
		CharacterMovement.ApplyJumping(ref _movement, ref _jump, _controller,_canControl);		
		var lastPosition          = transform.position;                                                                             // Save lastPosition for velocity calculation.
		var currentMovementOffset = (_movement.direction * _movement.speed) + (new Vector3 (0.0f, _movement.verticalSpeed, 0.0f));  // Calculate actual motion
        currentMovementOffset    *= Time.smoothDeltaTime;                                                                           // We always want the movement to be framerate independent.  Multiplying by Time.smoothDeltaTime does this.
		_movement.slideX          = 0.0f;			   
	   	_movement.collisionFlags  = _controller.Move(currentMovementOffset);				
        _movement.velocity        = (transform.position - lastPosition) / Time.smoothDeltaTime;        

        DefaultSettings();
		base.Update();
    }	
//-----------------------------------------------------------------------------------------------------------------------------//		
    public void DefaultSettings() {
        if (!_controller.isGrounded) return;
        _jump.extraHeight = _extraHeightAux;
        _movement.gravity = _gravityAux;
        _movement.direction = Vector3.zero;

    }
//-----------------------------------------------------------------------------------------------------------------------------//		
}
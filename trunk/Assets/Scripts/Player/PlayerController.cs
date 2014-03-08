﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {
    //-----------------------------------------------------------------------------------------------------------------------------//	
    public CharacterController character;
    public ControllerMovement movement;
    public ControllerJumping jump;
    //delegate void Controllers(ControllerMovement m, ControllerJumping j, CharacterController c);
    delegate void Controllers(ControllerMovement m, ControllerJumping j, CharacterController c);
	private Controllers _controllers;
    //-----------------------------------------------------------------------------------------------------------------------------//	
	void Awake () {
        _controllers += CharacterMovement.GravityMovementX;
        _controllers += CharacterMovement.ApplyJumping;
        _controllers += CharacterMovement.ApplyGravity;
		_controllers += CharacterMovement.RefreshMovement;
	}
    //-----------------------------------------------------------------------------------------------------------------------------//	
	void Update () {
        //NGUIDebug.Log(_controllerMovement.direction.ToString());
	}
    //-----------------------------------------------------------------------------------------------------------------------------//	
	void FixedUpdate(){
        //_controllers(_character2D.Movement, _character2D.Jump, _character2D.Controller);
        _controllers(movement,jump,character);
	}
    //-----------------------------------------------------------------------------------------------------------------------------//	

}
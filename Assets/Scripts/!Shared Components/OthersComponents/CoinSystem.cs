using UnityEngine;
using System.Collections;

public class CoinSystem : MonoBehaviour {

    public int _currentScore;
    //public int _maxScore = 50; // The maximum score that the player will get
	public GUIStyle _gui;
    private bool _achievement;
//-----------------------------------------------------------------------------------------------------------------------------//			
	void Start () {
        CheckAllTheCoinsInTheScene();
	}
//-----------------------------------------------------------------------------------------------------------------------------//				
	void Update () {
        //if (_currentScore == _maxScore) {
        //    //Debug.Log("You Collected all Buzios");
        //    _achievement = true; // Unlock the archiviment
        //}
	}
//-----------------------------------------------------------------------------------------------------------------------------//		
    private void CheckAllTheCoinsInTheScene() {
        //var coins = GameObject.FindGameObjectsWithTag("Coin");
        //if (coins.Length != _maxScore) Debug.LogError("Incorrect numbers of coins. Put or remove to get a correc number of coins");        
    }
//-----------------------------------------------------------------------------------------------------------------------------//		
    void OnGUI() {
        //GUI.color = Color.blue;
        GUILayout.Label("Búzios " + _currentScore,_gui);
        if (!_achievement) return;
        //GUILayout.Label("Você desbloqueou um extra",_gui);
    }
//-----------------------------------------------------------------------------------------------------------------------------//		
}

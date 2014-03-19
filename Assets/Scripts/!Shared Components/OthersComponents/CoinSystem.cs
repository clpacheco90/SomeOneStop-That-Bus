using UnityEngine;
using System.Collections;

public class CoinSystem : MonoBehaviour {

    public int _currentScore;
    //public int _maxScore = 50; // The maximum score that the player will get
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
        this.gameObject.guiText.text = "score:" + _currentScore.ToString();
	}
//-----------------------------------------------------------------------------------------------------------------------------//		
    private void CheckAllTheCoinsInTheScene() {
        //var coins = GameObject.FindGameObjectsWithTag("Coin");
        //if (coins.Length != _maxScore) Debug.LogError("Incorrect numbers of coins. Put or remove to get a correc number of coins");        
    }
//-----------------------------------------------------------------------------------------------------------------------------//		
    void OnGUI() {
        if (!_achievement) return;
        //GUILayout.Label("Você desbloqueou um extra",_gui);
    }
//-----------------------------------------------------------------------------------------------------------------------------//		
}

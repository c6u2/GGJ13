using UnityEngine;
using System.Collections;

public class TestEnemyScript : MonoBehaviour {
	public EnemyColliderPropigator playerDetector;
	
	// Use this for initialization
	void Start () {
		playerDetector.CollisionPropigate = OnDetectedPlayer;
	}
	
	void OnDetectedPlayer(bool foundPlayer)
	{
		
		if(foundPlayer){
			Debug.LogError ("Found player");
			//seek out player for ... pinging
		}else{
			Debug.LogError ("lost player");
			//we lost player, wander around again
		}
		
	}
}

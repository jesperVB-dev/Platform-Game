using UnityEngine;
using System.Collections;

public class groundedManager : MonoBehaviour {

	public playerController player;

	void OnTriggerEnter2D(Collider2D col){
		player.possibleJump = true;
	}
}

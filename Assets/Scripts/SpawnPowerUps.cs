using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUps : MonoBehaviour {

	public GameObject powerUp;
	public Color gizmosColor;
	public Vector3 boxSize;

	void Start(){
		for (int i = 0; i < 10; i++) {
			SpawnPowerUp ();
		}
	}
	public void SpawnPowerUp(){
		Instantiate (powerUp, RandomPosition (), Quaternion.identity);
	}

	void OnDrawGizmosSelected(){
		Gizmos.color = gizmosColor;
		Gizmos.DrawCube (transform.position, boxSize);
	}
	Vector3 RandomPosition(){
		float x = Random.Range (boxSize.x / -2, boxSize.x / 2);
		float z = Random.Range (boxSize.z / -2, boxSize.z / 2);
		Vector3 futurePos = new Vector3 (x, 1, z);
		Collider[] colliders = Physics.OverlapSphere (futurePos, 1);
		return new Vector3 (x, 1, z);
	}
}

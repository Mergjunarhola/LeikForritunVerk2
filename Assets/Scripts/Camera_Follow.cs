using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

	// Use this for initialization
	public Transform player;
	public Vector3 Offset;
	
	// Update is called once per frame
	private void Update() {
		transform.position=player.position +Offset;
	}
}

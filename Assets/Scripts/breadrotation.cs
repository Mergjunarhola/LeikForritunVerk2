
using UnityEngine;

public class breadrotation : MonoBehaviour {
	// Update is called once per frame
	public Transform tr;
	void FixedUpdate() {
		
		tr.Rotate(0,3,0);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	public Rigidbody rb;
	public float Hradi =550;
	public float Hopp=500;
	public float grav=10;
	private bool flag=true;
	private bool flag2=false;
	private int rot=0;
	private Vector3 Noter;
	void Start () {
		Debug.Log("Hello");
		
	}
	void OnCollisionEnter(Collision CollisionInfo) {
		flag=false;
	}
	// Update is called once per frame
	private void FixedUpdate() {
		Noter=rb.velocity;
		if (flag){
			rb.AddForce(0,-grav,0);
		}
		if (Input.GetKey("d")) {
			rb.velocity=new Vector3(Hradi*Time.fixedDeltaTime,Noter.y,0);}
		else if (Input.GetKey("a")) {
			rb.velocity=new Vector3(-Hradi*Time.fixedDeltaTime,Noter.y,0);}
		else
		{
			rb.velocity=new Vector3(0,Noter.y,0);}
		if (Input.GetKeyDown("space") && !flag){
			flag=true;
			rb.AddForce(0,Hopp,0);
		}
		else if (Input.GetKeyDown("space") && flag && !flag2){
			flag2=true;
			rb.AddForce(0,Hopp,0);
		}
		if (flag2){
			if (rot<360){
				rb.MoveRotation(Quaternion.Euler(new Vector3(rot,90,0)));
				rot+=13;
			}
			else
			{
				rb.MoveRotation(Quaternion.Euler(new Vector3(0,90,0)));
				rot=0;
				flag2=false;
			}
		}
	} 
}


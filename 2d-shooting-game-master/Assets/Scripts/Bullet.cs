using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int speed = 5;
	
	// Update is called once per frame
	void Update () {
		this.BulletMove();
	}

	void BulletMove(){
		GetComponent<Rigidbody2D> ().velocity = transform.up.normalized * speed;
	}
}

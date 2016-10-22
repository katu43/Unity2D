	using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// 移動スピード
	public float speed = 5;
	
	// Update is called once per frame
	void Update () {

		// 移動
		inputKey();
	
	}

	void inputKey(){
		// 左右
		float x = Input.GetAxisRaw("Horizontal");

		// 上下
		float y = Input.GetAxisRaw("Vertical");

		// 移動する向きを求める
		Vector2 direction = new Vector2(x, y).normalized;

		// 移動する向きとスピードを代入
		GetComponent<Rigidbody2D>().velocity = direction * this.speed;
	}
}

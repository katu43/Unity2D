	using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// 移動スピード
	public float speed = 5;

	// PlayerBullet
	public GameObject bullet;

	// Startメソッドをコルーチンとして呼び出す
	IEnumerator Start(){

		while (true) {
			// 玉をプレイヤーと同じ位置と角度で作成
			Instantiate(bullet, transform.position, transform.rotation);

			// 0.05秒待つ
			yield return new WaitForSeconds(1);
		}
	}
	
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

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Spaceshipコンポーネント
	Spaceship spaceship;

	// Startメソッドをコルーチンとして呼び出す
	IEnumerator Start(){

		// Spaceshipコンポーネントを取得する
		spaceship = GetComponent<Spaceship>();

		while (true) {
			// 玉をプレイヤーと同じ位置と角度で作成
			spaceship.Shot(transform);

			// 0.05秒待つ
			yield return new WaitForSeconds(spaceship.shotDelay);
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
		spaceship.Move(direction);
	}
}

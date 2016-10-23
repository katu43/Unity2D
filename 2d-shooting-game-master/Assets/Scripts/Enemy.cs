using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Spaceshipコンポーネント
	Spaceship spaceship;

	// Use this for initialization
	IEnumerator Start () {

		// Spaceshipコンポーネントを取得
		spaceship = GetComponent<Spaceship>();

		// ローカル座標のY軸のマイナス方向に移動
		spaceship.Move(transform.up * -1);

		// canShotがfalseの場合は処理を終了させる
		if (!spaceship.canShot) {
			yield break;
		}

		while (true) {
			// 子要素をすべて取得する
			for (int i = 0; i < transform.childCount; i++) {

				Transform shotPositon = transform.GetChild (i);

				// ShotPositionの位置/角度で弾を打つ
				spaceship.Shot(shotPositon);
			}

			// shotDelay秒待つ
			yield return new WaitForSeconds(spaceship.shotDelay);
		}
	}
}

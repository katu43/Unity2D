﻿using UnityEngine;
using System.Collections;

//Rigidbody2Dコンポーネントを必須にする
[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour {

	// 移動スピード
	public float speed;

	// 玉を打つ間隔
	public float shotDelay;

	// 弾のプレハブ
	public GameObject bullet;

	// 弾を打つかどうか
	public bool canShot;

	// 弾の作成
	public void Shot(Transform origin){
		Instantiate (bullet, origin.position, origin.rotation);
	}

	// 機体の移動
	public void Move(Vector2 direction){
		GetComponent<Rigidbody2D> ().velocity = direction * speed;
	}
}

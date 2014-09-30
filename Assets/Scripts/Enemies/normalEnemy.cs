using UnityEngine;
using System.Collections;

public class normalEnemy : Enemy {

	void Start() 
	{
		enemyType = EnemyType.Normal;
		health = 2;
	}

	void Update() 
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}

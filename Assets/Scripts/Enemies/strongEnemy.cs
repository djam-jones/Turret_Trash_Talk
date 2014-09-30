using UnityEngine;
using System.Collections;

public class strongEnemy : Enemy {

	void Start() 
	{
		enemyType = EnemyType.Strong;
		health = 4;
		speed = 2;
	}

	void Update() 
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}

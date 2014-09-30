using UnityEngine;
using System.Collections;

public class fastEnemy : Enemy {
	
	void Start() 
	{
		enemyType = EnemyType.Fast;
		health = 1;
		speed = 4;
	}

	void Update() 
	{
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}

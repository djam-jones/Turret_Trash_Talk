using UnityEngine;
using System.Collections;

public class SpawnEnemies:MonoBehaviour {
	
	public Transform[] enemies;
	public Transform[] spawns;
	
	private float randomEnemy;
	public float timer = 2.0f;
	public bool spawning = false;
	
	void Update()
	{
		if(spawning)
		{
			timer += Time.deltaTime;
		}
		if(randomEnemy <= timer)
		{
			Spawn();
		}
		randomEnemy = Random.Range(0, 144);
	}
	
	void Spawn()
	{
		spawning = true;
		int spawnIndex = Random.Range(0, spawns.Length);
		int enemyIndex = Random.Range(0, enemies.Length);
		Instantiate(enemies[enemyIndex], spawns[spawnIndex].position, Quaternion.identity);
		timer = 0f;
	}
}
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class LookAtEnemy : MonoBehaviour {

	private GameObject target;
	public static List<Transform> inRange = new List<Transform>();
	public float rotationSpeed;

	private string enemyID;


	void Update()
	{
		if(inRange.Count > 0)
		{
		//	inRange.Sort(SortByName);
			//inRange.Sort ();
			Vector3 relativePos = inRange[0].transform.position - transform.position;
			Quaternion enemyLookAt = Quaternion.LookRotation(relativePos);
			this.transform.rotation = Quaternion.Slerp(transform.rotation, enemyLookAt, Time.deltaTime * rotationSpeed);
			//transform.LookAt(inRange[0].transform.position);

		}

	/*	switch(EnemyType) 
		{
		case Enemies.aStrong:
			enemyID = "STRONG";
			break;
		case Enemies.bFast:
			enemyID = "FAST";
			break;
		case Enemies.cNormal:
			enemyID = "NORMAL";
			break;
		}
	*/
	}

/*	private static int SortByName(Transform aStrong, Transform bFast, Transform cNormal)
	{
		//return aStrong.name.CompareTo(bFast.name);
	}
*/	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "EnemyNormal")
		{
			inRange.Add(other.GetComponent<Enemy>());
			Shoot.isActive = true;
		}
		else if(other.tag == "EnemyFast")
		{
			inRange.Add(other.GetComponent<Enemy>());
			Shoot.isActive = true;
		}
		else if(other.tag == "EnemyStrong")
		{
			inRange.Add(other.GetComponent<Enemy>());
			Shoot.isActive = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Enemy")
		{
			inRange.Remove(other.gameObject);
			Shoot.isActive = false;
		}

		if(other.tag == null)
		{
			inRange.Remove(other.gameObject);
			Shoot.isActive = false;
		}
	}
}
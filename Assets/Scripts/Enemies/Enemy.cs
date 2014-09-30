using UnityEngine;
using System.Collections;
using System;

public enum EnemyType
{
	Strong,
	Fast,
	Normal
}

public class Enemy : MonoBehaviour, IComparable<Transform> {

	public float speed = 3;
	public int health;

	public EnemyType enemyType;

	public Transform myTransform;

	void Start()
	{
		myTransform = this.transform;
	}

	void Update()
	{
		Debug.Log("Health: " + health + " and " + "Speed: " + speed);
	}

	public int CompareTo(Transform other)
	{
		return other.name.CompareTo(this.transform.name);
	}
}
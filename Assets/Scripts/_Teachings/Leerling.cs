﻿using UnityEngine;
using System.Collections;

public enum Gender
{
	Male,
	Female
}

public class Leerling{

	public string name;
	private int age;

	private Gender gender;

	public Leerling(string _name, int _age, Gender _gender)
	{
		name = _name;
		age = _age;
		gender = _gender;
	}

}

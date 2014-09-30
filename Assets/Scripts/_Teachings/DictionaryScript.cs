using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DictionaryScript : MonoBehaviour {

	private Dictionary<string, List<Leerling>> klas = new Dictionary<string, List<Leerling>>();

	void Start()
	{
		Leerling student = new Leerling("Henk", 19, Gender.Male);
		Leerling student2 = new Leerling("Lisanne", 18, Gender.Female);

		List<Leerling> studentList = new List<Leerling>();
		studentList.Add(student);
		studentList.Add(student2);

		klas.Add("GD2", studentList);

		//Debug.Log(klas["GD2"]);
	}
}

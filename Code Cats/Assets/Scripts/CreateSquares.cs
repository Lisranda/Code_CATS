using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSquares : MonoBehaviour {
	[SerializeField]
	GameObject squarePrefab;
	[SerializeField]
	int numberOfSquares = 6;

	void Start () {
		for (int i = 0; i < numberOfSquares; i++) {
			GameObject go = Instantiate (squarePrefab, gameObject.transform);
			go.name = "Square " + i;
		}
	}
}

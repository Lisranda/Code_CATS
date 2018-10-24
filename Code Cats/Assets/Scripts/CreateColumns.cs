using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateColumns : MonoBehaviour {
	[SerializeField]
	GameObject columnPrefab;
	[SerializeField]
	int numberOfColumns = 6;

	void Start () {
		for (int i = 0; i < numberOfColumns; i++) {
			GameObject go = Instantiate (columnPrefab, gameObject.transform);
			go.name = "Column " + i;
		}
	}
}

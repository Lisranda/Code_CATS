using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Column : MonoBehaviour {
	RectTransform rectTransform;
	PlayArea playArea;
	VerticalLayoutGroup layoutGroup;

	void Awake () {
		playArea = FindObjectOfType<PlayArea> ();

		rectTransform = GetComponent<RectTransform> ();
		layoutGroup = GetComponent<VerticalLayoutGroup> ();
	}

	void Start () {
		float columnWidth = (playArea.Width - ((playArea.NumberOfColumns + 1f) * playArea.Spacing)) / playArea.NumberOfColumns;
		float columnHeight = playArea.Height - (2 * layoutGroup.spacing);
		rectTransform.sizeDelta = new Vector2 (columnWidth, columnHeight);
	}


}

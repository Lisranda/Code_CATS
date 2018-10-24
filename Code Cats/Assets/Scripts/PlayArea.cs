using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayArea : MonoBehaviour {
	public float Width { get; private set; }
	public float Height { get; private set; }
	public float Spacing { get; private set; }

	public int NumberOfColumns { get; private set; }
	public int NumberOfRows { get; private set; }

	RectTransform rectTransform;
	HorizontalLayoutGroup layoutGroup;


	void Awake () {
		rectTransform = GetComponent<RectTransform> ();
		layoutGroup = GetComponent<HorizontalLayoutGroup> ();

		NumberOfColumns = 6;
		NumberOfRows = 6;
	}

	void Start () {		
		Width = rectTransform.rect.width;
		Height = rectTransform.rect.height;
		Spacing = layoutGroup.spacing;

		Debug.Log (Width + " x " + Height);
	}
}

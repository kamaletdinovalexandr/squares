using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour {

	public Vector2 Size;
	public Vector2 Position;
	public RectTransform SquareRect { get; private set; }

	private void Start() {
		SquareRect = GetComponent<RectTransform>();
		Size = SquareRect.sizeDelta;
	}

	public void ApplyParameters() {
		SquareRect.anchoredPosition = Position;
		SquareRect.sizeDelta = Size;
	}
}


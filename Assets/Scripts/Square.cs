using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square {

	public GameObject View { get; private set; }
	public Vector2Int Position { get; private set; }
	public Vector2Int Size { get; set; }
	public Color SquareColor { get; private set; }

	public Square(GameObject view, Vector2Int position, Color color) {
		View = view;
		Position = position;
		SquareColor = color;
	}
}


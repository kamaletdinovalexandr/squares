using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour {

	public Vector2Int Position { get; private set; }
	public Color SquareColor { get; private set; }
	public int HorizontalSize { get; set; }
	public int VerticalSize { get; set; }
	public List<Square> NestedSquares = new List<Square>();

	public Square(Vector2Int position, Color color) {
		Position = position;
		SquareColor = color;
	}
}


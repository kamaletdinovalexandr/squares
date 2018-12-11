using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class SquareController : MonoBehaviour {
	
	[SerializeField] 
	private GridManager _gridManager;
    private List<Square> _squares = new List<Square>();
	private Square _selectedSquare;

	private void Start() {
		InitBackground();
	}

	private void InitBackground() {
		for (int i = 0; i < Globals.GridWidth; i++) {
			for (int j = 0; j < Globals.GridHeight; j++) {
				_gridManager.SpawnAt(new Vector2Int(i, j), Globals.BackColor);
			}
		}	
	}


	private void MakeSquare() {
		var position = RandomPicker.GetPosition(0, Globals.GridWidth);
		var color = RandomPicker.GetColor();
		var cell = new Square(position, color);
		_squares.Add((cell));
	}

}
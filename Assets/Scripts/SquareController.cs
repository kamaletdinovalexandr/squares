using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour {

	[SerializeField] private GameObject _squareCellPrefab;
	[SerializeField] private GameManager _gameController;

	private List<Square>[,] _squares = new List<Square>[Globals.GridWidth,Globals.GridHeight];
	private Square _selectedSquare;

	public void InitBoard() {
		for (int i = 0; i < Globals.GridWidth; i++) {
			for (int j = 0; j < Globals.GridHeight; j++) {
				SpawnAt(new Vector2Int(i, j), Globals.BackColor, false);
			}
		}
	}

	public void MakeRandomSquare() {
		var randomPosition = RandomPicker.GetPosition();
		var randomColor = RandomPicker.GetColor();
		SpawnAt(randomPosition, randomColor);
	}

	public void SpawnAt(Vector2Int position, Color color, bool addToList = true) {
		var cellView = Instantiate(_squareCellPrefab, GridToWorld(position), Quaternion.identity);
		var cell = new Square(cellView, position, color);
		cellView.transform.SetParent(this.transform);
		if (addToList) {
			if (_squares[position.x, position.y] == null)
				_squares[position.x, position.y] = new List<Square>();
			_squares[position.x, position.y].Add(cell);
		}
	}

	public Vector2 GridToWorld(Vector2Int gridPosition) {
		var gridX = gridPosition.x + gridPosition.x * Globals.Offset;
		var gridY = gridPosition.y + gridPosition.y * Globals.Offset;
		return new Vector2(gridX, gridY);
	}

	public Vector2Int WorldToGrid(Vector2 worldPosition) {
		var gridX = (int)(worldPosition.x / Globals.Offset - worldPosition.x);
		var gridY = (int)(worldPosition.y / Globals.Offset - worldPosition.y);
		return new Vector2Int(gridX, gridY);
	}

}
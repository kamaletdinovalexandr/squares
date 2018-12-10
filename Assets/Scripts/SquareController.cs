using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class SquareController : MonoBehaviour {

	private float _fieldSize;
	private float _squareSize;
	
	[SerializeField] 
	private FieldManager _fieldManager;
	private SquareStratcher _squareStretcher;
    private List<Square> _squares = new List<Square>();
	private Square _currentSquare;

	private void Start() {
		_fieldSize = 500f;
		_squareSize = _fieldSize / 4f;
		MakeSquare();	
	}

	private void Update() {
		if (Input.GetKeyDown((KeyCode.DownArrow)))
			StretchCurrentSquare(Vector2.down);
		
		if (Input.GetKeyDown((KeyCode.UpArrow)))
			StretchCurrentSquare(Vector2.up);
		
		if (Input.GetKeyDown((KeyCode.LeftArrow)))
			StretchCurrentSquare(Vector2.left);
		
		if (Input.GetKeyDown((KeyCode.RightArrow)))
			StretchCurrentSquare(Vector2.right);
	}

	private void MakeSquare() {
		var position = RandomPicker.GetPosition(_squareSize, _fieldSize - _squareSize);
		var cell =_fieldManager.SpawnAt(position, RandomPicker.GetColor());
		cell.Position = position;
		cell.Size = new Vector2(_squareSize, _squareSize);
		_squares.Add((cell));
		_currentSquare = cell;
	}

	private void StretchCurrentSquare(Vector2 direction) {
		foreach (var square in _squares) {
			if (direction == Vector2.left) {
				var targetPositionX = 0f;
				var newWidth = _currentSquare.Position.x + _currentSquare.Size.x;
				if (
					square.Position.x + square.Size.x / 2 < _currentSquare.Position.x - _currentSquare.Size.x / 2
					&& square.Position.y + square.Size.y / 2 < _currentSquare.Position.y + _currentSquare.Size.y / 2
					&& square.Position.y - square.Size.y / 2 > _currentSquare.Position.y - _currentSquare.Size.y / 2
					) {
					Debug.Log("found");
					var delta = _currentSquare.Position.x - _currentSquare.Size.x / 2 - square.Position.x +
					            square.Size.x / 2;
					targetPositionX =  (_currentSquare.Position.x - delta) / 2;
					newWidth = _currentSquare.Size.x + delta;
				}
				
				_currentSquare.Position.x = targetPositionX;
				_currentSquare.Size.x = newWidth;
				
			}
			else if (direction == Vector2.right) {
				var targetWidth = _fieldSize - _currentSquare.Position.x;
				_currentSquare.Size.x = targetWidth;
			}

			else if (direction == Vector2.up) {
				var targetHeight = _fieldSize - _currentSquare.Position.y;
				_currentSquare.Size.y = targetHeight;
			}

			else if (direction == Vector2.down) {
				var targetPositionY = 0f;
				var newHeight = _currentSquare.Position.y + _currentSquare.Size.y;
				_currentSquare.Position.y = targetPositionY;
				_currentSquare.Size.y = newHeight;
			}
		}
		_currentSquare.ApplyParameters();
		MakeSquare();
	}

	
}
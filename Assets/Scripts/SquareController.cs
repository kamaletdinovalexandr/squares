using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour {
	
	[SerializeField] FieldManager _fieldManager;
	private readonly Vector2 _fieldSize = new Vector2(500f, 500f);
	private readonly float SquareSize = 250;
    private List<Square> _squares;
    private int _minimalSize;
    private SquareStratcher _squareStratcher;
	private RandomPicker _picker = new RandomPicker();
	private Vector2 _offset;

	private void Start() {
		_offset = new Vector2(SquareSize / 4, -1 * SquareSize / 4);
		_fieldManager.SpawnAt(Vector2.zero , _offset ,_picker.GetColor());
		_fieldManager.SpawnAt(Vector2.right, _offset, _picker.GetColor());
		_fieldManager.SpawnAt(Vector2.down, _offset, _picker.GetColor());
		_fieldManager.SpawnAt(Vector2.right + Vector2.down, _offset, _picker.GetColor());
	}

	internal void MakeSquare(Vector2 pos) { }
    internal void TryStratch(Vector2 dir) { }
    internal bool IsPlacingAvailable() { return true; }
}

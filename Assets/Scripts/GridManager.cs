using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour {

	[SerializeField] private GameObject _squareCellPrefab;

	public void SpawnAt(Vector2Int position, Color color) {
		var cell = Instantiate(_squareCellPrefab, GridToWorld(position), Quaternion.identity);
		cell.transform.SetParent(this.transform);
		var rend = cell.GetComponent<SpriteRenderer>();
		rend.color = color;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldManager : MonoBehaviour {

	[SerializeField] private GameObject _squareCellPrefab;
	[SerializeField] private RectTransform _container;

	public Square SpawnAt(Vector2 position, Color color) {
		var fieldCell = Instantiate(_squareCellPrefab, _container);
		fieldCell.GetComponent<RectTransform>().anchoredPosition = position;
		fieldCell.GetComponent<Image>().color = color;
		return fieldCell.GetComponent<Square>();
	}
}

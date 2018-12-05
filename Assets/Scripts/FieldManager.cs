using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldManager : MonoBehaviour {

	[SerializeField] private GameObject SquareCellPrefab;
	[SerializeField] private RectTransform Container;

	public void SpawnAt(Vector2 position, Vector2 offset, Color color) {
		var fieldCell = Instantiate(SquareCellPrefab, Container);
		fieldCell.GetComponent<RectTransform>().localPosition = position + offset;
		fieldCell.GetComponent<Image>().color = color;
	}
}

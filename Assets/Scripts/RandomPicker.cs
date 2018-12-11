using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomPicker {
	private static List<Color> _usedColors = new List<Color>();

	public static Color GetColor() {
		Color newColor;
		do {
			newColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		} while (_usedColors.Contains(newColor));

		_usedColors.Add(newColor);
		Debug.Log("Color generated: " + newColor);
		return newColor;
	}

	public static Vector2Int GetPosition(int startPosition, int endPosition) {
		var newPosition = new Vector2Int(Random.Range(startPosition, endPosition), Random.Range(startPosition, endPosition));
		Debug.Log("Position generated: " + newPosition);
		return newPosition;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomPicker {
	private List<Color> _usedColors = new List<Color>();
	private int maxIterations = 20;

	public Color GetColor() {
		Color newColor;
		do {
			newColor = new Color(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256));
		} while (_usedColors.Contains(newColor));

		_usedColors.Add(newColor);
		Debug.Log("Color generated: " + newColor);
		return newColor;
	}

	public Vector2 GetPosition() {
		return Vector2.one;
	}
}

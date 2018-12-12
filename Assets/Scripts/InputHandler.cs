using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
	
	void Update () {
		switch(GameManager.Instance.CurrentState) {
			case GameState.SquareSelect:
				break;
			case GameState.SquareStretch:
				break;
		}
	}
}

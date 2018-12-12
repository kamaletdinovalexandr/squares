using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	[SerializeField] private SquareController _squareController;
	public GameState CurrentState { get; set; }

	private void Start() {
		Instance = this;
		CurrentState = GameState.Init;
	}

	private void Update() {
		switch(CurrentState) {
			case GameState.Init:
				_squareController.InitBoard();
				CurrentState = GameState.GenerateSquare;
				break;
			case GameState.GenerateSquare:
				_squareController.MakeRandomSquare();
				CurrentState = GameState.SquareSelect;
				break;
			case GameState.SquareSelect:
				break;
		}
	}
}

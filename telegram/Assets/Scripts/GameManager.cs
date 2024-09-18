using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class MainWindow : MonoBehaviour {
    [SerializeField] private GameObject board;
    [SerializeField] private List<Tile> tiles;

    private void Awake() {
        Assert.IsNotNull(board);
        Assert.IsNotNull(tiles);
        Assert.IsFalse(tiles.Count < 11, "Amount of tiles must be at least 11");
    }

    private void Start() {
        
    }

    private void StartNewGame() {
        
    }
}

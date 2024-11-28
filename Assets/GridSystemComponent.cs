using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GridSystemComponent : MonoBehaviour
{
    [SerializeField] private GameObject _cellPrefab;

    void Start() {
        GridSystem gridSystem = new GridSystem(5, 5, 1);
        foreach (var cell in gridSystem.Cells) {
            Instantiate(_cellPrefab, cell.Key, quaternion.identity);
        }
    }

    void Update() {
        
    }
}

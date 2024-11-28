using System.Collections.Generic;
using UnityEngine;

public class GridSystem {
    public GridSystem(uint width, uint height, uint size) {
        Cells = new Dictionary<Vector3, Cell>();
        for (int y = 0; y < height; y++) {
            for (int x = 0; x < width; x++) {
                float offset = size * .5f;
                Cells.Add(new Vector3(x + offset, 0, y + offset), new Cell());
            }
        }
    }

    public GridSystem(Dictionary<Vector3, Cell> cells) {
        Cells = cells;
    }


    public Dictionary<Vector3, Cell> Cells { get; private set; }
}

public class Cell {

}
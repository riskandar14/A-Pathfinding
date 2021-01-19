using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode {

    //variables used to track spaces on the grid
    private Grid<PathNode> grid;
    public int x;
    public int y;

    //variables used to track the cost of moving spaces
    public int gCost;
    public int hCost;
    public int fCost;

    public bool isWalkable; //is the space open or blocked off
    public PathNode cameFromNode; //previous node that we used, helpful for tracing backwards

    //Creation of a node that follows the grid's locations
    public PathNode(Grid<PathNode> grid, int x, int y) {
        this.grid = grid;
        this.x = x;
        this.y = y;
        isWalkable = true;
    }

    //Function to calculate the F cost
    public void CalculateFCost() {
        fCost = gCost + hCost;
    }

    public void SetIsWalkable(bool isWalkable) {
        this.isWalkable = isWalkable;
        grid.TriggerGridObjectChanged(x, y);
    }

    public override string ToString() {
        return x + "," + y;
    }

}

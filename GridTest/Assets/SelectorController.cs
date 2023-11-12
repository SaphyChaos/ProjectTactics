using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SelectorController : MonoBehaviour
{
    float deltaTime;
    bool hold;
    bool hold2;
    bool canMove = true;
    public int x;
    public int y;
    public GameObject grid;
    Vector2 v;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (!hold && !hold2)
            {
                if (v.x > 0 && (x + 1 < grid.GetComponent<GridGeneration>().YCells[y].Count))
                {
                    //print(grid.GetComponent<GridGeneration>().YCells[y][x+1].GetComponent<CellID>().x);
                    x += 1;
                }
                if (v.x < 0 && (x - 1 >= 0))
                {
                    //print(grid.GetComponent<GridGeneration>().YCells[y][x+1].GetComponent<CellID>().x);
                    x -= 1;
                }
                if (v.y > 0 && (y + 1 < grid.GetComponent<GridGeneration>().YCells.Count))
                {
                    y += 1;
                }
                if (v.y < 0 && (y - 1 >= 0))
                {
                    y -= 1;
                }
                this.gameObject.transform.position = new Vector3(grid.GetComponent<GridGeneration>().YCells[y][x].transform.position.x, grid.GetComponent<GridGeneration>().YCells[y][x].transform.position.y, this.gameObject.transform.position.z);
            }
            if (v[0] == 0 && v[1] == 0)
            {
                hold = false;
                hold2 = false;
                deltaTime = 0f;
            }
            else
            {
                hold = true;
            }
            if (hold == true)
            {
                deltaTime += Time.deltaTime;
            }
            if (deltaTime >= .3f && hold)
            {
                hold2 = true;
                if (v.x > 0 && (x + 1 < grid.GetComponent<GridGeneration>().YCells[y].Count))
                {
                    //print(grid.GetComponent<GridGeneration>().YCells[y][x+1].GetComponent<CellID>().x);
                    x += 1;
                }
                if (v.x < 0 && (x - 1 >= 0))
                {
                    //print(grid.GetComponent<GridGeneration>().YCells[y][x+1].GetComponent<CellID>().x);
                    x -= 1;
                }
                if (v.y > 0 && (y + 1 < grid.GetComponent<GridGeneration>().YCells.Count))
                {
                    y += 1;
                }
                if (v.y < 0 && (y - 1 >= 0))
                {
                    y -= 1;
                }
                this.gameObject.transform.position = new Vector3(grid.GetComponent<GridGeneration>().YCells[y][x].transform.position.x, grid.GetComponent<GridGeneration>().YCells[y][x].transform.position.y, this.gameObject.transform.position.z);
                deltaTime = 0f;
            }
            else if (deltaTime >= .15f && hold2)
            {
                if (v.x > 0 && (x + 1 < grid.GetComponent<GridGeneration>().YCells[y].Count))
                {
                    //print(grid.GetComponent<GridGeneration>().YCells[y][x+1].GetComponent<CellID>().x);
                    x += 1;
                }
                if (v.x < 0 && (x - 1 >= 0))
                {
                    //print(grid.GetComponent<GridGeneration>().YCells[y][x+1].GetComponent<CellID>().x);
                    x -= 1;
                }
                if (v.y > 0 && (y + 1 < grid.GetComponent<GridGeneration>().YCells.Count))
                {
                    y += 1;
                }
                if (v.y < 0 && (y - 1 >= 0))
                {
                    y -= 1;
                }
                this.gameObject.transform.position = new Vector3(grid.GetComponent<GridGeneration>().YCells[y][x].transform.position.x, grid.GetComponent<GridGeneration>().YCells[y][x].transform.position.y, this.gameObject.transform.position.z);
                deltaTime = 0f;
            }
        }
    }
    public void OnSelect()
    {
        print("select");
    }
    public void OnMove(InputValue value)
    {
        v = value.Get<Vector2>();
    }
}

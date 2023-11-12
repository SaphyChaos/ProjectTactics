using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGeneration : MonoBehaviour
{
    public GameObject Cell;
    //public List<GameObject> XCells = new List<GameObject>();
    public List<List<GameObject>> YCells = new List<List<GameObject>>();
    private Vector3 StartingPos;
    // Start is called before the first frame update
    void Start()
    {
        int xCells = (int)(this.gameObject.GetComponent<RectTransform>().rect.width / Cell.GetComponent<RectTransform>().rect.width);
        int yCells = (int)(this.gameObject.GetComponent<RectTransform>().rect.height / Cell.GetComponent<RectTransform>().rect.height);
        for (int j = 0; j < yCells; j++)
        {
            List<GameObject> XCells = new List<GameObject>();
            for (int i = 0; i < xCells; i++)
            {
                //StartingPos = new Vector3((this.gameObject.GetComponent<RectTransform>().position.x + (Cell.GetComponent<RectTransform>().rect.width / 4) + this.gameObject.GetComponent<RectTransform>().rect.xMin + ((Cell.GetComponent<RectTransform>().rect.width/2) * (i))), (this.gameObject.GetComponent<RectTransform>().position.y + this.gameObject.GetComponent<RectTransform>().rect.yMin), this.gameObject.transform.position.z - .1f);
                StartingPos = new Vector3((this.gameObject.GetComponent<RectTransform>().position.x + (Cell.GetComponent<RectTransform>().rect.width / 2) + this.gameObject.GetComponent<RectTransform>().rect.xMin + ((Cell.GetComponent<RectTransform>().rect.width) * (i))), (this.gameObject.GetComponent<RectTransform>().position.y + (Cell.GetComponent<RectTransform>().rect.height / 2) + (this.gameObject.GetComponent<RectTransform>().rect.yMin) + ((Cell.GetComponent<RectTransform>().rect.width) * (j))), this.gameObject.transform.position.z - .1f);
                GameObject newCell;
                newCell = Instantiate(Cell, StartingPos, this.gameObject.transform.rotation);
                newCell.transform.parent = this.gameObject.transform;
                newCell.GetComponent<CellID>().x = i;
                newCell.GetComponent<CellID>().y = j;
                
                XCells.Add(newCell);
            }
            YCells.Add(XCells);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

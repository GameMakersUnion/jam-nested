using UnityEngine;
using System.Collections;

public class Structure : MonoBehaviour {

    protected int width; //The width of structure
    protected int height; //The height of the structure
    protected int x; //The x Position of the structure
    protected int y; //The y Positino of the structure

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Generate(GameObject goParent, Vector2 dimensions, Vector2 pos)
    {//Generate all the tiles to form the house

        //phase 0: initialize house dimensions
        width = (int)dimensions.x;
        height = (int)dimensions.y;

        //phase 1: build walls, floor
        for (int xx = 0; xx <= width; xx++)
        {
            for (int yy = 0; yy <= height; yy++)
            {
                GameObject go;
                if (yy == 0 || yy == height || xx == 0 || xx == width)
                {
                    go = (GameObject)Instantiate(Resources.Load("wall"), new Vector3(xx + pos.x, yy + pos.y, 0), Quaternion.identity);
                }
                else
                {
                    go = (GameObject)Instantiate(Resources.Load("floor"), new Vector3(xx + pos.x, yy + pos.y, 0), Quaternion.identity);
                }
                go.transform.parent = goParent.transform;
            }
        }

        //phase 2: instantiate rooms within house boundaries
        //rooms = new Rectangle[dimensions.x, dimensions.y];

    }




    //public int SetWidth
    //{

    //    get { return width; }

    //    set { width = value; }

    //}
    //public int SetHeight
    //{

    //    get { return height; }

    //    set { height = value; }

    //} 
}

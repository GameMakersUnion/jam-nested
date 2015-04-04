using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
 * A structure is an abstraction that exists either level of house or room, 
 * since they're very similar.
 */

public class Structure : MonoBehaviour {

    protected float width; //The width of structure
    protected float height; //The height of the structure
    protected float x; //The x Position of the structure
    protected float y; //The y Positino of the structure

    enum hue { Red, Orange, Yellow, GreenLight, Green, BlueLight, Blue, Violet, Lavender}

    private Dictionary<hue, Color32> hues = new Dictionary<hue, Color32>()
    {
        {hue.Red, new Color(1, 0, 0, 1)},
        {hue.Orange, new Color(1, 116f/225f, 0, 1)},
        {hue.Yellow, new Color(1,1, 136/255,1)},
        {hue.GreenLight, new Color(140f/255f, 1, 0, 1)},
        {hue.Green, new Color(0,140f/255f, 0, 1)},
        {hue.BlueLight, new Color(0,140f/255f, 1, 1)},
        {hue.Blue, new Color(0,0,1,1)},
        {hue.Violet, new Color(127f/255f, 0, 1, 1)},
        {hue.Lavender, new Color(238f/255f, 130f/255f, 238f/255f, 1)}
    };

    private static int hackColorCounter = 4;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /**
     *  Scale affects dimensions but not pos. 
     *  pos is (0,0) in bottom-left.
     */

    public void Generate(GameObject goParent, Vector2 dimensions, Vector2 pos, float scale)
    {//Generate all the tiles to form the house

        //phase 0: initialize house dimensions
        width = dimensions.x;
        height = dimensions.y;

        GameObject walls = new GameObject("walls");
        walls.transform.parent = goParent.transform;

        GameObject floors = new GameObject("floors");
        floors.transform.parent = goParent.transform;

        //GameObject doors = new GameObject("doors");
        //doors.transform.parent = goParent.transform;


        //phase 1: build walls, floor
        for (int xx = 0; xx <= width; xx++)
        {
            for (int yy = 0; yy <= height; yy++)
            {
                GameObject go;
                if (yy == 0 || yy == height || xx == 0 || xx == width)
                {
                    go = (GameObject)Instantiate(Resources.Load("door"), new Vector3((xx + pos.x) * scale, (yy + pos.y) * scale, 0), Quaternion.identity);
                    go.name = "wall("+xx+","+yy+")";
                    go.transform.parent = walls.transform;
                }
                else
                {
                    go = (GameObject)Instantiate(Resources.Load("floor"), new Vector3((xx + pos.x)*scale, (yy + pos.y)*scale, 0), Quaternion.identity);
                    go.name = "floor(" + xx + "," + yy + ")";
                    go.transform.parent = floors.transform;
                }
                //change scale 
                go.transform.localScale = new Vector3(scale, scale, scale);

                //change color
                //go.GetComponent<SpriteRenderer>().color = hues[hue.Orange];
                go.GetComponent<SpriteRenderer>().color = hues[(hue)hackColorCounter];
            }
        }

        //hack
        int hackNumHues = Enum.GetNames(typeof(hue)).Length;
        hackColorCounter++;
        if (hackColorCounter > hackNumHues-1)
        {
            hackColorCounter = 0;
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

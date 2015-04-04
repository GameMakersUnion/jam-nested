using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room : Rectangle {
	private List<GameObject> rooms;
	private Rectangle[,] rects;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Generate(Vector2 dimensions){//Generate all the tiles to form the room
		rects = new Rectangle[(int)dimensions.x, (int)dimensions.y]; //very bad

		for (int x=0; x<width; x++) {
			for (int y=0; y<height; y++) {
				//rects[x,y] = (Rectangle)Instantiate ();

			}
		}
	}


}

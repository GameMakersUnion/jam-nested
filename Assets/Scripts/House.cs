using UnityEngine;
using System.Collections;

public class House : MonoBehaviour {

	protected int width; //The width of house
	protected int height; //The height of the house
	protected int x; //The x Position of the house
	protected int y; //The y Positino of the house
	private int count = 0;//The number of houses instantiated

	//a house contains rooms
	private Room[,] rooms; 

	//rooms are placed upon floor tiles, within walls, etc.
	private Rectangle[,] rects; 

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public int SetWidth{
		
		get { return width;}
		
		set { width = value;}  
		
	}
	public int SetHeight{
		
		get { return height;}
		
		set { height = value;}  
		
	} 

	
	public void Generate(Vector2 dimensions, Vector2 pos){//Generate all the tiles to form the room

		//phase 0: initialize house dimensions
		width = (int)dimensions.x;
		height = (int)dimensions.y;
		rects = new Rectangle[width, height];

		GameObject house = new GameObject ("house" + count);

		//phase 1: build walls, floor
		for (int xx = 0; xx<=height; xx++) {
			for (int yy = 0; yy<=width; yy++) {
				GameObject go;
				if (yy==0 || yy==height || xx==0 || xx==width){
					go = (GameObject)Instantiate(Resources.Load ("wall"),	new Vector3(xx + pos.x,yy +pos.y, 0), Quaternion.identity );
					go.transform.parent = house.transform;
				}
				else {
					go = (GameObject)Instantiate(Resources.Load ("floor"), new Vector3(xx + pos.x,yy +pos.y, 0), Quaternion.identity );
				}
				go.transform.parent = house.transform;
			}
		}

		//phase 2: instantiate rooms within house boundaries
		//rooms = new Rectangle[dimensions.x, dimensions.y];

	}
}
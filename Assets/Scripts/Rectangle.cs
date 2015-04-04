using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Rectangle : MonoBehaviour {
	protected int width; //The width of rectangle
	protected int height; //The height of the rectangle
	protected int x; //The x Position of the Rectangle
	protected int y; //The y Positino of the rectangle
	protected GameObject tile; //The tile such as floor, wall, etc.

	/*
	public enum TileTypes { Nadda, Wall, Floor, Door };
	public static Dictionary<TileTypes, Sprite> MapTypes = new Dictionary<TileTypes, Sprite> (){
		{TileTypes.Nadda, null},
		{TileTypes.Wall, Resources.Load ("wall")},
		{TileTypes.Floor, Resources.Load ("floor")},
		{TileTypes.Door, Resources.Load ("door")}
		}
	;
	*/


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
	public int SetX{
		
		get { return x;}
		
		set { x = value;}  
		
	}
	public int SetY{
		
		get { return y;}
		
		set { y = value;}  
		
	}  
	public GameObject SetTile {

		get { return tile; }

		set { tile = value; }

	}
}

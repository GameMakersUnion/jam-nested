﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HouseGenerator : MonoBehaviour {
	public int width=200;//The width of the house 
	public int height=200;//The height of the house
	public int numRooms=5;//The number of rooms
	public int maxRoomHeight=10;//Max room Height
	public int maxRoomWidth=10;//Max room width
	public int minRoomHeight=4; //Max room height
	public int minRoomWidth=4; //Max room width
	public int seed=1337;//The seed used to room generation

	private  List<Room> rooms;

	House houseRef;


	// Use this for initialization
	void Start () {
		Random.seed = seed;//Set the seed for random values


		houseRef = GameObject.Find("RoomGenerator").GetComponent<House> ();
		houseRef.Generate(new Vector2(5, 10), new Vector2(0,0) );
		houseRef.Generate(new Vector2(10, 5), new Vector2(-20, -20) );


		//House home = new House ();
			//House.Generate(new Vector2(10, 5), new Vector2(0,0) );

/*
		rooms = new List<Room>();
		//Place the rooms
		for (int i=0; i<numRooms; i++) {
			// Random.value
			Room room = new Room();
			room.SetHeight = 3;
			room.SetWidth = 3;
			room.SetX = Random.Range(width);
			room.SetY = Random.Range(height);
			room.Generate();
			rooms.Add(room);
		}
*/

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

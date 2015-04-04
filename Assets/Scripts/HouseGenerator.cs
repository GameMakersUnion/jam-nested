using UnityEngine;
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
    Room roomRef;

    public const float HALF = 0.5f;

	// Use this for initialization
	void Start () {
		Random.seed = seed;//Set the seed for random values


		houseRef = GameObject.Find("RoomGenerator").GetComponent<House> ();
	    if (houseRef == null)
	    {
            Debug.LogWarning("Cannot generate houses. House script not attached to RoomGenerator");
	        return;
	    }
		Structure house0 = houseRef.Generate(new Vector2(10, 20), new Vector2(0,0) );
        Structure house1 = houseRef.Generate(new Vector2(10, 5), new Vector2(-20, -20));

        roomRef = GameObject.Find("RoomGenerator").GetComponent<Room>();
        if (roomRef == null)
        {
            Debug.LogWarning("Cannot generate rooms. Room script not attached to RoomGenerator");
            return;
        }
        Structure room0a = roomRef.Generate(new Vector2(4, 4), new Vector2(1, 0));
        Structure room0b = roomRef.Generate(new Vector2(4, 4), new Vector2(2, 6));

	    GameObject rooms0 = new GameObject("rooms");
        rooms0.transform.parent = house0.transform;
        room0a.transform.parent = rooms0.transform;
        room0b.transform.parent = rooms0.transform;

        //house inside room
	    Structure house2 = houseRef.Generate(new Vector2(6, 6), new Vector2(1, 1), HALF);

        //god damn this redundant stupdity, it ought to be avoided
        house2.transform.position += new Vector3(house2.transform.position.x + 0, house2.transform.position.y + 0, house2.transform.position.z - 2);


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

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room : Structure{

    private static int counter = 0;//The number of rooms instantiated

    private Structure stRef;

    // Use this for initialization
    void Awake()
    {
        stRef = GameObject.Find("RoomGenerator").GetComponent<Structure>();
        thisClassName = this.GetType().Name;    //Room
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public Structure Generate(Vector2 dimensions, Vector2 pos)
    {

        //negatives not allowed
        if (pos.x < 0 || pos.y < 0)
        {
            Debug.LogError("Cannot have any negative positions, this has "+ pos +". By defintion a room's bottom-left is (0,0). ");
            return null;
        }

        //negatives not allowed
        if (dimensions.x <= 0 || dimensions.y <= 0)
        {
            Debug.LogError("Cannot have any negative dimensions, this has " + dimensions);
            return null;
        }


        if (stRef != null)
        {
            //GameObject room = new GameObject(thisClassName + counter++);
            Room room = Resources.Load<Room>("structures/room");
            Room roomInstance = (Room)stRef.Generate(room, dimensions, pos, 1);
            roomInstance.transform.name = thisClassName + counter++;
            roomInstance.transform.position += new Vector3(0, 0, -1); //hack
            return roomInstance;
        }
        else
        {
            Debug.LogWarning("Cannot instantiate " + thisClassName + ", couldn't find reference to RoomGenerator");
            return null;
        }

    }

}

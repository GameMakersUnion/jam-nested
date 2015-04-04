using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room : Rectangle {

    private static int counter = 0;//The number of rooms instantiated

    private Structure stRef;

    // Use this for initialization
    void Awake()
    {
        stRef = GameObject.Find("RoomGenerator").GetComponent<Structure>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Generate(Vector2 dimensions, Vector2 pos)
    {
        if (stRef != null)
        {
            GameObject house = new GameObject("room" + counter++);
            stRef.Generate(house, dimensions, pos);
        }
        else
        {
            Debug.LogWarning("Cannot instantiate house, couldn't find reference to RoomGenerator");
        }


    }


}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class House : Structure {

	private static int counter = 0;//The number of houses instantiated

    private Structure stRef;

    //private Structure instance;

	// Use this for initialization
	void Awake () {
        stRef = GameObject.Find("RoomGenerator").GetComponent<Structure>();
        thisClassName = this.GetType().Name;    //House
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //no scale provided, defaults to 1
    public Structure Generate(Vector2 dimensions, Vector2 pos)
    {
        return Generate(dimensions, pos, 1);
    }

    //scale provided, typically will be 0.5f
    public Structure Generate(Vector2 dimensions, Vector2 pos, float scale)
    {
        if (stRef != null)
        {
            //GameObject house = new GameObject(thisClassName + counter++);
            //house.AddComponent<House>();

            House house = Resources.Load<House>("structures/house");

            House houseInstance = (House)stRef.Generate(house, dimensions, pos, scale);
            houseInstance.transform.name = thisClassName + counter++;
            return houseInstance;
        }
        else
        {
            Debug.LogWarning("Cannot instantiate " + thisClassName + ", couldn't find reference to RoomGenerator");
            return null;
        }
        
    }

    public void Add(GameObject go)
    {
        
    }

	

}
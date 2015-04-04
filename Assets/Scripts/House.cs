using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class House : MonoBehaviour {

	private static int counter = 0;//The number of houses instantiated

    private List<Room> rooms;//a house contains rooms

    private Structure stRef;

    private string thisClassName;

    private GameObject house;

	// Use this for initialization
	void Awake () {
        stRef = GameObject.Find("RoomGenerator").GetComponent<Structure>();
	    rooms = new List<Room>();
        thisClassName = this.GetType().Name;    //House
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //no scale provided, defaults to 1
    public GameObject Generate(Vector2 dimensions, Vector2 pos)
    {
        return Generate(dimensions, pos, 1);
    }

    //scale provided, typically will be 0.5f
    public GameObject Generate(Vector2 dimensions, Vector2 pos, float scale)
    {
        if (stRef != null)
        {
            house = new GameObject(thisClassName + counter++);
            house.AddComponent<House>();
            stRef.Generate(house, dimensions, pos, scale);
            return house;
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
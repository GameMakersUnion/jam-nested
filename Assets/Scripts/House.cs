using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class House : MonoBehaviour {

	private static int counter = 0;//The number of houses instantiated

    private List<Room> rooms;//a house contains rooms

    private Structure stRef;

	// Use this for initialization
	void Awake () {
        stRef = GameObject.Find("RoomGenerator").GetComponent<Structure>();
	    rooms = new List<Room>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public GameObject Generate(Vector2 dimensions, Vector2 pos)
    {
        if (stRef != null)
        {
            GameObject house = new GameObject("house" + counter++); 
            house.AddComponent<House>();
            stRef.Generate(house, dimensions, pos);
            return house;
        }
        else
        {
            Debug.LogWarning("Cannot instantiate house, couldn't find reference to RoomGenerator");
            return null;
        }

        
    }

	

}
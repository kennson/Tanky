using UnityEngine;
using System.Collections;

public class Wood1SpawnController : MonoBehaviour {

	public GameObject[] wood1Array;
	private int randNum;
	
	void Awake()
	{
		wood1Array = GameObject.FindGameObjectsWithTag("Wood1Spawn");
	}
	
	public GameObject GetRandomWood1Spawn(int randNum)
	{
		randNum = Random.Range(0, (wood1Array.Length));
		
		if (wood1Array.Length > 0)
		{
			return wood1Array[randNum];
		}
		else
		{
			return null;
		}
	}
}

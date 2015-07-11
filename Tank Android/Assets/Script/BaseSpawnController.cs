using UnityEngine;
using System.Collections;

public class BaseSpawnController : MonoBehaviour {

	public GameObject[] baseArray;
	private int randNum;
	
	void Awake()
	{
		baseArray = GameObject.FindGameObjectsWithTag("BaseSpawn");
	}
	
	public GameObject GetRandomBaseSpawn(int randNum)
	{
		randNum = Random.Range(0, (baseArray.Length));
		
		if (baseArray.Length > 0)
		{
			return baseArray[randNum];
		}
		else
		{
			return null;
		}
	}
}

using UnityEngine;
using System.Collections;

public class TankSpawnController : MonoBehaviour {

	public GameObject[] tankArray;
	private int randNum;
	
	void Awake()
	{
		tankArray = GameObject.FindGameObjectsWithTag("TankSpawn");
	}
	
	public GameObject GetRandomTankSpawn(int randNum)
	{
		randNum = Random.Range(0, (tankArray.Length));
		
		if (tankArray.Length > 0)
		{
			return tankArray[randNum];
		}
		else
		{
			return null;
		}
	}
}

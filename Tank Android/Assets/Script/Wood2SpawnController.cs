using UnityEngine;
using System.Collections;

public class Wood2SpawnController : MonoBehaviour {

	public GameObject[] wood2Array;
	private int randNum;
	
	void Awake()
	{
		wood2Array = GameObject.FindGameObjectsWithTag("Wood2Spawn");
	}
	
	public GameObject GetRandomWood2Spawn(int randNum)
	{
		randNum = Random.Range(0, (wood2Array.Length));
		
		if (wood2Array.Length > 0)
		{
			return wood2Array[randNum];
		}
		else
		{
			return null;
		}
	}
}

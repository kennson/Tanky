using UnityEngine;
using System.Collections;

public class Metal1SpawnController : MonoBehaviour {

	public GameObject[] metal1Array;
	private int randNum;
	
	void Awake()
	{
		metal1Array = GameObject.FindGameObjectsWithTag("Metal1Spawn");
	}
	
	public GameObject GetRandomMetal1Spawn(int randNum)
	{
		randNum = Random.Range(0, (metal1Array.Length));
		
		if (metal1Array.Length > 0)
		{
			return metal1Array[randNum];
		}
		else
		{
			return null;
		}
	}
}

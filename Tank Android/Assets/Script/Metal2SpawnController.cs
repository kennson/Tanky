using UnityEngine;
using System.Collections;

public class Metal2SpawnController : MonoBehaviour {

	public GameObject[] metal2Array;
	private int randNum;
	
	void Awake()
	{
		metal2Array = GameObject.FindGameObjectsWithTag("Metal2Spawn");
	}
	
	public GameObject GetRandomMetal2Spawn(int randNum)
	{
		randNum = Random.Range(0, (metal2Array.Length));
		
		if (metal2Array.Length > 0)
		{
			return metal2Array[randNum];
		}
		else
		{
			return null;
		}
	}
}

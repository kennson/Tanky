using UnityEngine;
using System.Collections;

public class Tree1SpawnController : MonoBehaviour {

	public GameObject[] tree1Array;
	private int randNum;
	
	void Awake()
	{
		tree1Array = GameObject.FindGameObjectsWithTag("Tree1Spawn");
	}
	
	public GameObject GetRandomTree1Spawn(int randNum)
	{
		randNum = Random.Range(0, (tree1Array.Length));
		
		if (tree1Array.Length > 0)
		{
			return tree1Array[randNum];
		}
		else
		{
			return null;
		}
	}
}

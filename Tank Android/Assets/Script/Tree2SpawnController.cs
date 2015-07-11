using UnityEngine;
using System.Collections;

public class Tree2SpawnController : MonoBehaviour {

	public GameObject[] tree2Array;
	private int randNum;
	
	void Awake()
	{
		tree2Array = GameObject.FindGameObjectsWithTag("Tree2Spawn");
	}
	
	public GameObject GetRandomTree2Spawn(int randNum)
	{
		randNum = Random.Range(0, (tree2Array.Length));
		
		if (tree2Array.Length > 0)
		{
			return tree2Array[randNum];
		}
		else
		{
			return null;
		}
	}
}

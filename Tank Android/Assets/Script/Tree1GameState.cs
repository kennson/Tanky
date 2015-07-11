using UnityEngine;
using System.Collections;

public class Tree1GameState : MonoBehaviour {

	private GameObject tree1;
	
	private Tree1SpawnController tree1SpawnCTRL;
	
	private GameObject randTree1Spawn;
	
	void Awake()
	{
		tree1 = GameObject.FindWithTag("Tree1");
		tree1SpawnCTRL = GameObject.FindGameObjectWithTag("Tree1SpawnCTRL").GetComponent<Tree1SpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randTree1Spawn = tree1SpawnCTRL.GetRandomTree1Spawn(randNum);
		
		SpawnTree1();
	}
	
	void SpawnTree1()
	{
		tree1.transform.position = randTree1Spawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}

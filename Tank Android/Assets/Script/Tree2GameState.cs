using UnityEngine;
using System.Collections;

public class Tree2GameState : MonoBehaviour {

	private GameObject tree2;
	
	private Tree2SpawnController tree2SpawnCTRL;
	
	private GameObject randTree2Spawn;
	
	void Awake()
	{
		tree2 = GameObject.FindWithTag("Tree2");
		tree2SpawnCTRL = GameObject.FindGameObjectWithTag("Tree2SpawnCTRL").GetComponent<Tree2SpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randTree2Spawn = tree2SpawnCTRL.GetRandomTree2Spawn(randNum);
		
		SpawnTree2();
	}
	
	void SpawnTree2()
	{
		tree2.transform.position = randTree2Spawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}

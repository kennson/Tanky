using UnityEngine;
using System.Collections;

public class TankGameState : MonoBehaviour {

	private GameObject tank;
	
	private TankSpawnController tankSpawnCTRL;
	
	private GameObject randTankSpawn;
	
	void Awake()
	{
		tank = GameObject.FindWithTag("Tank");
		tankSpawnCTRL = GameObject.FindGameObjectWithTag("TankSpawnCTRL").GetComponent<TankSpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randTankSpawn = tankSpawnCTRL.GetRandomTankSpawn(randNum);
		
		SpawnTank();
	}
	
	void SpawnTank()
	{
		tank.transform.position = randTankSpawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}

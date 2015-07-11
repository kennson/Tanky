using UnityEngine;
using System.Collections;

public class EnemyGameState : MonoBehaviour {

	private GameObject enemy;
	
	private EnemySpawnController enemySpawnCTRL;
	
	private GameObject randEnemySpawn;
	
	void Awake()
	{
		enemy = GameObject.FindWithTag("Enemy");
		enemySpawnCTRL = GameObject.FindGameObjectWithTag("EnemySpawnCTRL").GetComponent<EnemySpawnController>();
	}
	
	void Start () 
	{
		int randNum = 0;
		randEnemySpawn = enemySpawnCTRL.GetRandomEnemySpawn(randNum);
		
		SpawnEnemy();
	}
	
	void SpawnEnemy()
	{
		enemy.transform.position = randEnemySpawn.transform.position;
		//Debug.Log(" have spawned at " + randTankSpawn.name);
	}
}

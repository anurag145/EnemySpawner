using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	int enemyAtOnce,timeCounter=0,maxCount = 1,incrementEnemy=1;float RValue;
	public GameObject Enemy,Enemy1,Enemy2,Enemy3,Enemy4;

	void Start () {
		
		InvokeRepeating ("InstantiateEnemy", 1f, 5f);
		
	}
		void InstantiateEnemy()
	{  Debug.Log (timeCounter);
		enemyAtOnce = 0;

		if (timeCounter >= 10) {
			maxCount =maxCount*2;
			incrementEnemy ++;

			timeCounter = 0;
		} else
			timeCounter++;
		RValue = Random.value;
		if (RValue<0.5&&RValue>=0&&enemyAtOnce<=maxCount) {
			Instantiate (Enemy);
			enemyAtOnce+=incrementEnemy;
			RValue = Random.value;
		}
		if (RValue <=0.7&&RValue>0.5&&enemyAtOnce<=maxCount) {
			Instantiate (Enemy1);
			enemyAtOnce+=incrementEnemy;
			RValue = Random.value;
		}
		if (RValue >0.7&&RValue<0.8&enemyAtOnce<=maxCount) {
			Instantiate (Enemy2);
			enemyAtOnce+=incrementEnemy;
			RValue = Random.value;
		}
		if (RValue >=0.8&&RValue<0.9&&enemyAtOnce<=maxCount) {
			Instantiate (Enemy3);
			enemyAtOnce += incrementEnemy;
			RValue = Random.value;
		}
		if (RValue >=0.9&&enemyAtOnce<=maxCount) {
			Instantiate (Enemy4);
			enemyAtOnce++;
		}
		

	}	

	// Update is called once per frame
	void Update () {
		
	}


}

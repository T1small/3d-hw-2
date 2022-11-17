using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

        [SerializeField]
        private GameObject target0Prefab;
        [SerializeField]
        private GameObject target1Prefab;
        [SerializeField]
        private GameObject target2Prefab;

        [SerializeField]
        private float target0Interval=3.5f;
        [SerializeField]
        private float target1Interval=5.5f;
        [SerializeField]
        private float target2Interval=7.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(target0Interval,target0Prefab));
        StartCoroutine(spawnEnemy(target1Interval,target0Prefab));
        StartCoroutine(spawnEnemy(target2Interval,target0Prefab));

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator spawnEnemy(float interval,GameObject enemy)
    {
       yield return new WaitForSeconds(interval);
       GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-2f,1f),0,0),Quaternion.identity);
       StartCoroutine(spawnEnemy(interval,enemy)); 
    }
}

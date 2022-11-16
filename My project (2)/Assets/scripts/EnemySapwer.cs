using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySapwer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject Target0Prefab;
    [SerializeField]
    private GameObject Target1Prefab;
    [SerializeField]
    private GameObject Target2Prefab;

    [SerializeField]
    private float Target0Interval = 3.5f;
    [SerializeField]
    private float Target1Interval = 4.5f;
    [SerializeField]
    private float Target2Interval = 5.5f;


    void Start()
    {
        StartCoroutine(spawnTarget(Target0Interval,Target0Prefab));
        StartCoroutine(spawnTarget(Target1Interval,Target1Prefab));
        StartCoroutine(spawnTarget(Target2Interval,Target2Prefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator spawnTarget(float interval, GameObject Target)
    {
        yield return new WaitForSeconds(interval);
        GameObject newTarget = Instantiate(Target, new Vector3(Random.Range(-1f,1),1f,0),Quaternion.identity);
        StartCoroutine(spawnTarget(interval,Target));
    }
}

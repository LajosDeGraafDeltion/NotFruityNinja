using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public static SpawnObjects spawnObjects;
    public Vector3 center;
    public Vector3 size;
    public bool destroyerOn;
    public GameObject fallingObject;
    public GameObject fallingDestroyer;

    public void Start()
    {
        spawnObjects = this;
    }

    public void Update()
    {
        if (ScoreManager.scoreManager.scoreKeep >= 5 && destroyerOn == false)
        {
            StartCoroutine(SpawnDestroyer());
        }
    }

    public void StartThisGame()
    {
        StartCoroutine(SpawnTargets());
    }

    public IEnumerator SpawnTargets()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));


        GameObject target = Instantiate(fallingObject, pos, Quaternion.identity);
        Destroy(target, 3.5f);
        StartCoroutine(SpawnTargets());
    }

    public IEnumerator SpawnDestroyer()
    {
        destroyerOn = true;
        yield return new WaitForSeconds(Random.Range(3f, 10f));
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));


        GameObject destroyer = Instantiate(fallingDestroyer, pos, Quaternion.identity);
        Destroy(destroyer, 3.5f);
        StartCoroutine(SpawnDestroyer());
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}

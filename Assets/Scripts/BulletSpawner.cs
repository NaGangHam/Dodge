using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletprefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3.0f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;
    // Start is called before the first frame update
    void Start(){
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindAnyObjectByType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update(){
        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn >= spawnRate) {

            timeAfterSpawn = 0f;

            GameObject bullet 
                = Instantiate(bulletprefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin,spawnRateMax);
        }


    }
}

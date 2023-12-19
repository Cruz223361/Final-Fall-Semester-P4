using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanmanager : MonoBehaviour
{
    public GameObject collectibleObject;

    public GameObject enemyObject;

    public float areaRange = 45f;

    public int CoinAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpwanEnemyObject();
        collectibleObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpwanEnemyObject()
    {
        Instantiate(enemyObject, new Vector3(0, 0, 10), enemyObject.transform.rotation); 
    }

    void SpwanCollectibleObject()
    {
        Instantiate(collectibleObject, new Vector3(0, 1, 15), collectibleObject.transform.rotation);
    }

    Vector3 RandomSpwanPosition()
    {
        Vector3 spwanPosition = new Vector3(Random.Range(-areaRange, areaRange), 1f, Random.Range(-areaRange, areaRange));

       return spwanPosition;
    }

       
}

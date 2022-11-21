﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2;
    private float repeatRate = 2;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public GameObject obstaclePrefab;
    // Start is called before the first frame update 
    void Start() {
       InvokeRepeating("SpawnObstacle", startDelay, repeatRate); }

    // Update is called once per frame
    void Update()
    {
        
    }

   void SpawnObstacle ()
   {
        Instantiate(obstaclePrefab, spawnPos,obstaclePrefab.transform.rotation); 
    }

}

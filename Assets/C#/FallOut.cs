﻿using UnityEngine;

public class FallOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("Master").GetComponent<GameMaster>().GameOver();
    }
}

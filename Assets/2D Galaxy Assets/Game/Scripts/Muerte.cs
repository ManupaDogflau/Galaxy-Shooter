﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(End());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


    private IEnumerator End()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}

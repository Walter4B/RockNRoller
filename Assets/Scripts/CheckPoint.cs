﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HealthManager healthManager = other.GetComponent<HealthManager>();

            if (healthManager)
            {
                healthManager.SetRespawnPosition(transform.position);
            }
        }
    }
}

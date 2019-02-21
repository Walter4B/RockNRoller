using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerBall : MonoBehaviour
{
    public float Damage = 100.0f;

    
    void OnTriggerEnter(Collider other)
    {
        HealthManager healthManager = other.gameObject.GetComponent<HealthManager>();

        if (healthManager != null)
          {
              healthManager.ApplyDamage(Damage);
          }
    }
    
}

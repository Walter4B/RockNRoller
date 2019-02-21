using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneDamage : MonoBehaviour
{
    public float Damage = 100.0f;

    private void OnCollisionEnter(Collision other)
    {

        HealthManager healthManager = other.gameObject.GetComponent<HealthManager> ();

        if (healthManager != null)
            healthManager.ApplyDamage (Damage);
    }
}

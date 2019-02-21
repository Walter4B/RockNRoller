using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TokenDeactivator : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}

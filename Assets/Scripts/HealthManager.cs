using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public enum onDeathAction
    {
        ReloadLevel,
        ReloadGame
    }
    [SerializeField]
    private float HealthPoints = 100.0f;
    public float RespawnHealthPoints = 100.0f;

    public int NumberOfLives = 3;
    
    public onDeathAction onAllLivesGone = onDeathAction.ReloadGame;

    public GameObject ExplosionPrefab;

    private Vector3 _respawnPosition;
    private Quaternion _respawnRotation;

    void Start()
    {
        HealthPoints = RespawnHealthPoints;
        _respawnPosition = transform.position;
        _respawnRotation = transform.rotation;
    }

    void Update()
    {
        if (HealthPoints <= 0.0f)
        {
            NumberOfLives--;
            UILives.lives = NumberOfLives;
            if(ExplosionPrefab != null)
            {
                Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            }

            if (NumberOfLives > 0)
                Respawn();
            else
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex);
                Destroy(gameObject);
            }
        }
    }

    void Respawn()
    {
        transform.position = _respawnPosition;
        transform.rotation = _respawnRotation;
        HealthPoints = RespawnHealthPoints;

        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void ApplyDamage(float amount)
    {
        HealthPoints -= amount;
        
    }
    public void SetRespawnPosition(Vector3 newRespawnPosition)
    {
        _respawnPosition = newRespawnPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class TokenDeactivator : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (other.gameObject.CompareTag("Player"))
        {
            int lvlnum = 0;

            if(File.Exists("SaveFile.dat"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open("SaveFile.dat", FileMode.Open)))
                {
                    lvlnum = reader.ReadInt32();
                }
            }
            
            if(lvlnum < currentSceneIndex)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("SaveFile.dat", FileMode.Create)))
                {
                    writer.Write(currentSceneIndex);
                }
            }

            this.gameObject.SetActive(false);
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}

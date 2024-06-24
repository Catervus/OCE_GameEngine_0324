using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathObject : MonoBehaviour
{

    private void OnTriggerEnter(Collider _other)
    {
        Debug.Log("Trigger!");
        if (_other.gameObject.CompareTag("Player"))
        {
            // Reload Scene
            Debug.Log("Reload Scene!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if(!_other.gameObject.CompareTag("Deathzone"))
        {
            Destroy(_other.gameObject);
        }
        
    }

    private void OnCollisionEnter(Collision _col)
    {
        Debug.Log("Collide!");
        if (_col.gameObject.CompareTag("Player"))
        {
            // Reload Scene
            Debug.Log("Reload Scene!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeedBoostBehaviour : MonoBehaviour
{
    [SerializeField] private float speedBoostValue;
    private void OnTriggerEnter(Collider _other)
    {
        if (_other.gameObject.tag != "Player")
        {
            return;
        }

        // trigger with player!
        Vector3 playermovedir;
        Rigidbody playerrb = _other.GetComponent<Rigidbody>();
        if (playerrb == null)
        {
            return;
        }

        playermovedir = playerrb.velocity.normalized;

        playerrb.AddForce(playermovedir * speedBoostValue, ForceMode.Impulse);

    }
}

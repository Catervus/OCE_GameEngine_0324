using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] 
    private List<Transform> waypoints;

    private int currentWaypointIndex;

    [SerializeField] private float speed;


    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, 
                                            waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

        if (ApproxSamePosition(transform.position, waypoints[currentWaypointIndex].position))
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Count)
            {
                currentWaypointIndex = 0;
            }
        }
    }

    private bool ApproxSamePosition(Vector3 _pos01, Vector3 _pos02)
    {
        if((_pos01.x > _pos02.x - 0.01f && _pos01.x < _pos02.x + 0.01f) == false)
        {
            return false;
        }

        if ((_pos01.y > _pos02.y - 0.01f && _pos01.y < _pos02.y + 0.01f) == false)
        {
            return false;
        }

        if ((_pos01.z > _pos02.z - 0.01f && _pos01.z < _pos02.z + 0.01f) == false)
        {
            return false;
        }

        return true;
    }


    private void OnTriggerEnter(Collider _other)
    {
        if (_other.gameObject.CompareTag("Player"))
        {
            _other.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider _other)
    {
        if (_other.gameObject.CompareTag("Player"))
        {
            _other.transform.parent = null;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotationAngle;

    [SerializeField] private Space rotationSpace;

    [SerializeField] private float rotationSpeed;

    void Update()
    {
        transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime, rotationSpace);
    }
}

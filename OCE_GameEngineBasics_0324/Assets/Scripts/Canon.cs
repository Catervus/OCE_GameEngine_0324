using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] 
    private List<GameObject> projectiles;

    [SerializeField] private float shootCooldown;
    private float curCD;

    [SerializeField]
    private Transform shootTransform;

    [SerializeField] private float shootForce;

    void Start()
    {
        curCD = shootCooldown;
    }

    void Update()
    {
        curCD -= Time.deltaTime;
        if (curCD <= 0)
        {
            Shoot();
            curCD = shootCooldown;
        }
    }

    void Shoot()
    {
        if (projectiles.Count <= 0)
            return;

        int rndidx = Random.Range(0, projectiles.Count);

        GameObject proj = Instantiate(projectiles[rndidx], shootTransform.position, Quaternion.identity);

        // Destroy(proj, 5);

        Rigidbody projrb = proj.GetComponent<Rigidbody>();

        if (projrb == null)
        {
            return;
        }

        projrb.AddForce(transform.forward * shootForce, ForceMode.Impulse);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooterController : MonoBehaviour
{
    public GameObject bulletObject;

    public float spawnDistance = 0.5f;

    public float fireRate = .1f;
    private float fireCounter;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            PrepareFire();
        }
    }

    void PrepareFire()
    {
        fireCounter += fireRate;

        if (fireCounter >= 1f)
            Fire();


    }

    void Fire()
    {
        fireCounter = 0f;

        var bulletSpawned = GameObject.Instantiate(bulletObject);
        bulletSpawned.transform.position = transform.position + Vector3.right * spawnDistance;



    }
}

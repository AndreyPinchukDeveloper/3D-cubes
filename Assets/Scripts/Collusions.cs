using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collusions : MonoBehaviour
{
    private Vector3 spawn;
    public GameObject deathParticles;

    void Start()
    {
        spawn = transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
            Instantiate(deathParticles, transform.position, Quaternion.identity);//Quaternion.identity=not rotation
            //Destroy(gameObject);
            transform.position = spawn;
        }
    }
}

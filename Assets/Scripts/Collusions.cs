using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (other.transform.tag == "Enemy"||other.transform.tag =="Void")
        {
            Die();
        }

        if (other.transform.tag == "Goal")
        {
            GameManager.CompleteLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Goal")
        {
            GameManager.CompleteLevel();
        }
    }

    public void Die()
    {
        Instantiate(deathParticles, transform.position, Quaternion.Euler(270,0,0));
        transform.position = spawn;
    }
}

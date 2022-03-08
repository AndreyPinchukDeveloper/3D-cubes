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
        switch (other.transform.tag)
        {
            case "Goal":
                GameManager.CompleteLevel();
                break;
            case "Enemy":
                Die();
                break;
        }
        /*if (other.transform.tag == "Goal"||other.transform.tag == "Enemy")
        {
            GameManager.CompleteLevel();
        }*/
    }

    public void Die()
    {
        Instantiate(deathParticles, transform.position, Quaternion.Euler(270,0,0));
        transform.position = spawn;
    }
}

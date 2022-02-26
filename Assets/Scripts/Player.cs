using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector3 spawnPoint;
    private GameObject cubesOfDeath;
    public int nextLevel;
    private int deaths;
    private int score;

    public Rigidbody rb;
    public Collider collider;

    void Start()
    {
        spawnPoint = transform.position;
    }

    void Update()
    {
        if (transform.position.y<-2)
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision hit)
    {
        if (hit.collider.tag == "Enemy")
        {
            Die();
        }
    }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.GetComponent<Collider>()  /*collider.tag == "Goal"*/)
        {
            print("Well done !");
            CompleteLevel();
        }
    }

    private void CompleteLevel()
    {
        //Application.LoadLevel(nextLevel);
        SceneManager.LoadScene(nextLevel);
    }

    private void Die()
    {
        Instantiate(cubesOfDeath, transform.position, Quaternion.Euler(270, 0, 0));
        transform.position = spawnPoint;
        rb.velocity = Vector3.zero;
    }
}

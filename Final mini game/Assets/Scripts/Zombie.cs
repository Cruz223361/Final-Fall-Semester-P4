using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody _zombieRb;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _zombieRb = GetComponent<Rigidbody>();
        _player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookdirection = (_player.transform.position - transform.position).normalized;
        _zombieRb.AddForce(lookdirection * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("The Zombie hit the player!");
            GameObject.Find("GameManger")
           
        }

            
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody _playerRb;
    private float _horizonatalInput;
    private float _forwardInput;
    private AudioSource _playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizonatalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(_horizonatalInput, 0f, _forwardInput);
        _playerRb.AddForce(moveDirection * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if 
    }
}

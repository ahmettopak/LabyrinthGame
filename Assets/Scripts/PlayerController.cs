using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public bool isGameOver;
    public GameObject gameOverPanel;
    void Start()
    {
            isGameOver = false;
    }
    void Update()
    {
        transform.position += new Vector3(Input.acceleration.x*moveSpeed, 0, Input.acceleration.y*moveSpeed) * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "EndPoint") {
            isGameOver = true;
            Debug.Log("asda");
            gameOverPanel.SetActive(isGameOver);
        }
    }
}

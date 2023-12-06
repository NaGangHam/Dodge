using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody brb;

    // Start is called before the first frame update
    void Start(){
        brb = GetComponent<Rigidbody>();
        brb.velocity = transform.forward*speed;

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player") {
            PlayerController playerController = other.GetComponent<PlayerController>();
            if(playerController != null) {
                playerController.Die();
            }
        }
        
    }
}

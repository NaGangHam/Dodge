using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public Rigidbody rb; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; // 이동속력

    // Start is called before the first frame update
    void Start(){
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 플레이어리지드바디에 할당
        rb = GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update(){
        
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = speed * xInput;
        float zSpeed = speed * zInput;
        // float xSpeed = Input.GetAxis("Horizontal") * speed; 위 4개와 같다.
        // float zSpeed = Input.GetAxis("Vertical") * speed t;


        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        rb.velocity = newVelocity;
        //rb.velocity = newVelocity(xSpeed, 0f, zSpeed); 위 2개와 같다 

    }


    public void Die() {
        gameObject.SetActive(false);

        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.EndGame();

    }

}


/*if (Input.GetKey(KeyCode.UpArrow) == true) {
    // 위쪽 방향키 입력이 감지된 경우 z 방향 힘주기
    rb.AddForce(0f, 0f, speed);
}
if (Input.GetKey(KeyCode.DownArrow) == true) {
    // 아래쪽 방향키 입력이 감지된 경우 -z 방향 힘주기
    rb.AddForce(0f, 0f, -speed);
}
if (Input.GetKey(KeyCode.LeftArrow) == true) {
    // 왼쪽 방향키 입력이 감지된 경우 -x 방향 힘주기
    rb.AddForce(-speed, 0f, 0f);
}
if (Input.GetKey(KeyCode.RightArrow) == true) {
    // 오른쪽 방향키 입력이 감지된 경우 x 방향 힘주기
    rb.AddForce(speed, 0f, 0f);*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public Rigidbody rb; // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f; // �̵��ӷ�

    // Start is called before the first frame update
    void Start(){
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� �÷��̾����ٵ� �Ҵ�
        rb = GetComponent<Rigidbody>(); 

    }

    // Update is called once per frame
    void Update(){
        
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = speed * xInput;
        float zSpeed = speed * zInput;
        // float xSpeed = Input.GetAxis("Horizontal") * speed; �� 4���� ����.
        // float zSpeed = Input.GetAxis("Vertical") * speed t;


        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        rb.velocity = newVelocity;
        //rb.velocity = newVelocity(xSpeed, 0f, zSpeed); �� 2���� ���� 

    }


    public void Die() {
        gameObject.SetActive(false);

        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.EndGame();

    }

}


/*if (Input.GetKey(KeyCode.UpArrow) == true) {
    // ���� ����Ű �Է��� ������ ��� z ���� ���ֱ�
    rb.AddForce(0f, 0f, speed);
}
if (Input.GetKey(KeyCode.DownArrow) == true) {
    // �Ʒ��� ����Ű �Է��� ������ ��� -z ���� ���ֱ�
    rb.AddForce(0f, 0f, -speed);
}
if (Input.GetKey(KeyCode.LeftArrow) == true) {
    // ���� ����Ű �Է��� ������ ��� -x ���� ���ֱ�
    rb.AddForce(-speed, 0f, 0f);
}
if (Input.GetKey(KeyCode.RightArrow) == true) {
    // ������ ����Ű �Է��� ������ ��� x ���� ���ֱ�
    rb.AddForce(speed, 0f, 0f);*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; //�÷��̾� ������ٵ� ������Ʈ
    public float speed = 8f; //�̵� �ӵ�

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>(); //������ٵ� ������Ʈ ã��
    }

    void Update()
    {
        //�÷��̾� �̵�
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        //��� �� ���� ������Ʈ ��Ȱ��
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();
    }
}

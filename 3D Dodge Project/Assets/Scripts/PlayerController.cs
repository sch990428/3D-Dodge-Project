using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody; //플레이어 리지드바디 컴포넌트
    public float speed = 8f; //이동 속도

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>(); //리지드바디 컴포넌트 찾기
    }

    void Update()
    {
        //플레이어 이동
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        //사망 시 게임 오브젝트 비활성
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();
    }
}

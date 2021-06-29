using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipMovement : MonoBehaviour
{
    public GameObject Head; // 우주선을 가르키는 변수
    public GameObject Cam; // 카메라를 가르키는 변수

    float CurrRot; // 현재 회전 값
    float PrevRot; // 이전 회전 값
    float DeltRot; // 현재 회전 값과 이전 회전 값의 차이를 구해서 양/음 에 따라 어느 방향으로 회전시킬지를 결정

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Head.transform.Translate(Cam.transform.forward * Time.deltaTime);
        moverl();
    }

    void moverl()
    {
        CurrRot = Cam.tranform.eulerAngles.y;
        DeltRot = CurrRot - PrevRot;
        PrevRot = CurrRot;
    }
}

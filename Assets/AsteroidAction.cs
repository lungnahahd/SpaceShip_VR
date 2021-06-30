using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAction : MonoBehaviour
{
    public GameObject ExpObj;
    public GameObject Show;
    private void OnTriggerEnter(Collider other){
        ExpObj.SetActive(true); // 폭발 활성화
        Destroy(Show);
        Invoke("RealDestroy",2);
    }

    void RealDestroy(){
        Destroy(this.gameObject);
    }

}

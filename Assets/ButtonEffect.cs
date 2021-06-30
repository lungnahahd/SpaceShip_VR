using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEffect : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("InGame");
    }
}

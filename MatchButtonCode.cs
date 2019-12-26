using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchButtonCode : MonoBehaviour
{
    public void startTextScene(){
        SceneManager.LoadScene("TextingScene");
    }
}

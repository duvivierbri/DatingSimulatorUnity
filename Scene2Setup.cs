using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This code ensures that everything in the ProfileScene starts up properly!

public class Scene2Setup : MonoBehaviour
{
    public GameObject inputText;
    public GameObject boyBtn;
    public GameObject girlBtn;

    // Start is called before the first frame update
    void Start()
    {
        inputText.SetActive(false);
        boyBtn.SetActive(false);
        girlBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

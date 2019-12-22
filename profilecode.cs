using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profilecode : MonoBehaviour{
    public Text officialName;
    public Text dialogText;
    public GameObject textField;
    public GameObject button;
    int num = 0;

    // Start is called before the first frame update
    void Start(){

    }

    public void changeDialog(){
        string name = officialName.text;
        string[] dialog = { "Hi! Welcome to Sender, the online dating app for all of your dating needs!",
        "Are you knew here?",
        "You are? Great! I'm Bunnie and I'll be your dating coach for your new journey!",
        "Now, when you're starting on a dating website, we will need some information from you, so let's start by filling our this questionaire so we can get to know a bit more about you!",
        "What is your name?", "Awesome! Nice to meet you " + name + "!",
        "What a nice name..." + name };
        string currDialog = dialog[num];
        dialogText.text = currDialog;

        if (num == dialog.Length - 1){ //ensures dialog doesn't go out of bournds
            num = dialog.Length - 1;
            Debug.Log("Dialog is done!");
        }
        else{
            num++;
            Debug.Log(num);
        }

        //This brings up the textbox when it's time to write your name!
        if (num == 5){
            textField.SetActive(true);
        }
        else{
            textField.SetActive(false);
        }

    }

    private void getName()
    {
        
    }
    // Update is called once per frame
    void Update(){
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profilecode : MonoBehaviour{
    public Text officialName;
    public Text dialogText;
    public GameObject textField;
    public GameObject guideBtn;
    public GameObject girlButton;
    public GameObject boyButton;
    public bool lookingForGirls;
    public bool lookingForBoys;
    int num = 0;

    // Start is called before the first frame update
    void Start(){
        lookingForGirls = false;
        lookingForBoys = false;
    }

    //SETTERS
    public void setWomenChosen(bool a)
    {
        lookingForGirls = a;
    }

    public void setMenChosen(bool a)
    {
        lookingForBoys = a;
    }

    //GETTERS
    public bool getWomenChosen()
    {
        return lookingForGirls;
    }

    public bool getMenChosen()
    {
        return lookingForBoys;
    }

    //Keeps track of the intro dialog
    public void changeDialog(){
        string name = officialName.text;
        string[] dialog = { "Hi! Welcome to Sender, the online dating app for all of your dating needs!",
        "Are you knew here?",
        "You are? Great! I'm Bunnie and I'll be your dating coach for your new journey!",
        "Now, when you're starting on a dating website, we will need some information from you, so let's start by filling our this questionaire so we can get to know a bit more about you!",
        "What is your name?", "Awesome! Nice to meet you " + name + "!",
        "What a nice name..." + name ,
        "Now, what are you looking for?",
        "Awesome!"};
        string currDialog = dialog[num];
        dialogText.text = currDialog;

        if (num == dialog.Length - 1){ //ensures dialog doesn't go out of bournds
            num = dialog.Length - 1;
            Debug.Log("Dialog is done!");
        }else{
            num++;
            Debug.Log(num);
        }

        //This brings up the textbox when it's time to write your name!
        if (num == 5){
            textField.SetActive(true);
        }else{
            textField.SetActive(false);
        }

        //This enables the buttons to select whether you are looking for men or women!
        if (num == 8){
            girlButton.SetActive(true);
            boyButton.SetActive(true);
            guideBtn.SetActive(false);

        } else{
            girlButton.SetActive(false);
            boyButton.SetActive(false);
            guideBtn.SetActive(true);
        }
    } //End of guide button code

    //Methods for choosing who the player is looking for 
    public void makeWomenTrue() {
        setWomenChosen(true);
        setMenChosen(false);
        dialogText.text = "You've decided you want to look for women! Press continue if this is correct...";
        Debug.Log("The player is now looking for women!");
    }

    public void makeMenTrue(){
        setMenChosen(true);
        setWomenChosen(false);
        dialogText.text = "You've decided you want to look for men! Press continue if this is correct...";
        Debug.Log("The player is now looking for men!");
    }

    
}

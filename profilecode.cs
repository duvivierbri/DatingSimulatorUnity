using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class profilecode : MonoBehaviour{
    public Text officialName;
    public Text dialogText;
    public GameObject textField;
    public GameObject guideBtn;
    public GameObject girlButton;
    public GameObject boyButton;
    public static bool lookingForWomen;
    public static bool lookingForMen;
    public bool womenSelected;
    public bool menSelected;
    int num = 0;

    // Start is called before the first frame update
    void Start(){

    }

    //SETTERS
    public void setWomenChosen(bool a)
    {
        lookingForWomen = a;
    }

    public void setMenChosen(bool a)
    {
        lookingForMen = a;
    }

    //GETTERS
    public bool getWomenChosen()
    {
        return lookingForWomen ;
    }

    public bool getMenChosen()
    {
        return lookingForMen;
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
        "Awesome!",
        "Well, that's all I need to know... let me just use this info to bring up potential candidates. One moment please!",
        ""};
        string currDialog = dialog[num];
        dialogText.text = currDialog;

        if (num == dialog.Length - 1){ //ensures dialog doesn't go out of bournds
            num = dialog.Length - 1;
            Debug.Log("Next Scene!");
            SceneManager.LoadScene("ChooseADate");
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
            
        } 

        if (num == 9)
        {
            girlButton.SetActive(false);
            boyButton.SetActive(false);
        }

        
    } //End of guide button code

    void Update(){
        womenSelected = lookingForWomen ;
        menSelected = lookingForMen;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseADate : MonoBehaviour
{
    int num = -1;
    public bool maleProfiles;
    public bool femaleProfiles;
    public GameObject[] options;
    public GameObject girl1;
    public GameObject girl2;
    public GameObject girl3;
    public GameObject boy1;
    public GameObject boy2;
    public GameObject boy3;
    public Text Name;
    public Text occupation;
    public Text gender;
    public Text description;
    // Start is called before the first frame update
    void Start(){
        
    }

    public void scrollThoughDates(){
        num++;

        if (num == 3)
        {
            num = 0;
        }

        profilePictures(num);
        if (profilecode.lookingForMen){
            
            Debug.Log("You are now looking at man #" + num);
        } else if (profilecode.lookingForWomen){
            Debug.Log("You are now looking at woman #" + num);
        }

        
    }

    // Update is called once per frame
    void Update(){

    }

    //Controls the profiles! Fun!
    void profilePictures( int num)
    {
        if (profilecode.lookingForMen)
        {
            gender.text = "Gender: Male";
            if (num == 0) { 
                //Geeky and smart
                boy1.SetActive(true);
                Name.text = "Name: Justin";
                occupation.text = "Occupation: Tour Guide at an Art Museum";
                description.text = "Description: ";

            }
            else
            {
                boy1.SetActive(false);
            }

            if (num == 1)
            {
                //Posh or stuck up
                boy2.SetActive(true);
                Name.text = "Name: Alex";
                occupation.text = "Occupation: Professional Athlete";
                description.text = "Description: ";
            }
            else
            {
                boy2.SetActive(false);
            }

            if (num == 2)
            {
                //Emo
                boy3.SetActive(true);
                Name.text = "Name: Raymond";
                occupation.text = "Occupation: Published Poet";
                description.text = "Description: ";
            }
            else
            {
                boy3.SetActive(false);
            }
        }
        else if (profilecode.lookingForWomen)
        {
            gender.text = "Gender: Female";
            if (num == 0)
            {
                //Geeky and smart
                girl1.SetActive(true);
                Name.text = "Name: Sophia";
                occupation.text = "Occupation: Math tutor";
                description.text = "Description: Hi! \\(^-^)/ Just a young college graduate looking for someone to spend time with." +
                    "I love reading books, playing video games and going to museums. Send me a text!";
            }
            else
            {
                girl1.SetActive(false);
            }

            if (num == 1)
            {
                //Posh or stuck up
                girl2.SetActive(true);
                Name.text = "Name: Alexis";
                occupation.text = "Occupation: Fashion Design Intern";
                description.text = "Description: Shopping is my passion. Honestly, dont even try if you don't own anything designer.";
            }
            else
            {
                girl2.SetActive(false);
            }

            if (num == 2)
            {
                //Emo girl
                girl3.SetActive(true);
                Name.text = "Name: Opal";
                occupation.text = "Occupation: Professional DJ";
                description.text = "Description: ";
            }
            else
            {
                girl3.SetActive(false);
            }
        }
    }
}

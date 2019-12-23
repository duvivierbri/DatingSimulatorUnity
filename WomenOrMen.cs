using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomenOrMen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makeLookingForWomenTrue()
    {
        profilecode.lookingForWomen = true;
        profilecode.lookingForMen = false;
    }

    public void makeLookingForMenTrue()
    {
        profilecode.lookingForMen = true;
        profilecode.lookingForWomen = false;
    }
}

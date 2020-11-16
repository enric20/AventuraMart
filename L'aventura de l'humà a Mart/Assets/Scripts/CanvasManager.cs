using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    
    public GameObject storyText;

    public void StoryTextContinue()
    {
        storyText.SetActive(false);
    }
    

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalUIControl : MonoBehaviour
{
    bool showStoryUI = true;
    public GameObject storyCanvas;

    void Awake()
    {
        if (!showStoryUI) {
            storyCanvas.SetActive(false);
        }
    }

    public void CloseUI(GameObject selectedUI)
    {
        selectedUI.SetActive(false);
    }

    public void OpenUI(GameObject selectedUI)
    {
        selectedUI.SetActive(true);
    }

    public void CloseStoryUIPermanent()
    {
        storyCanvas.SetActive(false);
        showStoryUI = false;
    }

    
}

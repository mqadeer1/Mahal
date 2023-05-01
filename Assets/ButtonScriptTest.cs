using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScriptTest : MonoBehaviour
{
    public GameObject[] vendorPanels;
    public GameObject[] dialogueButtons;

    public GameObject vendor1Button;
    public GameObject vendor2Button;
    public GameObject[] textPanels;
    public GameObject[] buttonTexts;

    private Button vendor1ButtonComponent;
    private Button vendor2ButtonComponent;
    private Button[] dialogueButtonComponents; 

 
    private void Start()
    {
        vendor1ButtonComponent = vendor1Button.GetComponent<Button>();
        vendor2ButtonComponent = vendor2Button.GetComponent<Button>();
        dialogueButtonComponents = new Button[dialogueButtons.Length];
        for (int i = 0; i < dialogueButtons.Length; i++)
        {
            dialogueButtonComponents[i] = dialogueButtons[i].GetComponent<Button>();
        }

        vendor1ButtonComponent.onClick.AddListener(() => ShowVendorPanel(1));
        vendor2ButtonComponent.onClick.AddListener(() => ShowVendorPanel(2));
        for (int i = 0; i < dialogueButtons.Length; i++)
        {
            int index = i;
            dialogueButtonComponents[i].onClick.AddListener(() => ShowVendorPanel(index ++));
        }

       
    }


    public void ShowVendorPanel(int panelIndex)
    {
        for (int i = 0; i < vendorPanels.Length; i++)
        {
            if (i == panelIndex)
            {
                vendorPanels[i].SetActive(true);
            }
            else
            {
                vendorPanels[i].SetActive(false);
            }
        }

        for (int i = 0; i < textPanels.Length; i++)
        {
            if (i == panelIndex - 2)
            {
                textPanels[i].SetActive(false);
                buttonTexts[i].SetActive(false);
            }
            else
            {
                textPanels[i].SetActive(true);
                buttonTexts[i].SetActive(true);
            }
        }

        vendor1ButtonComponent.interactable = panelIndex != 1;
        vendor2ButtonComponent.interactable = panelIndex != 2;

        for (int i = 0; i < dialogueButtonComponents.Length; i++)
        {
            dialogueButtonComponents[i].interactable = panelIndex == i ++;
        }

      
    }

  

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript1 : MonoBehaviour
{
    public GameObject vendor1Panel;
    public GameObject vendor2Panel;
    public GameObject vendor1Text;
    public GameObject vendor2Text;
    public Button vendor1Button;
    public Button vendor2Button;

    private bool vendor1Active = false;
    private bool vendor2Active = false;

    private void Start()
    {
        vendor1Button.interactable = true;
        vendor2Button.interactable = true;
    }

    public void ShowVendor1Panel()
    {
        vendor1Panel.SetActive(true);
        vendor2Panel.SetActive(false);
        vendor1Active = true;
        vendor2Active = false;
        UpdateButtonInteractable();
    }

    public void ShowVendor2Panel()
    {
        vendor2Panel.SetActive(true);
        vendor1Panel.SetActive(false);
        vendor2Active = true;
        vendor1Active = false;
        UpdateButtonInteractable();
    }

    public void ShowVendor1Text()
    {
        vendor1Text.SetActive(true);
        vendor2Text.SetActive(false);
    }

    public void ShowVendor2Text()
    {
        vendor2Text.SetActive(true);
        vendor1Text.SetActive(false);
    }

    private void UpdateButtonInteractable()
    {
        if (vendor1Active && !vendor2Active)
        {
            vendor1Button.interactable = true;
            vendor2Button.interactable = false;
        }
        else if (vendor2Active && !vendor1Active)
        {
            vendor2Button.interactable = true;
            vendor1Button.interactable = false;
        }
        else
        {
            vendor1Button.interactable = true;
            vendor2Button.interactable = true;
        }
    }
}

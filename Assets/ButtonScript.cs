using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject vendor1Panel;
    public GameObject vendor2Panel;
    public GameObject vendor1Panel2;
    public GameObject vendor1Panel3;
    public GameObject vendor1Panel4;
    public GameObject vendor1Panel5;
    public GameObject vendor1Panel6;
    public GameObject vendor1Panel7;
   // public GameObject vendor1Panel7;

    //panel 1 activate
    public GameObject vendor1Button;
    public GameObject vendor2Button;
    public GameObject vendor1Text;
    public GameObject vendor2Text;
    public GameObject button1Text;
    public GameObject button2Text;

    //dialogues buttons
    public GameObject vendor1dialogue1Button1;
    public GameObject vendor1dialogue2Button1;
    public GameObject vendor1dialogue3Button1;
    public GameObject vendor1dialogue4Button1;
    public GameObject vendor1dialogue5Button1;
    public GameObject vendor1dialogue1Button2;
    public GameObject vendor1dialogue2Button2;

  
    private Button vendor1ButtonComponent;
    private Button vendor2ButtonComponent;
    private Button vendor1dialogue1Button1Component;
    private Button vendor1dialogue2Button1Component;
    private Button vendor1dialogue3Button1Component;
    private Button vendor1dialogue4Button1Component;
    private Button vendor1dialogue5Button1Component;
    private Button vendor1dialogue1Button2Component;
    private Button vendor1dialogue2Button2Component;

    

    private void Start()
    {
        // Get the Button components from the game objects
        vendor1ButtonComponent = vendor1Button.GetComponent<Button>();
        vendor2ButtonComponent = vendor2Button.GetComponent<Button>();
        vendor1dialogue1Button1Component = vendor1dialogue1Button1.GetComponent<Button>();
        vendor1dialogue2Button1Component = vendor1dialogue2Button1.GetComponent<Button>();
        vendor1dialogue3Button1Component = vendor1dialogue3Button1.GetComponent<Button>();
        vendor1dialogue4Button1Component = vendor1dialogue4Button1.GetComponent<Button>();
        vendor1dialogue5Button1Component = vendor1dialogue5Button1.GetComponent<Button>();
        vendor1dialogue1Button2Component = vendor1dialogue1Button2.GetComponent<Button>();
        vendor1dialogue2Button2Component  = vendor1dialogue2Button2.GetComponent<Button>();
       
        // Add listeners to the buttons
        vendor1ButtonComponent.onClick.AddListener(ShowVendor1Panel);
        vendor2ButtonComponent.onClick.AddListener(ShowVendor2Panel);
        vendor1dialogue1Button1Component.onClick.AddListener(ShowVendor1Panel3);
        vendor1dialogue2Button1Component.onClick.AddListener(ShowVendor1Panel4);
        vendor1dialogue3Button1Component.onClick.AddListener(ShowVendor1Panel5);
        vendor1dialogue4Button1Component.onClick.AddListener(ShowVendor1Panel6);
        vendor1dialogue5Button1Component.onClick.AddListener(ShowVendor1Panel7);
        vendor1dialogue1Button2Component.onClick.AddListener(ShowVendor1Panela);
        vendor1dialogue2Button2Component.onClick.AddListener(ShowVendor1Panel2a);
    }


    public void ShowVendor1Panel()
    {
        // Show vendor 1 panel and hide vendor 2 panel
        vendor1Panel.SetActive(true);
        vendor2Panel.SetActive(false);


        // Disable vendor 2 button and text panel
        vendor2ButtonComponent.interactable = false;
        vendor2Text.SetActive(false);
        button2Text.SetActive(false);

        // Disable vendor 1 button and text panel and enable the dialogue button
        vendor1ButtonComponent.interactable = false;
        vendor1Text.SetActive(false);
        button1Text.SetActive(false);

    }

    public void ShowVendor1Panel2(){
        vendor1Panel2.SetActive(true);
       vendor1Panel.SetActive(false);     
    }

     public void ShowVendor1Panela(){
         vendor1Panel.SetActive(true); 
         vendor1Panel2.SetActive(false);
        
    }

    

    public void ShowVendor1Panel3(){
        vendor1Panel3.SetActive(true);
        vendor1Panel2.SetActive(false);
    }

    public void ShowVendor1Panel2a(){
        vendor1Panel2.SetActive(true);
        vendor1Panel3.SetActive(false);
    }

    public void ShowVendor1Panel4(){
        vendor1Panel4.SetActive(true);
        vendor1Panel3.SetActive(false);
    }

    public void ShowVendor1Panel5(){
        vendor1Panel5.SetActive(true);
        vendor1Panel4.SetActive(false);
    }

    public void ShowVendor1Panel6(){
        vendor1Panel6.SetActive(true);
        vendor1Panel5.SetActive(false);
    }

    public void ShowVendor1Panel7(){
        vendor1Panel7.SetActive(true);
        vendor1Panel6.SetActive(false);   
    }


   

    public void ShowVendor2Panel()
    {
        // Show vendor 2 panel and hide vendor 1 panel
        vendor2Panel.SetActive(true);
        vendor1Panel.SetActive(false);

        // Disable vendor 1 button and text panel
        vendor1ButtonComponent.interactable = false;
        vendor1Text.SetActive(false);
        button1Text.SetActive(false);

        // Enable vendor 2 button and text panel
        vendor2ButtonComponent.interactable = false;
    
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;  

    public GameObject userMenu;
    public GameObject locomotionMenu;

    public bool userMenuActive = false;
    public bool locomotionMenuActive = false;
    //fuck alex

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        userMenu.SetActive(false);
        locomotionMenu.SetActive(false);
    }

    void Update ()
    {
        if (Controller.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            if (!userMenuActive && !locomotionMenuActive)
            {
                userMenu.SetActive(true);
                userMenuActive = true;
            }
            else
            {
                userMenu.SetActive(false);
                userMenuActive = false;
            }
        }
    }
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }
    public void LocomotionMenuToggle()
    {
        if (!locomotionMenuActive)
        {
            locomotionMenu.SetActive(true);
            locomotionMenuActive = true;
            userMenu.SetActive(false);
            userMenuActive = false;
        }
        else
        {
            locomotionMenu.SetActive(false);
            locomotionMenuActive = false;
            userMenu.SetActive(true);
            userMenuActive = true;
        }
    }
}

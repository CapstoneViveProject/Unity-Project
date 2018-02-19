using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;

    public GameObject leftController;
    public GameObject rightController;

    public GameObject userMenu;
    public GameObject locomotionMenu;
    public GameObject levelMenu;

    public bool userMenuActive = false;
    public bool locomotionMenuActive = false;

    //public Button teleport;
    //public Button worldGrab;
    //public Button blink;
    //public Button armSwing;
    //public Button slide;
    //public Button exit;
    //fuck alex

    Menu menu;
    ControllerGrabObject cGOL;
    ControllerGrabObject cGOR;

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        userMenu.SetActive(false);
        locomotionMenu.SetActive(false);
        levelMenu.SetActive(false);
        locomotionMenu.SetActive(false);
    }
    void Start()
    {
        menu = leftController.GetComponent<Menu>();
        cGOL = leftController.GetComponent<ControllerGrabObject>();
        cGOR = rightController.GetComponent<ControllerGrabObject>();
    }
    void Update()
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
                locomotionMenu.SetActive(false);
                levelMenu.SetActive(false);
                userMenuActive = false;
            }
        }
    }
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }
    //public void LocomotionMenuToggle()
    //{
    //    if (!locomotionMenuActive)
    //    {
    //        locomotionMenu.SetActive(true);
    //        locomotionMenuActive = true;
    //        userMenu.SetActive(false);
    //        userMenuActive = false;
    //    }
    //    else
    //    {
    //        locomotionMenu.SetActive(false);
    //        locomotionMenuActive = false;
    //        userMenu.SetActive(true);
    //        userMenuActive = true;
    //    }
    //}
    public void onLocomotionPress()
    {
        userMenu.SetActive(false);
        locomotionMenu.SetActive(true);
    }
    public void onLevelSelectPress()
    {
        userMenu.SetActive(false);
        levelMenu.SetActive(true);
    }
    public void onTeleportPress()
    {
        cGOL.locomotionSetting = 0;
        cGOR.locomotionSetting = 0;
    }
    public void onWorldGrabPress()
    {
        cGOL.locomotionSetting = 4;
        cGOR.locomotionSetting = 4;
        Debug.Log("World Grab Press");
    }
    public void onBlinkPress()
    {
        cGOL.locomotionSetting = 1;
        cGOR.locomotionSetting = 1;
    }
    public void onArmSwingPress()
    {
        cGOL.locomotionSetting = 3;
        cGOR.locomotionSetting = 3;
    }
    public void onSlidePress()
    {
        cGOL.locomotionSetting = 2;
        cGOR.locomotionSetting = 2;
    }
    public void onLocoExitPress()
    {
        userMenu.SetActive(true);
        locomotionMenu.SetActive(false);
    }
    public void onXRoomPress()
    {
        SceneManager.LoadScene("XRoom");
    }
    public void onObsatclePress()
    {
        SceneManager.LoadScene("ObstacleCourse");
    }
    public void onDemoPress()
    {
        SceneManager.LoadScene("DemoRoom");
    }
    public void onLevelExitPress()
    {
        userMenu.SetActive(true);
        levelMenu.SetActive(false);
    }
}

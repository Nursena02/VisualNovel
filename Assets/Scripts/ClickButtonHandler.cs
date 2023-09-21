using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickHandler : MonoBehaviour
{
    public GameObject panelToShow;
    public GameObject panelToHide; 
    public GameObject panelToShow2;
    public GameObject panelToHide2;
    public GameObject soundPanel;
    public GameObject settingsPanel;
    public GameObject soundPanelQuit;
    public GameObject settingsPanelReopen;

    public void OnButtonClick()
    {
        panelToShow.SetActive(true); 
        panelToHide.SetActive(false); 
    }


    public void OnButtonClick2()
    {
        panelToShow2.SetActive(true); 
        panelToHide2.SetActive(false); 
    }

    public void Sound()
    {
        soundPanel.SetActive(true);
        settingsPanel.SetActive(false);

    }
    public void Sound2()
    {
        settingsPanelReopen.SetActive(true);
        soundPanelQuit.SetActive(false);

    }
}

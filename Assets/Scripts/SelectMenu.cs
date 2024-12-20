using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMenu : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    [SerializeField] private Selectable[] defaultButtons;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("PanelToggle", 0.01f);
    }
    public void PanelToggle()
    {
        PanelToggle(0);
    }

    public void PanelToggle (int position)
    {
        Input.ResetInputAxes();
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(position == i);
            if (position == i)
            {
                defaultButtons[i].Select();
            }
        }
    }

    public void SavePrefs()
    {
        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

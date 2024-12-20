using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Slider))]
public class SetGFX : MonoBehaviour
{
    [SerializeField] private Text txtGFX; //Champ de texte sur la qualité
    private string[] GFXNames; //Liste de tous les pré-réglages de qualité
    private Slider slide;

    // Start is called before the first frame update
    void Start()
    {
        slide = GetComponent<Slider>(); // Récuppère le component slider
        GFXNames = QualitySettings.names; //Récuppère les pré-réglages de qualité
        float v = QualitySettings.GetQualityLevel(); //Donne le reglage actuel
        slide.value = v; //Mettre le bon paramètre sur le slider
        txtGFX.text = GFXNames[(int)v]; //Affiche le bon nom dans le champ de texte
    }

    public void SetGfx(float val)
    {
        int v = (int)Mathf.Floor(val); //convertir mon float en int
        slide.value = val;//assigne la valeur à mon slider 
        QualitySettings.SetQualityLevel(v, true); //Change la qualité du jeu
        txtGFX.text = GFXNames[v]; //Affiche le bon nom.

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

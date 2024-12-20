using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class Loading : MonoBehaviour
{

    private AsyncOperation async;
    [SerializeField] private Image progressbar; //l'image de la barre de progreesion
    [SerializeField] private Text txtPourcent; //Le champs de texte pour écrire le pourcentage
    [SerializeField] private bool waitForUserInput = false; //Attendre que le joueur appuis sur une touche
    private bool ready = false; //Toutes les conditions doivent être remplis avant de passer à la scene suivante 
    [SerializeField] private float delay = 0; //Délais avant de passer à la scène suivante.
    [SerializeField] private int sceneToLoad = -1; //Si = -1, alors passe à la scène suivante, sinon charge la scène X

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f; //Remet le timescale par défaut.
        Input.ResetInputAxes(); //vas réinitialiser les entrées durant 1 frame.
        System.GC.Collect(); //Appel au Garbage Collector pour venir vider la RAM
        Scene currentScene = SceneManager.GetActiveScene(); //Mémorise la scène actuelle.
        if (sceneToLoad < 0)
        {
            async = SceneManager.LoadSceneAsync(currentScene.buildIndex + 1); //Charge la scène suivante
        }
        else //Si la valeur est positive...
        {
            async = SceneManager.LoadSceneAsync(sceneToLoad); //Charge la scène X
        }
        async.allowSceneActivation = false; //Attendre avant de passer à la scène suivante.
        if (waitForUserInput == false)
        {
            Invoke("Activate", delay); //Activer la prochaine scène, après un délais x
        }
    }

    public void Activate() //Appel cette fonction quand on veut passer à la scène suivante.
    {
        ready = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (waitForUserInput && Input.anyKey)
        {
            ready = true;
        }
       
        if (progressbar)
        {
            progressbar.fillAmount = async.progress + 0.1f;
        }
        if (txtPourcent)
        {
            txtPourcent.text = ((async.progress + 0.1f)*100).ToString ("f2")+" %"; //98.54 %
        }
        if (async.progress > 0.89f && SplashScreen.isFinished && ready)
        {
            async.allowSceneActivation = true;
        }
    }
}

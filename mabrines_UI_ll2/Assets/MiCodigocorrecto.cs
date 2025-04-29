using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MiCodigocorrecto : MonoBehaviour
{
    UIDocument MiMenu;
    //Principal
    Button play_button;
    Button options_button;
    Button credits_button;
    Button quit_button;
    //Play
    VisualElement pantalla_play;
    Button back_01_button;
    //Options
    VisualElement pantalla_options;
    Button back_02_button;
    //Credits
    VisualElement pantalla_credits;
    Button back_03_button;

    private void OnEnable()
    {
        MiMenu = GetComponent<UIDocument>();
        VisualElement root = MiMenu.rootVisualElement;
        //Principal
        play_button = root.Q<Button>("boton-play");
        options_button = root.Q<Button>("boton-options");
        credits_button = root.Q<Button>("boton-credits");
        quit_button = root.Q<Button>("boton-quit");
        //Play
        pantalla_play = root.Q<VisualElement>("pantalla-play");
        back_01_button = root.Q<Button>("boton-back1");
        //Options
        pantalla_options = root.Q<VisualElement>("pantalla-options");
        back_02_button = root.Q<Button>("boton-back2");
        //Credits
        pantalla_credits = root.Q<VisualElement>("pantalla-credits");
        back_03_button = root.Q<Button>("boton-back3");

        //Callbacks
        //Play
        play_button.RegisterCallback<ClickEvent>(abrirpantalla_play);
        back_01_button.RegisterCallback<ClickEvent>(cerrarpantalla_play);
        //Options
        options_button.RegisterCallback<ClickEvent>(abrirpantalla_options);
        back_02_button.RegisterCallback<ClickEvent>(cerrarpantalla_options);
        //Credits
        credits_button.RegisterCallback<ClickEvent>(abrirpantalla_credits);
        back_03_button.RegisterCallback<ClickEvent>(cerrarpantalla_credits);
        //Quit
    }

    //PANTALLAPLAY
    void abrirpantalla_play(ClickEvent evt)
    {
        UnityEngine.Debug.Log("Starting...");
        pantalla_play.AddToClassList("pantallaplay-activo");
    }

    void cerrarpantalla_play(ClickEvent evt)
    {
        pantalla_play.RemoveFromClassList("pantallaplay-activo");
    }


    //PANTALLAOPTIONS
    void abrirpantalla_options(ClickEvent evt)
    {
        UnityEngine.Debug.Log("Coloring book or Free painting");
        pantalla_options.AddToClassList("options-activo");
    }

    void cerrarpantalla_options(ClickEvent evt)
    {
        pantalla_options.RemoveFromClassList("options-activo");
    }

    //PANTALLACREDITS
    void abrirpantalla_credits(ClickEvent evt)
    {
        UnityEngine.Debug.Log("Made by Maria Julia Abrines Rincon");
        pantalla_credits.AddToClassList("credits-activo");
    }

    void cerrarpantalla_credits(ClickEvent evt)
    {
        pantalla_credits.RemoveFromClassList("credits-activo");
    }

}
 




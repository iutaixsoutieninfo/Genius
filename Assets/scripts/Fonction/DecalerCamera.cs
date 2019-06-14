﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DecalerCamera : MonoBehaviour {

    public Camera cameraJeu;
    public float valueX = 540;
    public float valueY = 0;

	public void MettreEcranVisible()
    {
        // On trouve le nom de l'écran cliqué
        string nomEcran = EventSystem.current.currentSelectedGameObject.transform.parent.name;
        GameObject ecran = GameObject.Find(nomEcran);

        // On recherche l'écran suivant
        string suivant = nomEcran.Substring(7);
        suivant = suivant.Substring(0, suivant.Length-1);
        int suivantInt = Int32.Parse(suivant);
        ++suivantInt;
        string nomEcranSuivant = "Ecran (" + suivantInt.ToString() + ")";
        Debug.Log(nomEcranSuivant);

        GameObject ecranSuivant = GameObject.Find(nomEcranSuivant);

        // On "cache" l'écran cliqué et on affiche l'écran suivant
        ecran.transform.position = new Vector3(valueX, valueY);
        ecranSuivant.transform.position = new Vector3(0, valueY);
    }

    /*
    public void MettreEcranVisible()
    {
        cameraJeu.transform.position = new Vector3(valueX, valueY, -380);
    }
    */
}
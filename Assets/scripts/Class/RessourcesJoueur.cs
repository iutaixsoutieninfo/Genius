﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RessourcesJoueur : MonoBehaviour {
    //public Slider[] barres = new Slider[2];
    public Text[] textes = new Text[4];
    static public bool stop = false;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if(!stop)
        {
            if (Joueur.MesRessources != null)
            {
                for (int i = 0; i < Joueur.MesRessources.Length; ++i)
                {
                    switch (RessourcesBdD.listeDesRessources[i].NomRessource)
                    {
                        // SOCIAL
                        case "Social":
                            //barres[0].value = (Joueur.MesRessources[i]);
                            textes[0].text = Joueur.MesRessources[i].ToString() + "%";
                            break;

                        // DIVERTISSEMENT
                        case "Divertissement":
                            //barres[1].value = (Joueur.MesRessources[i]);
                            textes[1].text = Joueur.MesRessources[i].ToString() + "%";
                            break;

                        //ORCUS
                        case "Orcus":
                            textes[2].text = getPriceInK(Joueur.MesRessources[i]);
                            break;

                        // MATIERE IA
                        case "IA":
                            textes[3].text = getPriceInK(Joueur.MesRessources[i]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    // Return the k price, example : 12000 -> 12k
    public static string getPriceInK(int price) 
    {
        if (price >= 10000)
        {
            string kPrice = price.ToString();
            return kPrice.Substring(0, 2) + "k";
        }
        else if(price >= 1000)
        {
            string kPrice = price.ToString();
            return kPrice.Substring(0, 1) + "k";
        }
        else
        {
            return price.ToString();
        }
    }
}

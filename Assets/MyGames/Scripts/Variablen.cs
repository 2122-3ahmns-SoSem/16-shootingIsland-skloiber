using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variablen : MonoBehaviour
{

    Color farbe;
    int x;
    int anzTueren1;
    int anzTueren2;
    int anzTueren3;
    int anzTuerenInstanz = 4;
    bool fahren;
    string name;
   


    public enum Himmelsrichtung 
{
	Nord,
	Sued,
	West,
	Ost,
}


        //Ich habe es gemeinsam mit Vanessa Dürnberger und Laura Forsthuber gemacht. :)
void Start()
    {
        Debug.Log(
            Himmelsrichtung.Nord + "" + Himmelsrichtung.Sued + "" + Himmelsrichtung.West + "" + Himmelsrichtung.Ost);

      
        int anzTueren1 = 8, anzTueren2 = 4, anzTueren3 = 600;  //Wenn man eine Anzahl berechnen will.
        Debug.Log(anzTueren1 + anzTueren2 + anzTueren3);  
        
        Debug.Log(anzTueren2 > anzTueren3); // returns False, weil anzTueren größer ist.

        string name = "Sophie";     //Wenn man jemanden anreden will.
        Debug.Log("Hello " + name);

        Color farbe = Color.blue;  //Wenn das Gameobject Blau werden soll.
        Debug.Log(farbe);
        gameObject.GetComponent<Renderer>().material.color = farbe;

        farbe = Color.red;
        Debug.Log(farbe.ToString());

                                                    //Spagetti-Code für einzelne Werte-ausgabe
                    
        farbe = Color.red;
        Debug.Log("Red " + farbe.ToString());       //to string name des Gameobject

        farbe = Color.yellow;
        Debug.Log("Yellow " + farbe.ToString());

        farbe = Color.white;
        Debug.Log("White " + farbe.ToString());

        Debug.Log(x.ToString());
        Debug.Log(anzTuerenInstanz.ToString());//nimm instanz
        Debug.Log("bool fahren " + fahren.ToString());

        //Lokal schlägt Instanz
        int anzTueren = int.Parse("4");
        float anzTuerenf = float.Parse("4");

        Debug.Log(anzTueren + " " + anzTuerenf + " " + anzTuerenInstanz);
    }

        }

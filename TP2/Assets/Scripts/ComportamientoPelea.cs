using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoPelea : MonoBehaviour
{

    Arma armaP1 = new Arma("Puño", 14);
    Arma armaP2 = new Arma("Puño", 18);
    Personaje p1 = new Personaje("Ken", 100, 40, 40);
    Personaje p2 = new Personaje("Ryu", 100, 30, 40);

    // Start is called before the first frame update
    void Start()
    {
        p1.Arma = armaP1;
        p2.Arma = armaP2;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && p2.Nombre == "Ryu")
        {
           p2.Pegar(p1);  
        }

        if (Input.GetKeyDown(KeyCode.P) && p1.Nombre == "Ken")
        {
           p1.Pegar(p2);
        }
        
    }

}

    public class Personaje
    {
        public string Nombre { get; set; }
        public float Vida { get; set; }
        public float Defensa { get; set; }
        public float Fuerza { get; set; }
        public Arma Arma { get; set; }

        public Personaje(string nombre, float vida, float defensa, float fuerza)
        {
            Nombre = nombre;
            Vida = vida;
            Defensa = defensa;
            Fuerza = fuerza;
        }

        public void Pegar(Personaje unPersonaje)
        {

            if(unPersonaje.Vida > 0 && Vida > 0)
            {
                unPersonaje.Vida -= Fuerza + Arma.CapacidadDeAtaque - unPersonaje.Defensa;
                if (unPersonaje.Vida <= 0 || Vida <= 0)
                {
                    Debug.Log("------GAME OVER------");

                    if (unPersonaje.Vida > Vida)
                    {
                        Debug.Log("Gano " + unPersonaje.Nombre);
                    }
                    else
                    {
                        Debug.Log("Gano " + Nombre);
                    }
                } else {
                    Debug.Log(Nombre + " pego una piña!!!");
                    Debug.Log("Vida restante de " + unPersonaje.Nombre + ": " + unPersonaje.Vida);
                }
                
            }

        }
    }

    public class Arma
    {
        public string Nombre { get; set; }
        public float CapacidadDeAtaque { get; set; }

    public Arma(string nombre, float capacidadDeAtaque)
    {
        Nombre = nombre;
        CapacidadDeAtaque = capacidadDeAtaque;
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ComportamientoTienda : MonoBehaviour
{

    void Start()
    {
        Random rnd = new Random();

        string randomString = (string)rnd.Next('a', 'z') + (string)rnd.Next('a', 'z') + (string)rnd.Next('a', 'z') + (string)rnd.Next('a', 'z') + (string)rnd.Next('a', 'z') + (string)rnd.Next('a', 'z') + (string)rnd.Next('a', 'z');

        int randomNum = Random.Range(-10000, 10000);

        Dictionary<string, int> itemTienda = new Dictionary<string, int>();

        itemTienda.Add(randomString, randomNum);


    }



    public class ItemTienda
    {
        public string Nombre { get; set; }

        public int Costo { get; set; }

    }



    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoTienda : MonoBehaviour
{
    public Dictionary<string, int> Tienda = new Dictionary<string, int>();
    public List<ItemTienda> ItemsOrdenados = new List<ItemTienda>();
    public int cantidadItems;

    void Start()
    {
        
        for(int i=0; i<cantidadItems; i++)
        {
            ItemTienda item = new ItemTienda(randomString(), randomInt());
            Tienda.Add(item.Nombre, item.Costo);
        }

        for(int i = 0; i < cantidadItems; i++)
        {
            ItemsOrdenados.Add(Mayor(Tienda));
            Tienda.Remove(Mayor(Tienda).Nombre);
        }

        foreach(ItemTienda item in ItemsOrdenados)
        {
            Debug.Log(item.Nombre + " ---- " + item.Costo);
        }
    }

    public ItemTienda Mayor(Dictionary<string, int> diccionario)
    {
        ItemTienda itemMayorCosto = new ItemTienda("a", 0);
        foreach (KeyValuePair<string, int> objetoActual in Tienda)
        {
            if (objetoActual.Value > itemMayorCosto.Costo)
            {
                itemMayorCosto = new ItemTienda(objetoActual.Key, objetoActual.Value);
            }
        }
        return itemMayorCosto;
    }

    public string randomString()
    {
        string rString = "";
        string[] characters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        for (int i = 0; i <= 10; i++)
        {
            rString = rString + characters[Random.Range(0, characters.Length)];
        }

        return rString;
    }

    public int randomInt()
    {
        int rInt = Random.Range(1, 500);

        return rInt;
    }


    public class ItemTienda
    {
        public string Nombre { get; set; }

        public int Costo { get; set; }

        public ItemTienda(string nombre, int costo)
        {
            Costo = costo;
            Nombre = nombre;
        }

    }



    void Update()
    {

    }
}

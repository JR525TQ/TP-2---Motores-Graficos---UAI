
using UnityEngine;

public class ComportamientoTienda : MonoBehaviour
{
    
    void Start()
    {
        
    }


    public class ItemTienda
    {
        public string Nombre { get; set; }

        public int Costo { get; set; }
    }

    ItemTienda<string, int> itemtienda = new ItemTienda<string, int>();


    


    void Update()
    {
        
    }
}

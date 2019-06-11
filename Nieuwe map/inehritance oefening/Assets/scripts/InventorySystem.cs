using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventorySystem : MonoBehaviour{

    public List<ItemClass> inventory = new List<ItemClass>();
    public ItemClass i;
    public GameObject voorwerp;
    public void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //{
        //    ToInv();    
        //}

        //if (Input.GetMouseButtonDown(1))
        //{
        //    FromInv();
        //}
    }

   public void ToInv()
    {
        inventory.Add(i);
    }

   public void FromInv()
    {
        inventory.Remove(i);
    }
}


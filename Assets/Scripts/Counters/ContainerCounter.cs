using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabbedObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;


    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no KO
            if (player.HasKitchenObject())
            {
                // player has KO
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // player has no KO
                KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);
                OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
            }
        }
        else
        {
            // There is KO
            if (player.HasKitchenObject())
            {
                // player has KO
            }
            else
            {
                // player has no KO
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
        
    }
}

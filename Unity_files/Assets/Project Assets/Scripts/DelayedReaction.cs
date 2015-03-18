﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Contient une réaction à retardement, c'est-à-dire une réaction qui a un effet sur le joueur au bout d'un certain nombre de tours
/// </summary>
public class DelayedReaction : Reaction {

    /// <summary>
    /// Constructeur de la réaction
    /// </summary>
    /// <param name="tReagents">Un texte contenant les réactifs</param>
    /// <param name="tProducts">Un texte contenant les produits</param>
    /// <param name="lReagents">Une liste de réactifs sous la forme ((H,2),(O,1))</param>
    /// <param name="nType">Le type de réaction</param>
	public DelayedReaction(string tReagents, string tProducts, List<KeyValuePair<Element,int>> lReagents, ReactionType nType, int cCost, int gGain) : 
        base(tReagents,tProducts,lReagents,nType, cCost, gGain) {
	}

	public void inflict(Player cible) {

	}

    public override void effect(Player maker) {
        GameObject dialog = (GameObject) GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/SelectPlayerDialog"));
        Player currentPlayer = Main.currentPlayer();
        foreach (Player p in Main.players) {
            if (p != currentPlayer) {
                GameObject playerSelector = (GameObject) GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/PlayerSelector"));
                Main.addClickEvent(playerSelector, delegate {
                    inflict(p);
                });
            }
        }
    }
}

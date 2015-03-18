﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Contient les informations d'une réaction chimique : réactifs, produits
/// </summary>
public abstract class Reaction {

	public string reagents  { private set; get; } // Texte contenant les réactifs
	public string products  { private set; get; } // Texte contenant les produits
	public List<KeyValuePair<Element,int>> reagentsList { get; private set; } // Liste de couples (élément, stoechiométrie)
	public ReactionType type { private set; get; } // Type de réaction (glace, feu, etc)
    public int cost { private set; get; }
    public int gain { private set; get; }
    
    /// <summary>
    /// Constructeur de la réaction
    /// </summary>
    /// <param name="tReagents">Un texte contenant les réactifs</param>
    /// <param name="tProducts">Un texte contenant les produits</param>
    /// <param name="lReagents">Une liste de réactifs sous la forme ((H,2),(O,1))</param>
    /// <param name="nType">Le type de réaction</param>
    /// <param name="cCost">Le coût de la réaction</param>
    /// <param name="gGain">Le gain d'énergie apporté par la réaction</param>
	public Reaction(string tReagents, string tProducts, List<KeyValuePair<Element,int>> lReagents, ReactionType nType, int cCost, int gGain) {
		reagents = tReagents;
		products = tProducts;
		reagentsList = lReagents;
		type = nType;
        cost = cCost;
        gain = gGain;
	}

    public abstract void effect(Player maker);
}

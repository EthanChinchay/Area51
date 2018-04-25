using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEntity : MonoBehaviour {

    public int lifePoints;
	
    public void DecreaseLife (int amount) {
        lifePoints -= amount;
        if (lifePoints <= 0) {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    bool isSinking = false;

    // Accessed from an event in the enemy's Death animation
    public void StartSinking()
    {
        //The enemy is now sinking
        isSinking = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public Enemy[] enemies;
    public SmashObject[] pots;

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            foreach (Enemy enemy in enemies)
                ChangeActivation(enemy, true);

            foreach (SmashObject pot in pots)
                ChangeActivation(pot, true);
        }
    }

    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            foreach (Enemy enemy in enemies)
                ChangeActivation(enemy, false);

            foreach (SmashObject pot in pots)
                ChangeActivation(pot, false);
        }
    }

    public void ChangeActivation(Component component, bool activate)
    {
        component.gameObject.SetActive(activate);
    }
}

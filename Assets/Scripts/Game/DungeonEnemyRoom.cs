using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonEnemyRoom : DungeonRoom
{
    public Door[] doors;

    private void Start()
    {
        OpenDoors();
    }

    public virtual void CheckEnemies()
    {
        OpenDoors();
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            foreach (Enemy enemy in enemies)
                ChangeActivation(enemy, true);

            foreach (SmashObject pot in pots)
                ChangeActivation(pot, true);
            CloseDoors();
            virturalCamera.SetActive(true);
        }
    }

    protected override void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            foreach (Enemy enemy in enemies)
                ChangeActivation(enemy, false);

            foreach (SmashObject pot in pots)
                ChangeActivation(pot, false);

            virturalCamera.SetActive(false);
        }
    }

    public void CloseDoors()
    {
        for(int i = 0; i < doors.Length; i++)
        {
            doors[i].Close();
        }
    }

    public void OpenDoors()
    {
        for (int i = 0; i < doors.Length; i++)
        {
            doors[i].Open();
        }
    }
}

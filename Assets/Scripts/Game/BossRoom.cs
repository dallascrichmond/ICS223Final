using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossRoom : DungeonEnemyRoom
{
    public override void CheckEnemies()
    {
        OpenDoors();
        SceneManager.LoadScene("Win");
    }
}

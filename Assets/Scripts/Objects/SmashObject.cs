using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashObject : MonoBehaviour
{
    private Animator anim;
    public LootTable thisLoot;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void MakeLoot()
    {
        if (thisLoot != null)
        {
            PowerUp current = thisLoot.LootPowerup();
            if (current != null)
            {
                Instantiate(current.gameObject, transform.position, Quaternion.identity);
            }
        }
    }

    public void Smash()
    {
        anim.SetBool("smash", true);
        MakeLoot();
        StartCoroutine(BreakCo());
    }

    IEnumerator BreakCo()
    {
        yield return new WaitForSeconds(.3f);
        this.gameObject.SetActive(false);
    }
}

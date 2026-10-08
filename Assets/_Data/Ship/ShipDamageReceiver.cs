using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipDamageReceiver : DamageReceiver
{
    protected override void OnDead()
    {
        string fxName = this.GetOnDeadFXName();
        Destroy(transform.parent.gameObject);
        Transform fxOnDead = FXSpawner.Instance.Spawn(fxName, transform.position, transform.rotation);
        fxOnDead.gameObject.SetActive(true);
        SceneManager.LoadScene("GalaxyDemo");
    }

    protected virtual string GetOnDeadFXName()
    {
        return FXSpawner.smoke;
    }
}
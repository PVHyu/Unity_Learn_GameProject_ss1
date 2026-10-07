using System.Xml.Serialization;
using UnityEngine;

public abstract class Despawn : BaseMonoBehaviour
{
    protected virtual void FixedUpdate()
    {
        this.Despawning();
    }


    protected virtual void Despawning()
    {
        if(!this.CanDespawn()) return;
        this.DespawnObject();
    }

    public virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }

    protected abstract bool CanDespawn();
}
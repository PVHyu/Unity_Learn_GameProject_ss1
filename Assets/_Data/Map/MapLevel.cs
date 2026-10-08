using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLevel : LevelByDistance
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        this.MapSetTarget();
    }

    protected virtual void MapSetTarget()
    {
        ShipCtrl currentShip = PlayerCtrl.Instance.CurrentShip;
        if(currentShip == null) return;
        this.SetTarget(currentShip.transform);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOAppearObserver
{
    public void OnAppearStart();

    public void OnAppearFinish();
}
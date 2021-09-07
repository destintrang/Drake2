using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausableObject : MonoBehaviour
{
   public virtual void PauseObject()
    {
        this.enabled = false;
    }

    public virtual void UnpauseObject()
    {
        this.enabled = true;
    }


}

using UnityEngine;
using System.Collections;

namespace EnvStoryToolkit {
    public abstract class InteractiveObject : MonoBehaviour {
        abstract public bool OnAction();
    }
}

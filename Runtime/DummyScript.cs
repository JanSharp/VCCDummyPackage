using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace JanSharp
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class DummyScript : UdonSharpBehaviour
    {
        private void Start()
        {
            Debug.Log("Hello World!");
        }
    }
}

using UnityEngine;
using System.Collections;

namespace EnvStoryToolkit {
    public class Artefact : HoldableObject {
        public string Key;

        public AudioSource PaperNoise;

        public override bool OnPickUp() {
            ArtefactCreator.Create(Key);
            PaperNoise.Play();
            return true;
        }

        public override bool OnPutDown() {
            Debug.Log("on put down Artefact");
            ArtefactCreator.Destroy();
            return true;
        }
    }
}

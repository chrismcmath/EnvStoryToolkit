using UnityEngine;
using System.Collections;

namespace EnvStoryToolkit {
    public static class ArtefactCreator {
        public readonly static string PATH_ARTEFACTS = "Artefacts/{0}";

        private static Transform _Root;
        private static Transform Root {
            get { 
                if (_Root == null) {
                    _Root = CreateRoot();
                }
                return _Root;
            }
        }

        private static Transform CreateRoot() {
            //TODO: search for a valid canvas first
            GameObject root = new GameObject();
            Canvas canvas = root.AddComponent<Canvas>();
            return canvas.transform;
        }

        public static void Create(string key) {
            /*
               GlobalConfig.Instance.ArtefactRoot.SetActive(true);

               Sprite s = Resources.Load(string.Format(PATH_ARTEFACTS, key), typeof(Sprite)) as Sprite;
               if (s != null) {
               GlobalConfig.Instance.ArtefactImage.sprite = s;
               } else {
               Debug.Log("Could not find artefact with key " + key);
               }

               GlobalConfig.Instance.Player.GetComponent<MovementActivator>().Deactivate();
               */
        }

        public static void Destroy() {
            /*
               GlobalConfig.Instance.ArtefactRoot.SetActive(false);
               GlobalConfig.Instance.Player.GetComponent<MovementActivator>().Activate();
               */
        }
    }
}

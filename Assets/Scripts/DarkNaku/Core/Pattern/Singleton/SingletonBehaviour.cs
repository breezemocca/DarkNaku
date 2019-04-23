using UnityEngine;

namespace DarkNaku {
    public abstract class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour {
        private static object _lock = new object();
        private static bool _isQuitting = false;

        private static T _instance;
        public static T Instance {
            get {
                if (_isQuitting) return null;

                lock (_lock) {
                    if (_instance == null) {
                        _instance = FindObjectOfType(typeof(T)) as T;

                        if (_instance == null) {
                            GameObject go = new GameObject();
                            go.name = "[SINGLETON] " + typeof(T).ToString();
                            _instance = go.AddComponent<T>();
                        }
                    }

                    return _instance;
                }
            }
        }

		protected void OnApplicationQuit() {
            _isQuitting = true;
			OnApplicationQuitting();
		}

        protected void OnDestroy() {
            _isQuitting = true;
			OnDestroying();
        }
		
		protected virtual void OnApplicationQuitting() {
		}

		protected virtual void OnDestroying() {
		}
    }
}

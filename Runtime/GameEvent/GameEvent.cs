using UnityEngine;
using System.Collections.Generic;

namespace UnityBase.GameEvent
{
    [CreateAssetMenu(menuName="Unity Base/Game Event")]
    public class GameEvent: ScriptableObject {
        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void Raise() {
            foreach (GameEventListener listener in listeners) {
                listener.OnEventRaised();
            }
        }

        public void RegisterListener(GameEventListener listener) {
            listeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener) {
            listeners.Remove(listener);
        }
    }
}

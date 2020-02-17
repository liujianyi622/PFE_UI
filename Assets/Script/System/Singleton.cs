using UnityEngine;
using System.Collections;

namespace PFE{
	public abstract class SingletonBase : MonoBehaviour
	{
		protected virtual void SingletonAwake() {}
		protected virtual void SingletonDestroy() {}
	}

	public abstract class Singleton<T> : SingletonBase where T : MonoBehaviour 
	{
		private static T _instance;
		public static T Instance { get { return _instance; } }

		private void Awake()
		{
			if(_instance != null) 
			{
				Debug.LogErrorFormat("duplicate singleton:{0}, current:{1}, new:{2}, destroy new", typeof(T), _instance.transform.GetInstanceID(), transform.GetInstanceID());
				Destroy(this);
				return;
			}
			_instance = this as T;
			SingletonAwake();
		}

        private void OnDestroy()
        {
            if (_instance == this)
            {
                SingletonDestroy();
                _instance = null;
            }
        }
    }
}

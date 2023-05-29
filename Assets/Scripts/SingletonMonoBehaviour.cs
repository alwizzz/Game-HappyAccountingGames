using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance = null;
    public bool dontDestroyOnLoad = true;

    protected virtual void Awake()
    {

        if (Instance != null)
        {
            Destroy(Instance.gameObject);
        }
        else
        {
            Instance = this as T;
            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(Instance);
            }
        }
    }

    // Use this for initialization
    protected virtual void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }

    protected virtual void OnDestroy()
    {
        if (Instance != null)
        {
            Instance = null;
        }
    }
}
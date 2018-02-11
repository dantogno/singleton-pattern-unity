using UnityEngine;
using System.Collections;

public class SingletonCoinManager : MonoBehaviour
{
    private static SingletonCoinManager instance;

    public static SingletonCoinManager Instance
    {
        get
        {
            if (instance == null)
            {
                // instance = GameObject.Find("SingletonCoinManager").GetComponent<SingletonCoinManager>();
                var gameObject = new GameObject(name: typeof(SingletonCoinManager).Name);
                instance = gameObject.AddComponent<SingletonCoinManager>();
                DontDestroyOnLoad(gameObject);
            }

            return instance;
        }
    }

    public int CoinCount { get; set; }
	
}

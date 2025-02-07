
using UnityEngine;
using UnityMultiplayerToolkit.Samples.Utility;

namespace UnityMultiplayerToolkit.Samples.SimpleMultiplayer
{
    public class Resolver : MonoBehaviour, IInitializableBeforeSceneLoad
    {
        public void InitializeBeforeSceneLoad()
        {
#if !UNITY_SERVER
            IConnectionConfigProvider configProvider = ApplicationInitializer.FindObjectOfInterface<IConnectionConfigProvider>();

            // Presenter
            var connectionPresenter = GameObject.FindObjectOfType<Client.ConnectionPresenter>();
            connectionPresenter.Construct(configProvider);
#endif

#if UNITY_SERVER
            // NetworkUtility.RemoveUpdateSystemForHeadlessServer();
            Debug.Log("NetworkUtility.RemoveUpdateSystemForHeadlessServer()");
#endif
        }
    }
}

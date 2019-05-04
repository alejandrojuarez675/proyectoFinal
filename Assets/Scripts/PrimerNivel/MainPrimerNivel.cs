using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MainPrimerNivel : MonoBehaviour
{

    private const string URL_AUTO = "https://www.dropbox.com/s/vxekcxxfkortjzs/jetbundle?dl=0";
    private const string NOMBRE_PREFAB = "jet";
    private GameObject _myPrefab;

    void Start()
    {
        this.Download(URL_AUTO, 10, 1, 20, NOMBRE_PREFAB);
    }

    void Update()
    {

    }

    private IEnumerator Download(string url, int positionX, int positionY, int positionZ, string nombreObjecto)
    {
        using (var uwr = new UnityWebRequest(url, UnityWebRequest.kHttpVerbGET))
        {
            uwr.downloadHandler = new DownloadHandlerAssetBundle(url, 0);
            //            yield return uwr.Send();      // Unity < 2018.3
            yield return uwr.SendWebRequest();
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(uwr);
            _myPrefab = bundle.LoadAsset(nombreObjecto) as GameObject;
            _myPrefab.transform.position = new Vector3(positionX, positionY, positionZ);
            Instantiate(_myPrefab);
        }

    }

}
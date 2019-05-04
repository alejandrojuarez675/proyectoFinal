using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
public class Download : MonoBehaviour
{

	public string url;
	public string nombreObjecto;
	public int positionX=0;
	public int positionY=0;
	public int positionZ=0;


    private GameObject _myPrefab;
    IEnumerator Start()
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
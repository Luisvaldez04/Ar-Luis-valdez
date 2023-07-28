using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PrefabsCreator : MonoBehaviour
{
    [SerializeField] private GameObject dragonPrefabs;
    [SerializeField] private Vector3 prefabsOffset;
        
    private GameObject dragon;
    private ARTrackedImageManager aRTrackedImageManager;

private void OnEnable()
{
aRTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();

aRTrackedImageManager.trackedImagesChanged += OnImageChanged;

}
private void OnImageChanged(ARTrackedImagesChangedEventArgs obj)
{
foreach(ARTrackedImage image in obj.added)
{

    dragon = Instantiate(dragonPrefabs, image.transform);
    dragon.transform.position += prefabsOffset;
}
}
}

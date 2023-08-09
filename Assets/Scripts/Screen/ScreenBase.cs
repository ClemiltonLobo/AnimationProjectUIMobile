using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;


namespace Screens
{
    public enum ScreenType
    {
        Panel,
        Info_Panel,
        Shop
    }

    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;
        public List<Transform> listOfObjects;

        public bool startHided = false;


        [Button]
        protected private void Show()
        {
            ShowObjects();
            Debug.Log("Show");
        }
        [Button]
        protected private void Hide()
        {
            HideObjects();
            Debug.Log("Hide");
        }

        private void HideObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
        }
        private void ShowObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(true));
        }
    }
}
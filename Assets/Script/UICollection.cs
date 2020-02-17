using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PFE
{
    public class UICollection : MonoBehaviour
    {
        private Button BtnBack;
        public void Start()
        {
            BtnBack = transform.Find("BtnBack").GetComponent<Button>();
            BtnBack.onClick.AddListener(ClickBtnBack);
            
        }

        public void OnEnable()
        {
            Debug.Log("start");
            if (UIGlobalData.Instance.isCollect)
            {
                transform.Find("Collection1").Find("Image").gameObject.SetActive(true);
                transform.Find("Collection1").Find("ImgBgGrey").gameObject.SetActive(false);
                transform.Find("Collection1").Find("ImgStar").gameObject.SetActive(true);
            }
            else
            {
                transform.Find("Collection1").Find("Image").gameObject.SetActive(false);
                transform.Find("Collection1").Find("ImgBgGrey").gameObject.SetActive(true);
                transform.Find("Collection1").Find("ImgStar").gameObject.SetActive(false);
            }
        }

        public void ClickBtnBack()
        {
            UIGlobalData.Instance.isShowCollection = false;
            UIGlobalData.Instance.isShowProfile = true;
        }
    }
}
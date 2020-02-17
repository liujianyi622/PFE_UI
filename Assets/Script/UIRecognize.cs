using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PFE
{
    public class UIRecognize : MonoBehaviour
    {
        private Button BtnCollect, BtnBack;
        public void Start()
        {
            BtnCollect = transform.Find("BtnCollect").GetComponent<Button>();
            BtnBack = transform.Find("BtnBack").GetComponent<Button>();
            BtnCollect.onClick.AddListener(ClickBtnCollect);
            BtnBack.onClick.AddListener(ClickBtnBack);
        }
        public void Update()
        {
            if (UIGlobalData.Instance.isCollect)
                BtnCollect.gameObject.SetActive(true);
            else
                BtnCollect.gameObject.SetActive(false);
        }

        public void ClickBtnCollect()
        {
            UIGlobalData.Instance.isShowCollection = true;
            UIGlobalData.Instance.isRecognize = false;
        }

        public void ClickBtnBack()
        {
            UIGlobalData.Instance.isShowProfile = true;
            UIGlobalData.Instance.isRecognize = false;
        }
    }
}
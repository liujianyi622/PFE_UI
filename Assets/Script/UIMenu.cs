using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PFE
{
    public class UIMenu : MonoBehaviour
    {
        private Button BtnStart, BtnBack;
        public void Start()
        {
            BtnStart = transform.Find("BtnStart").GetComponent<Button>();
            BtnBack = transform.Find("BtnBack").GetComponent<Button>();
            BtnStart.onClick.AddListener(ClickBtnStart);
            BtnBack.onClick.AddListener(ClickBtnBack);
        }

        public void ClickBtnStart()
        {
            UIGlobalData.Instance.isShowMenu = false;
            UIGlobalData.Instance.isRecognize = true;
        }

        public void ClickBtnBack()
        {
            UIGlobalData.Instance.isShowProfile = true;
            UIGlobalData.Instance.isShowMenu = false;
        }
    }
}
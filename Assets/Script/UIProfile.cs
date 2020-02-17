using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PFE
{
    public class UIProfile : MonoBehaviour
    {
        private Button BtnStart, BtnCollection, BtnSetting, BtnLogout;
        public void Start()
        {
            BtnStart = transform.Find("BtnStart").GetComponent<Button>();
            BtnCollection = transform.Find("BtnCollection").GetComponent<Button>();
            BtnSetting = transform.Find("BtnSetting").GetComponent<Button>();
            BtnLogout = transform.Find("BtnLogout").GetComponent<Button>();

            BtnStart.onClick.AddListener(ClickBtnStart);
            BtnCollection.onClick.AddListener(ClickBtnCollection);
            BtnSetting.onClick.AddListener(ClickBtnSetting);
            BtnLogout.onClick.AddListener(ClickBtnLogout);
        }

        public void ClickBtnStart()
        {
            UIGlobalData.Instance.isShowMenu = true;
            UIGlobalData.Instance.isShowProfile = false;
        }

        public void ClickBtnCollection()
        {
            UIGlobalData.Instance.isShowCollection= true;
            UIGlobalData.Instance.isShowProfile = false;
        }

        public void ClickBtnSetting()
        {
            Debug.Log("退出登录");
        }

        public void ClickBtnLogout()
        {
            UIGlobalData.Instance.isShowLogin= true;
            UIGlobalData.Instance.isShowProfile = false;
        }
    }
}
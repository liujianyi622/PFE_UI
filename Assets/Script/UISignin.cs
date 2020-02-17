using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PFE
{
    public class UISignin : MonoBehaviour
    {
        private Button BtnSignin, BtnBack;
        public void Start()
        {
            BtnSignin = transform.Find("BtnSignin").GetComponent<Button>();
            BtnBack = transform.Find("BtnBack").GetComponent<Button>();

            BtnSignin.onClick.AddListener(ClickBtnSignin);
            BtnBack.onClick.AddListener(ClickBtnBack);
        }

        public void ClickBtnSignin()
        {
            UIGlobalData.Instance.isShowSignin = false;
            UIGlobalData.Instance.isShowProfile = true;
        }

        public void ClickBtnBack()
        {
            UIGlobalData.Instance.isShowSignin = false;
            UIGlobalData.Instance.isShowLogin = true;
        }
    }
}
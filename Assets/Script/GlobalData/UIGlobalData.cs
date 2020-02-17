using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PFE
{
    public class UIGlobalData : SingletonData<UIGlobalData> {
        public bool isShowWelcome = false;
        public bool isShowLogin = false;
        public bool isShowMenu = false;
        public bool isShowSignin = false;
        public bool isShowCollection = false;
        public bool isShowProfile = false;

        public bool isRecognize = false;
        public bool isCollect = false;

        public Dictionary<int, Texture> collections = new Dictionary<int, Texture>();
    }
}
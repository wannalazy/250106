using System.Linq;
using UnityEngine;

namespace WRX 
{
    /// <summary>
    /// 練習類別
    /// </summary>
    public class Practice_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            Practice_8_Boss bossDeagon = new Practice_8_Boss("龍獸", "龍之吐息", 2999);
            Practice_8_Boss bossbird = new Practice_8_Boss("烈空座", "光束砲", 3999);

            Debug.Log($"<color=#f93>{bossDeagon.name},招式:{bossDeagon.skill}</color>"); 
            Debug.Log($"<color=#f93>{bossbird.name},招式:{bossbird.skill}</color>");

        }
    }

    /// <summary>
    /// 大魔王類別
    /// </summary>
    public class Practice_8_Boss 
    {
        public string name;
        public string skill;
        public float hp;

        public Practice_8_Boss(string _name, string _skill, float _hp)
        {
            name = _name;
            skill = _skill;
            hp = _hp;
        }
    }
}


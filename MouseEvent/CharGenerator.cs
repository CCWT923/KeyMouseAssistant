using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseEvent
{
    /// <summary>
    /// 生成字符
    /// </summary>
    class CharGenerator
    {
        //中文基本汉字20902字，范围：4E00-9FA5
        //英文字母：大写 65-90，小写 97-122
        //数字：48-57
        public CharGenerator()
        {
            
        }

        private Random _Random;
        private string _CharResult;
        private int _ChAR_CN_MIN = 0x4E00;
        private int _CHAR_CN_MAX = 0x9FA5;

        /// <summary>
        /// 表示字符类型的枚举值
        /// </summary>
        public enum CharType:byte
        {
            ChineseCharacters = 1,
            Numbers = 2,
            Letter = 4
        };
        /// <summary>
        /// 获取一个指定类型的字符串
        /// </summary>
        /// <param name="charType"></param>
        /// <returns></returns>
        public string GetChar(CharType charType, int num = 1)
        {
            _CharResult = "";
            _Random = new Random(DateTime.Now.Millisecond);
            for(int i = 0; i < num; i++)
            {
                if (charType == CharType.ChineseCharacters)
                {
                    _CharResult += ((Char)_Random.Next(_ChAR_CN_MIN, _CHAR_CN_MAX)).ToString();
                }
            }


            return _CharResult;
        }

    }
}

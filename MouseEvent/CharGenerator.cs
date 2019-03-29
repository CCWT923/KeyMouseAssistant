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

        /// <summary>
        /// 表示字符类型的枚举值
        /// </summary>
        public enum CharType:uint
        {
            ChineseCharacters = 0,
            Numbers,
            Letter
        };
    }
}

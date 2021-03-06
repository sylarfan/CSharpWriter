﻿/*****************************
CSharpWriter is a RTF style Text writer control written by C#,Currently,
it use <LGPL> license.More than RichTextBox, 
It is provide a DOM to access every thing in document and save in XML format.
It can use in WinForm.NET ,WPF,Console application.Any idea about CSharpWriter 
can write to 28348092@qq.com(or yyf9989@hotmail.com). 
Project web site is [https://github.com/dcsoft-yyf/CSharpWriter].
*****************************///@DCHC@
using System;
using System.Collections.Generic;
using System.Text;

namespace DCSoft.CSharpWriter.Commands
{
    /// <summary>
    /// 插入RTF文本的命令参数对象
    /// </summary>
    [Serializable]
    public class InsertRTFCommandParameter
    {
        /// <summary>
        /// 初始化对象
        /// </summary>
        /// <remarks>编写 袁永福</remarks>
        public InsertRTFCommandParameter()
        {
        }

        private string _RTFText = null;
        /// <summary>
        /// RTF文本
        /// </summary>
        public string RTFText
        {
            get
            {
                return _RTFText; 
            }
            set
            {
                _RTFText = value; 
            }
        }
    }
}

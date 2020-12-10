﻿/*****************************
CSharpWriter is a RTF style Text writer control written by C#2.0,Currently,
it use <LGPL> license(maybe change later).More than RichTextBox, 
It is provide a DOM to access every thing in document and save in XML format.
It can use in WinForm.NET ,WPF,Console application.Any idea about CSharpWriter 
can send to 28348092@qq.com(or yyf9989@hotmail.com).
*****************************///@DCHC@
/*
 * 
 *   DCSoft RTF DOM v1.0
 *   Author : Yuan yong fu.
 *   Email  : yyf9989@hotmail.com
 *   blog site:http://www.cnblogs.com/xdesigner.
 * 
 */



using System;
using System.Text;

namespace DCSoft.RTF
{
    /// <summary>
    /// line element
    /// </summary>
    [Serializable()]
    public class RTFDomLineBreak : RTFDomElement
    {
        /// <summary>
        /// initialize instance
        /// </summary>
        public RTFDomLineBreak()
        {
            this.Locked = true;
        }

        public override string InnerText
        {
            get
            {
                return Environment.NewLine;
            }
        }
        public override string ToString()
        {
            return "linebreak";
        }
    }
}
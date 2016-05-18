﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Branch.com.proem.exm.util
{
    /// <summary>
    /// 金额format类
    /// </summary>
    public static class MoneyFormat
    {
        ///精度
        public static string accuracy;

        /// <summary>
        /// 金额格式化
        /// 末位舍去
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public static string Format(float money)
        {
            string target = "";
            int a = 0;
            if (string.IsNullOrEmpty(accuracy))
            {
                return money.ToString("0.00");
            }
            if (accuracy.Equals("1"))
            {
                a = money.ToString("0.0").Length;
                target = money.ToString("0.00").Substring(0, a);
            }
            else if (accuracy.Equals("2"))
            {
                a = money.ToString("0.00").Length;
                target = money.ToString("0.000").Substring(0, a);
            }
            else if (accuracy.Equals("3"))
            {
                a = money.ToString("0.000").Length;
                target = money.ToString("0.0000").Substring(0, a);
            }
            return target;
        }

        /// <summary>
        /// 金额格式化
        /// 四舍五入
        /// </summary>
        /// <returns></returns>
        public static string RountFormat(float money) {
            string target = "";
            if (string.IsNullOrEmpty(accuracy))
            {
                return money.ToString("0.00");
            }
            if (accuracy.Equals("1"))
            {
                target = money.ToString("0.0");
            }
            else if (accuracy.Equals("2"))
            {
                target = money.ToString("0.00");
            }
            else if (accuracy.Equals("3"))
            {
                target = money.ToString("0.000");
            }
            return target;
        }
    }
}

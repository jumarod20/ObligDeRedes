﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.MessageProtocol
{
    public static class HeaderConstants
    {
        public static string Request = "REQ";
        public static string Response = "RES";
        public static int CommandLength = 2;
        public static int DataLength = 4;
    }
}

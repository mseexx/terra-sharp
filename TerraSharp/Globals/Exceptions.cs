﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraSharp.Globals
{
    
    public class TerraSharpException : Exception
    {
        private string exceptionName { get; set; }
        private double exceptionCode { get; set; }
        private string exceptionMessage { get; set; }

        public TerraSharpException(string name, double code, string message)
        {
            this.exceptionName = name;
            this.exceptionCode = code;
            this.exceptionMessage = message;
        }
        public string exceptionNameGet() => exceptionName;
        public double exceptionCodeGet() => exceptionCode;
        public string exceptionMessageGet() => exceptionMessage;
    }
    public class Exceptions
    {
        public static TerraSharpException AccountTypeInvalidException = new TerraSharpException("AccountTypeInvalidException", 0x80000000,
            "Account type %s not recognized");

        public static TerraSharpException PubkeyTypeInvalidException = new TerraSharpException("AccountTypeInvalidException", 0x80000001,
            "Pubkey type %s not recognized");

        public static TerraSharpException APIParamsTypeInvalidException = new TerraSharpException("APIParamsTypeInvalidException", 0x80000002,
            "APIParams Type %s is not valid. Type must be String, Double or NULL.");

        public Exceptions()
        {

        }
    }
}

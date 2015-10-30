﻿namespace PrivatBankApiWrapper.DataProperties
{
    internal class Test : IDataProperty
    {
        internal bool IsTest { get; set; }

        public string GetXml()
        {
            return "<test>" + (IsTest ? "1" : "0") + "</test>";
        }
    }
}
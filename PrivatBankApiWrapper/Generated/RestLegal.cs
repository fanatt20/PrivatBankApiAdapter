using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using PrivatBankApiWrapper.ResponseDto.Balance;
using PrivatBankApiWrapper.ResponseDto.Global;


[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "",ElementName = "response", IsNullable = false)]
public class RestLegalDto
{
    /// <remarks />
    [XmlElement("merchant", Form = XmlSchemaForm.Unqualified)]
    public Merchant[] Merchant { get; set; }

    /// <remarks />
    [XmlElement("data", Form = XmlSchemaForm.Unqualified)]
    public RestLegalDataDto[] Data { get; set; }

    /// <remarks />
    [XmlAttribute("version")]
    public string Version { get; set; }
}


/// <remarks />
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
public class RestLegalDataDto
{
    /// <remarks />
    [XmlElement("oper",Form = XmlSchemaForm.Unqualified)]
    public string Operation { get; set; }

    /// <remarks />
    [XmlArray(Form = XmlSchemaForm.Unqualified)]
    [XmlArrayItem("abcde", typeof (responseDataInfoAbcdeRow[]), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
    [XmlArrayItem("row", typeof (responseDataInfoAbcdeRow), Form = XmlSchemaForm.Unqualified, IsNullable = false,
        NestingLevel = 1)]
    public responseDataInfoAbcdeRow[][][] info { get; set; }
}

/// <remarks />
[XmlType(AnonymousType = true)]
public class responseDataInfoAbcdeRow
{
    /// <remarks />
    [XmlElement("col", Form = XmlSchemaForm.Unqualified, IsNullable = true)]
    public responseDataInfoAbcdeRowCol[] col { get; set; }

    /// <remarks />
    [XmlAttribute]
    public string key { get; set; }

    /// <remarks />
    [XmlAttribute]
    public string level { get; set; }
}

/// <remarks />
[XmlType(AnonymousType = true)]
public class responseDataInfoAbcdeRowCol
{
    /// <remarks />
    [XmlAttribute]
    public string name { get; set; }

    /// <remarks />
    [XmlAttribute]
    public string level { get; set; }

    /// <remarks />
    [XmlText]
    public string Value { get; set; }
}


// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerAttrDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainerAttrDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1050538, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Environment_AttributeValue")]
    protected Environment _AttributeValue;
    [Metadata("A unique name for an attribute of a object.", "", false, false, false, "String", 1051934, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Environment_Name")]
    protected Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Environment_Attribute")]
    [Metadata("A user attribute is used to record a single value, identified by a unique name and attached to an object as a list.  This is different from a set of single fields because the attributes can be different based on many factors, such as product or factory.", "UserAttribute", false, false, false, "NamedSubentityRef", 1051952, false, false, false, null)]
    protected Environment _Attribute;
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, false, "Integer", 1051940, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Environment_DataType")]
    protected Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Environment_IsExpression")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052477, false, false, false, "0")]
    protected Environment _IsExpression;

    public Environment AttributeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeValue));
      }
    }

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment Attribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attribute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Attribute));
      }
    }

    public Environment DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataType));
      }
    }

    public Environment IsExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsExpression));
      }
    }
  }
}

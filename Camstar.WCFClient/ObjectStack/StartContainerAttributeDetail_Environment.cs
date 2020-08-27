// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartContainerAttributeDetail_Environment
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
  public class StartContainerAttributeDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("A unique name for an attribute of a object.", "", false, false, false, "String", 1051934, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Environment_Name")]
    protected Environment _Name;
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, false, "Integer", 1049990, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Environment_DataType")]
    protected Environment _DataType;
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1051936, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Environment_AttributeValue")]
    protected Environment _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Environment_IsExpression")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052477, false, false, false, "0")]
    protected Environment _IsExpression;

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

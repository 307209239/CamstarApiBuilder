// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleHandlerParameterChanges_Environment
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
  public class BizRuleHandlerParameterChanges_Environment : NamedSubentityChanges_Environment
  {
    [Metadata("CDOType", "", false, false, false, "Integer", 1050572, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Environment_ObjectType")]
    protected Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Environment_ObjectDisplayValue")]
    [Metadata("DisplayName", "", false, false, true, "String", 1051180, false, false, true, null)]
    protected Environment _ObjectDisplayValue;
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, true, false, "Integer", 1049990, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Environment_DataType")]
    protected Environment _DataType;
    [Metadata("Generic String", "", false, false, false, "String", 1051014, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Environment_DefaultValue")]
    protected Environment _DefaultValue;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1050572, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Environment_ObjectTypeName")]
    protected Environment _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Environment_DataTypeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049990, false, false, false, null)]
    protected Environment _DataTypeName;

    public Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Environment ObjectDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectDisplayValue));
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

    public Environment DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultValue));
      }
    }

    public new Environment Name
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

    public Environment ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public Environment DataTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataTypeName));
      }
    }
  }
}

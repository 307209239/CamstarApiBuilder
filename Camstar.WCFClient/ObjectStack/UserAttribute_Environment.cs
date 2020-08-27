// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserAttribute_Environment
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
  public class UserAttribute_Environment : NamedSubentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1050538, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Environment_AttributeValue")]
    protected Environment _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Environment_DataType")]
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1051940, false, false, false, null)]
    protected Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Environment_Name")]
    [Metadata("A unique name for an attribute of a object.", "", false, false, true, "String", 1051934, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Environment_IsExpression")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052477, false, false, false, "0")]
    protected Environment _IsExpression;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Environment_IsFrozen")]
    protected new Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}

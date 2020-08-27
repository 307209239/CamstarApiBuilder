// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserConstantChanges_Environment
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
  public class UserConstantChanges_Environment : TextVariableChanges_Environment
  {
    [Metadata("Field Expression.", "", false, true, false, "String", 1050538, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Environment_VariableExpression")]
    protected new Environment _VariableExpression;
    [Metadata("User Constant is used by the server when it sees a value in the expression like 'Constants::<name of a Constant>'", "UserConstant", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Environment_DataType")]
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, true, false, "Integer", 1049990, false, false, true, null)]
    protected Environment _DataType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051016, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("String to be evaluated to produce a value at run-time.", "", false, false, true, "String", 1048902, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Environment_UnresolvedValue")]
    protected new Environment _UnresolvedValue;
    [Metadata("Defines the type of Variable. For example:\r\n\r\n1 = General (can be used in any text)\r\n2 = WIP Message\r\n3 = Alarm Message\r\n4 = Instruction Text", "TextVariableTypeEnum", false, false, true, "Integer", 1048904, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Environment_VariableUsage")]
    protected new Environment _VariableUsage;

    public new Environment VariableExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (VariableExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VariableExpression));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
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

    public new Environment UnresolvedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnresolvedValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnresolvedValue));
      }
    }

    public new Environment VariableUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (VariableUsage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VariableUsage));
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserConstantChanges_Info
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
  public class UserConstantChanges_Info : TextVariableChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Info_VariableExpression")]
    protected new Info _VariableExpression;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Info_UnresolvedValue")]
    protected new Info _UnresolvedValue;
    [DataMember(EmitDefaultValue = false, Name = "UserConstantChanges_Info_VariableUsage")]
    protected new Info _VariableUsage;

    public new Info VariableExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (VariableExpression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VariableExpression));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info UnresolvedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnresolvedValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnresolvedValue));
      }
    }

    public new Info VariableUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (VariableUsage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VariableUsage));
      }
    }
  }
}

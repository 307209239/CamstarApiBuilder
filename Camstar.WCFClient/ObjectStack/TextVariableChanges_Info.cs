// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TextVariableChanges_Info
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
  public class TextVariableChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Info_VariableExpression")]
    protected Info _VariableExpression;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Info_UnresolvedValue")]
    protected Info _UnresolvedValue;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Info_VariableUsage")]
    protected Info _VariableUsage;
    [DataMember(EmitDefaultValue = false, Name = "TextVariableChanges_Info_Name")]
    protected new Info _Name;

    public Info VariableExpression
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

    public Info UnresolvedValue
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

    public Info VariableUsage
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
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleHandlerParameterChanges_Info
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
  public class BizRuleHandlerParameterChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Info_ObjectDisplayValue")]
    protected Info _ObjectDisplayValue;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Info_DefaultValue")]
    protected Info _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleHandlerParameterChanges_Info_DataTypeName")]
    protected Info _DataTypeName;

    public Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Info ObjectDisplayValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectDisplayValue));
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

    public Info DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultValue));
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

    public Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public Info DataTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataTypeName));
      }
    }
  }
}

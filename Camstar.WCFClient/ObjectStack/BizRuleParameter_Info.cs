// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleParameter_Info
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
  public class BizRuleParameter_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Info_BusinessRuleHandler")]
    protected Info _BusinessRuleHandler;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Info_ValueExpression")]
    protected Info _ValueExpression;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Info_ParamSpec")]
    protected Info _ParamSpec;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info BusinessRuleHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleHandler), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BusinessRuleHandler));
      }
    }

    public Info ValueExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValueExpression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValueExpression));
      }
    }

    public Info ParamSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamSpec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParamSpec));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}

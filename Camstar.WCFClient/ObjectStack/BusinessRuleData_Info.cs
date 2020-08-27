// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleData_Info
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
  public class BusinessRuleData_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_Parameters")]
    protected BizRuleParameter_Info _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_ContextType")]
    protected Info _ContextType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_Handlers")]
    protected Info _Handlers;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_Scope")]
    protected Info _Scope;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_Condition")]
    protected Info _Condition;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_AlwaysExecute")]
    protected Info _AlwaysExecute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Info_IsFrozen")]
    protected new Info _IsFrozen;

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

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

    public BizRuleParameter_Info Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleParameter_Info) this.PropertyGet(nameof (Parameters));
      }
    }

    public Info ContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContextType));
      }
    }

    public Info Handlers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Handlers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Handlers));
      }
    }

    public Info Scope
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scope), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Scope));
      }
    }

    public Info Condition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Condition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Condition));
      }
    }

    public Info AlwaysExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AlwaysExecute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AlwaysExecute));
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

    public new Info IsFrozen
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

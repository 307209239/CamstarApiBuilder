// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleData_Environment
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
  public class BusinessRuleData_Environment : NamedSubentity_Environment
  {
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_Parameters")]
    [Metadata("Business Rule Parameter", "BizRuleParameter", false, false, true, "BizRuleParameter", 1050947, false, true, false, null)]
    protected BizRuleParameter_Environment _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_ContextType")]
    [Metadata("Enumeration for the Biz Rule Holder Type:\r\nProcess\r\nPhase\r\nPlan\r\nActivity", "BizRuleHolderTypeEnum", false, false, true, "Integer", 1049631, false, false, false, null)]
    protected Environment _ContextType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_Handlers")]
    [Metadata("Business Rule Handler", "BusinessRuleHandler", false, false, true, "NamedObjectRef", 1051230, false, true, false, null)]
    protected Environment _Handlers;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_Scope")]
    [Metadata("Enumeration for the Biz Rule Scope:\r\n0 = Global\r\n1 = Local", "BizRuleScopeEnum", false, false, true, "Integer", 1051201, false, false, false, null)]
    protected Environment _Scope;
    [Metadata("InSite Unified Expression", "", false, false, true, "String", 1051193, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_Condition")]
    protected Environment _Condition;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051191, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_AlwaysExecute")]
    protected Environment _AlwaysExecute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleData_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

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

    public BizRuleParameter_Environment Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleParameter_Environment) this.PropertyGet(nameof (Parameters));
      }
    }

    public Environment ContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContextType));
      }
    }

    public Environment Handlers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Handlers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Handlers));
      }
    }

    public Environment Scope
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scope), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Scope));
      }
    }

    public Environment Condition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Condition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Condition));
      }
    }

    public Environment AlwaysExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AlwaysExecute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AlwaysExecute));
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

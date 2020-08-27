// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleDataChanges_Info
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
  public class BusinessRuleDataChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_Condition")]
    protected Info _Condition;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_BusinessRuleToLoad")]
    protected Info _BusinessRuleToLoad;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_Parameters")]
    protected BizRuleParameterChanges_Info _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_Handlers")]
    protected Info _Handlers;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_Scope")]
    protected Info _Scope;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_ContextType")]
    protected Info _ContextType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_AlwaysExecute")]
    protected Info _AlwaysExecute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Info_Name")]
    protected new Info _Name;

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

    public Info BusinessRuleToLoad
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleToLoad), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BusinessRuleToLoad));
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

    public BizRuleParameterChanges_Info Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleParameterChanges_Info) this.PropertyGet(nameof (Parameters));
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

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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
  }
}

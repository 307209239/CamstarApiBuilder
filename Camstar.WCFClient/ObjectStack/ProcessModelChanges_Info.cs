// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelChanges_Info
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
  public class ProcessModelChanges_Info : ProcessObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Info_ExecutionContextType")]
    protected new Info _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Info_RuleList")]
    protected new Info _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Info_Details")]
    protected new ProcessObjectChanges_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Info_onCompleteRules")]
    protected BusinessRuleDataChanges_Info _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Info_onStartRules")]
    protected BusinessRuleDataChanges_Info _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelChanges_Info_Name")]
    protected new Info _Name;

    public new Info ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public new Info RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RuleList));
      }
    }

    public new ProcessObjectChanges_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Info) this.PropertyGet(nameof (Details));
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

    public BusinessRuleDataChanges_Info onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Info) this.PropertyGet(nameof (onCompleteRules));
      }
    }

    public BusinessRuleDataChanges_Info onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges_Info) this.PropertyGet(nameof (onStartRules));
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

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SwitchingRuleChanges_Info
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
  public class SwitchingRuleChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Info_EMailMessage")]
    protected Info _EMailMessage;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Info_EMailDistribution")]
    protected Info _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Info_SwitchingRuleDetails")]
    protected SwitchingRuleDetailsChanges_Info _SwitchingRuleDetails;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Info_Name")]
    protected new Info _Name;

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
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

    public Info EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public Info EMailDistribution
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailDistribution), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailDistribution));
      }
    }

    public SwitchingRuleDetailsChanges_Info SwitchingRuleDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleDetails), (object) value);
      }
      get
      {
        return (SwitchingRuleDetailsChanges_Info) this.PropertyGet(nameof (SwitchingRuleDetails));
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

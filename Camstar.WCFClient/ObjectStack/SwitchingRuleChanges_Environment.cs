// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SwitchingRuleChanges_Environment
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
  public class SwitchingRuleChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("Object used to define the Switching Rules for an AQL Sampling plan.  Defines the rule for switching between inspection levels.", "SwitchingRuleBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Environment_ObjectToChange")]
    [Metadata("Object used to define the Switching Rules for an AQL Sampling plan.  Defines the rule for switching between inspection levels.", "SwitchingRule", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Environment_EMailMessage")]
    [Metadata("EMail with details to be used in sending email.", "EMailMessage", false, false, false, "NamedObjectRef", 1051744, false, false, true, null)]
    protected Environment _EMailMessage;
    [Metadata("The list of people who should receive an EMailMessage.", "EMailDistribution", false, false, false, "NamedObjectRef", 1051746, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Environment_EMailDistribution")]
    protected Environment _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Environment_SwitchingRuleDetails")]
    [Metadata("Defines the switching rule details for an AQL Sampling plan.  Switching rules allow for automatic changing of the Inpsection level for a Product’s sampling plan.", "SwitchingRuleDetailsChanges", false, true, false, "SwitchingRuleDetailsChanges", 1053141, false, true, false, null)]
    protected SwitchingRuleDetailsChanges_Environment _SwitchingRuleDetails;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053142, false, false, false, null)]
    protected new Environment _Name;

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
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

    public Environment EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailMessage));
      }
    }

    public Environment EMailDistribution
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailDistribution), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EMailDistribution));
      }
    }

    public SwitchingRuleDetailsChanges_Environment SwitchingRuleDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleDetails), (object) value);
      }
      get
      {
        return (SwitchingRuleDetailsChanges_Environment) this.PropertyGet(nameof (SwitchingRuleDetails));
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
  }
}

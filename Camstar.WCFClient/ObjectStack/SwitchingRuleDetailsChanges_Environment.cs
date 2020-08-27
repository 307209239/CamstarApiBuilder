// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SwitchingRuleDetailsChanges_Environment
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
  public class SwitchingRuleDetailsChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Defines the switching rule details for an AQL Sampling plan.  Switching rules allow for automatic changing of the Inpsection level for a Product’s sampling plan.", "SwitchingRuleDetails", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Defines the switching rule details for an AQL Sampling plan.  Switching rules allow for automatic changing of the Inpsection level for a Product’s sampling plan.", "SwitchingRuleDetailsChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, true, false, "NamedObjectRef", 1053173, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_FromInspectionLevel")]
    protected Environment _FromInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_SwitchingRuleType")]
    [Metadata("Used to identify the Switching rule test type For example, I want to use this switching rule if 2 out of 5 containers Passed testing.\r\nPassed = 1\r\nFailed = 2", "SwitchingRuleEnum", false, false, false, "Integer", 1053177, false, false, true, null)]
    protected Environment _SwitchingRuleType;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_ToInspectionLevel")]
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, true, false, "NamedObjectRef", 1053178, false, false, true, null)]
    protected Environment _ToInspectionLevel;
    [Metadata("The list of people who should receive an EMailMessage.", "EMailDistribution", false, false, false, "NamedObjectRef", 1051746, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_EMailDistribution")]
    protected Environment _EMailDistribution;
    [Metadata("InSite Unified Expression", "", false, false, false, "String", 1049630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_Expression")]
    protected Environment _Expression;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_PassOrFailContainerCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053175, false, false, false, null)]
    protected Environment _PassOrFailContainerCount;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_RequireNotification")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053176, false, false, false, "0")]
    protected Environment _RequireNotification;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_AllowAutomaticSwitching")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053172, false, false, false, "0")]
    protected Environment _AllowAutomaticSwitching;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053174, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_LastContainerSetCount")]
    protected Environment _LastContainerSetCount;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 0, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment FromInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromInspectionLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromInspectionLevel));
      }
    }

    public Environment SwitchingRuleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SwitchingRuleType));
      }
    }

    public Environment ToInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToInspectionLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToInspectionLevel));
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

    public Environment Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Expression));
      }
    }

    public Environment PassOrFailContainerCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassOrFailContainerCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PassOrFailContainerCount));
      }
    }

    public Environment RequireNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireNotification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequireNotification));
      }
    }

    public Environment AllowAutomaticSwitching
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowAutomaticSwitching), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowAutomaticSwitching));
      }
    }

    public Environment LastContainerSetCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastContainerSetCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastContainerSetCount));
      }
    }

    public Environment IsFrozen
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

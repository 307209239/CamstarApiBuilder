// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SwitchingRuleDetailsChanges_Info
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
  public class SwitchingRuleDetailsChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_FromInspectionLevel")]
    protected Info _FromInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_SwitchingRuleType")]
    protected Info _SwitchingRuleType;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_ToInspectionLevel")]
    protected Info _ToInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_EMailDistribution")]
    protected Info _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_Expression")]
    protected Info _Expression;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_PassOrFailContainerCount")]
    protected Info _PassOrFailContainerCount;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_RequireNotification")]
    protected Info _RequireNotification;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_AllowAutomaticSwitching")]
    protected Info _AllowAutomaticSwitching;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_LastContainerSetCount")]
    protected Info _LastContainerSetCount;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public Info FromInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromInspectionLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromInspectionLevel));
      }
    }

    public Info SwitchingRuleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SwitchingRuleType));
      }
    }

    public Info ToInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToInspectionLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToInspectionLevel));
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

    public Info Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Expression));
      }
    }

    public Info PassOrFailContainerCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassOrFailContainerCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PassOrFailContainerCount));
      }
    }

    public Info RequireNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireNotification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequireNotification));
      }
    }

    public Info AllowAutomaticSwitching
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowAutomaticSwitching), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowAutomaticSwitching));
      }
    }

    public Info LastContainerSetCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastContainerSetCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastContainerSetCount));
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

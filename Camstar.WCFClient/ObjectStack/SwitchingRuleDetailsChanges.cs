// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SwitchingRuleDetailsChanges
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
  public class SwitchingRuleDetailsChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_FromInspectionLevel")]
    protected NamedObjectRef _FromInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_SwitchingRuleType")]
    protected Enumeration<SwitchingRuleEnum, int> _SwitchingRuleType;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_ToInspectionLevel")]
    protected NamedObjectRef _ToInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_EMailDistribution")]
    protected NamedObjectRef _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_Expression")]
    protected Primitive<string> _Expression;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_PassOrFailContainerCount")]
    protected Primitive<int> _PassOrFailContainerCount;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_RequireNotification")]
    protected Primitive<bool> _RequireNotification;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_AllowAutomaticSwitching")]
    protected Primitive<bool> _AllowAutomaticSwitching;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_LastContainerSetCount")]
    protected Primitive<int> _LastContainerSetCount;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleDetailsChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is SwitchingRuleDetailsChanges && object.Equals((object) this._ObjectToChange, (object) ((SwitchingRuleDetailsChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((SwitchingRuleDetailsChanges) obj)._ListItemToChange) && object.Equals((object) this._FromInspectionLevel, (object) ((SwitchingRuleDetailsChanges) obj)._FromInspectionLevel)) && (object.Equals((object) this._SwitchingRuleType, (object) ((SwitchingRuleDetailsChanges) obj)._SwitchingRuleType) && object.Equals((object) this._ToInspectionLevel, (object) ((SwitchingRuleDetailsChanges) obj)._ToInspectionLevel) && (object.Equals((object) this._EMailDistribution, (object) ((SwitchingRuleDetailsChanges) obj)._EMailDistribution) && object.Equals((object) this._Expression, (object) ((SwitchingRuleDetailsChanges) obj)._Expression))) && (object.Equals((object) this._PassOrFailContainerCount, (object) ((SwitchingRuleDetailsChanges) obj)._PassOrFailContainerCount) && object.Equals((object) this._RequireNotification, (object) ((SwitchingRuleDetailsChanges) obj)._RequireNotification) && (object.Equals((object) this._AllowAutomaticSwitching, (object) ((SwitchingRuleDetailsChanges) obj)._AllowAutomaticSwitching) && object.Equals((object) this._LastContainerSetCount, (object) ((SwitchingRuleDetailsChanges) obj)._LastContainerSetCount)) && object.Equals((object) this._IsFrozen, (object) ((SwitchingRuleDetailsChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef FromInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromInspectionLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromInspectionLevel));
      }
    }

    public Enumeration<SwitchingRuleEnum, int> SwitchingRuleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleType), (object) value);
      }
      get
      {
        return (Enumeration<SwitchingRuleEnum, int>) this.PropertyGet(nameof (SwitchingRuleType));
      }
    }

    public NamedObjectRef ToInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToInspectionLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToInspectionLevel));
      }
    }

    public NamedObjectRef EMailDistribution
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailDistribution), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailDistribution));
      }
    }

    public Primitive<string> Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Expression));
      }
    }

    public Primitive<int> PassOrFailContainerCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassOrFailContainerCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (PassOrFailContainerCount));
      }
    }

    public Primitive<bool> RequireNotification
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireNotification), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RequireNotification));
      }
    }

    public Primitive<bool> AllowAutomaticSwitching
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowAutomaticSwitching), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowAutomaticSwitching));
      }
    }

    public Primitive<int> LastContainerSetCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastContainerSetCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LastContainerSetCount));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}

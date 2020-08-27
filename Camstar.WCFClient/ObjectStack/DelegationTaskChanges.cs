// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationTaskChanges
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
  public class DelegationTaskChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_ApplicationType")]
    protected Enumeration<ApplicationTypeEnum, int> _ApplicationType;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_DelegationReason")]
    protected NamedObjectRef _DelegationReason;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_EndDateGMT")]
    protected Primitive<DateTime> _EndDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_StartDateGMT")]
    protected Primitive<DateTime> _StartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_DelegationForwarding")]
    protected Primitive<bool> _DelegationForwarding;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_AssignedEmployee")]
    protected NamedObjectRef _AssignedEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_DelegatedBy")]
    protected NamedObjectRef _DelegatedBy;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_TargetEmployee")]
    protected NamedObjectRef _TargetEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is DelegationTaskChanges && object.Equals((object) this._Comments, (object) ((DelegationTaskChanges) obj)._Comments) && (object.Equals((object) this._ChangeHistory, (object) ((DelegationTaskChanges) obj)._ChangeHistory) && object.Equals((object) this._ApplicationType, (object) ((DelegationTaskChanges) obj)._ApplicationType)) && (object.Equals((object) this._DelegationReason, (object) ((DelegationTaskChanges) obj)._DelegationReason) && object.Equals((object) this._EndDateGMT, (object) ((DelegationTaskChanges) obj)._EndDateGMT) && (object.Equals((object) this._StartDateGMT, (object) ((DelegationTaskChanges) obj)._StartDateGMT) && object.Equals((object) this._DelegationForwarding, (object) ((DelegationTaskChanges) obj)._DelegationForwarding))) && (object.Equals((object) this._AssignedEmployee, (object) ((DelegationTaskChanges) obj)._AssignedEmployee) && object.Equals((object) this._DelegatedBy, (object) ((DelegationTaskChanges) obj)._DelegatedBy) && (object.Equals((object) this._TargetEmployee, (object) ((DelegationTaskChanges) obj)._TargetEmployee) && object.Equals((object) this._IsFrozen, (object) ((DelegationTaskChanges) obj)._IsFrozen))) && base.Equals(obj);
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public ChangeHistoryChanges ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public Enumeration<ApplicationTypeEnum, int> ApplicationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplicationType), (object) value);
      }
      get
      {
        return (Enumeration<ApplicationTypeEnum, int>) this.PropertyGet(nameof (ApplicationType));
      }
    }

    public NamedObjectRef DelegationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DelegationReason));
      }
    }

    public Primitive<DateTime> EndDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDateGMT));
      }
    }

    public Primitive<DateTime> StartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartDateGMT));
      }
    }

    public Primitive<bool> DelegationForwarding
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationForwarding), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DelegationForwarding));
      }
    }

    public NamedObjectRef AssignedEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssignedEmployee));
      }
    }

    public NamedObjectRef DelegatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegatedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DelegatedBy));
      }
    }

    public NamedObjectRef TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetEmployee));
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

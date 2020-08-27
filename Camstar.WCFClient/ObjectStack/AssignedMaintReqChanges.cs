// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignedMaintReqChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MaintClassMaintReqChanges))]
  [KnownType(typeof (ResourceMaintReqChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class AssignedMaintReqChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_MaintenanceReq")]
    protected RevisionedObjectRef _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_ActivationDate")]
    protected Primitive<DateTime> _ActivationDate;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_Parent")]
    protected new BaseObjectRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is AssignedMaintReqChanges && object.Equals((object) this._ListItemToChange, (object) ((AssignedMaintReqChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((AssignedMaintReqChanges) obj)._ObjectToChange) && object.Equals((object) this._MaintenanceReq, (object) ((AssignedMaintReqChanges) obj)._MaintenanceReq)) && (object.Equals((object) this._ChangeHistory, (object) ((AssignedMaintReqChanges) obj)._ChangeHistory) && object.Equals((object) this._ActivationDate, (object) ((AssignedMaintReqChanges) obj)._ActivationDate) && (object.Equals((object) this._Parent, (object) ((AssignedMaintReqChanges) obj)._Parent) && object.Equals((object) this._IsFrozen, (object) ((AssignedMaintReqChanges) obj)._IsFrozen))) && base.Equals(obj);
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

    public RevisionedObjectRef MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MaintenanceReq));
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

    public Primitive<DateTime> ActivationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ActivationDate));
      }
    }

    public new BaseObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Parent));
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

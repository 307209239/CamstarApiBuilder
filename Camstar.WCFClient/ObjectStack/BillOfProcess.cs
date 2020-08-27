// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcess
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
  public class BillOfProcess : RevisionedObject
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_BillOfProcessOverrides")]
    protected BillOfProcessOverride[] _BillOfProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_ECO")]
    protected new Primitive<string> _ECO;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_WIPMsgDefMgr")]
    protected new WIPMsgDefMgr _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_Revision")]
    protected new Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_Status")]
    protected new Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcess_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is BillOfProcess && this.CompareArrays((Array) this._BillOfProcessOverrides, (Array) ((BillOfProcess) obj)._BillOfProcessOverrides) && (object.Equals((object) this._Base, (object) ((BillOfProcess) obj)._Base) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((BillOfProcess) obj)._ModelingInstanceLocks)) && (object.Equals((object) this._FilterTags, (object) ((BillOfProcess) obj)._FilterTags) && object.Equals((object) this._ECO, (object) ((BillOfProcess) obj)._ECO) && (object.Equals((object) this._AssociatedPackages, (object) ((BillOfProcess) obj)._AssociatedPackages) && object.Equals((object) this._InstanceLocked, (object) ((BillOfProcess) obj)._InstanceLocked))) && (object.Equals((object) this._Description, (object) ((BillOfProcess) obj)._Description) && object.Equals((object) this._IconId, (object) ((BillOfProcess) obj)._IconId) && (object.Equals((object) this._Name, (object) ((BillOfProcess) obj)._Name) && object.Equals((object) this._WIPMsgDefMgr, (object) ((BillOfProcess) obj)._WIPMsgDefMgr)) && (object.Equals((object) this._Revision, (object) ((BillOfProcess) obj)._Revision) && object.Equals((object) this._Notes, (object) ((BillOfProcess) obj)._Notes) && (object.Equals((object) this._ChangeHistory, (object) ((BillOfProcess) obj)._ChangeHistory) && object.Equals((object) this._Status, (object) ((BillOfProcess) obj)._Status)))) && object.Equals((object) this._IsFrozen, (object) ((BillOfProcess) obj)._IsFrozen) && base.Equals(obj);
    }

    public BillOfProcessOverride[] BillOfProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcessOverrides), (object) value);
      }
      get
      {
        return (BillOfProcessOverride[]) this.PropertyGet(nameof (BillOfProcessOverrides));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public new SubentityRef[] ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Primitive<string> ECO
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECO), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ECO));
      }
    }

    public new Primitive<int> AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Primitive<bool> InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public new Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new WIPMsgDefMgr WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public new Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }

    public new Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public new ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public new Primitive<bool> IsFrozen
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

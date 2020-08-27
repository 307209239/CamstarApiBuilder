// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SubentityMaintenance
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
  public class SubentityMaintenance : Maintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "SubentityMaintenance_ObjectChanges")]
    protected SubentityChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "SubentityMaintenance_ObjectToChange")]
    protected SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SubentityMaintenance_ObjectListInquiry")]
    protected new BaseObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "SubentityMaintenance_ParentDataObject")]
    protected BaseObjectRef _ParentDataObject;

    public override bool Equals(object obj)
    {
      return obj is SubentityMaintenance && object.Equals((object) this._ObjectChanges, (object) ((SubentityMaintenance) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((SubentityMaintenance) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((SubentityMaintenance) obj)._ObjectListInquiry)) && object.Equals((object) this._ParentDataObject, (object) ((SubentityMaintenance) obj)._ParentDataObject) && base.Equals(obj);
    }

    public SubentityChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SubentityChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public SubentityRef ObjectToChange
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

    public new BaseObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public BaseObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}

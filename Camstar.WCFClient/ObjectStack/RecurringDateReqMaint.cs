// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecurringDateReqMaint
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
  public class RecurringDateReqMaint : MaintenanceReqMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqMaint_ObjectChanges")]
    protected RecurringDateReqChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is RecurringDateReqMaint && object.Equals((object) this._BaseToChange, (object) ((RecurringDateReqMaint) obj)._BaseToChange) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((RecurringDateReqMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectToChange, (object) ((RecurringDateReqMaint) obj)._ObjectToChange)) && object.Equals((object) this._ObjectChanges, (object) ((RecurringDateReqMaint) obj)._ObjectChanges) && base.Equals(obj);
    }

    public new RevisionedObjectRef BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public new RevisionedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RecurringDateReqChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RecurringDateReqChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ERPRouteMaint
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
  public class ERPRouteMaint : RevisionedObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteMaint_ObjectChanges")]
    protected ERPRouteChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ERPRouteMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;

    public override bool Equals(object obj)
    {
      return obj is ERPRouteMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ERPRouteMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectToChange, (object) ((ERPRouteMaint) obj)._ObjectToChange) && object.Equals((object) this._ObjectChanges, (object) ((ERPRouteMaint) obj)._ObjectChanges)) && object.Equals((object) this._BaseToChange, (object) ((ERPRouteMaint) obj)._BaseToChange) && base.Equals(obj);
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

    public ERPRouteChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ERPRouteChanges) this.PropertyGet(nameof (ObjectChanges));
      }
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
  }
}

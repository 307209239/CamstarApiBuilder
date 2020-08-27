// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecMaint
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
  public class SpecMaint : BusinessProcessSpecMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecMaint_ObjectChanges")]
    protected SpecChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "SpecMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SpecMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is SpecMaint && object.Equals((object) this._ObjectChanges, (object) ((SpecMaint) obj)._ObjectChanges) && (object.Equals((object) this._BaseToChange, (object) ((SpecMaint) obj)._BaseToChange) && object.Equals((object) this._ObjectToChange, (object) ((SpecMaint) obj)._ObjectToChange)) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((SpecMaint) obj)._ObjectListInquiry) && base.Equals(obj);
    }

    public SpecChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SpecChanges) this.PropertyGet(nameof (ObjectChanges));
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
  }
}

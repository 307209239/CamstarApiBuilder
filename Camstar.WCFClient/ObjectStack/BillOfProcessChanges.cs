// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcessChanges
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
  public class BillOfProcessChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_BillOfProcessOverrides")]
    protected BillOfProcessOverrideChanges[] _BillOfProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_Revision")]
    protected new Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is BillOfProcessChanges && object.Equals((object) this._Base, (object) ((BillOfProcessChanges) obj)._Base) && (object.Equals((object) this._ObjectToChange, (object) ((BillOfProcessChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._BillOfProcessOverrides, (Array) ((BillOfProcessChanges) obj)._BillOfProcessOverrides)) && (object.Equals((object) this._Revision, (object) ((BillOfProcessChanges) obj)._Revision) && object.Equals((object) this._Name, (object) ((BillOfProcessChanges) obj)._Name)) && base.Equals(obj);
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

    public BillOfProcessOverrideChanges[] BillOfProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillOfProcessOverrides), (object) value);
      }
      get
      {
        return (BillOfProcessOverrideChanges[]) this.PropertyGet(nameof (BillOfProcessOverrides));
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
  }
}

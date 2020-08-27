// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveNonStdChangePkg
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
  public class MoveNonStdChangePkg : BPMoveNonStd
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_TrackableObject")]
    protected NamedObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_ChangePackageHeader")]
    protected ChangePackageHeader _ChangePackageHeader;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_Spec")]
    protected new RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_Step")]
    protected new NamedSubentityRef _Step;

    public override bool Equals(object obj)
    {
      return obj is MoveNonStdChangePkg && object.Equals((object) this._Comments, (object) ((MoveNonStdChangePkg) obj)._Comments) && (object.Equals((object) this._TrackableObject, (object) ((MoveNonStdChangePkg) obj)._TrackableObject) && object.Equals((object) this._ChangePackageHeader, (object) ((MoveNonStdChangePkg) obj)._ChangePackageHeader)) && (object.Equals((object) this._Spec, (object) ((MoveNonStdChangePkg) obj)._Spec) && object.Equals((object) this._Step, (object) ((MoveNonStdChangePkg) obj)._Step)) && base.Equals(obj);
    }

    public new Primitive<string> Comments
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

    public NamedObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public ChangePackageHeader ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public new RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public new NamedSubentityRef Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Step));
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalTxn
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
  public class ApprovalTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_ChangePackageHeader")]
    protected ChangePackageHeader _ChangePackageHeader;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_TrackableObject")]
    protected BaseObjectRef _TrackableObject;

    public override bool Equals(object obj)
    {
      return obj is ApprovalTxn && object.Equals((object) this._Comments, (object) ((ApprovalTxn) obj)._Comments) && (object.Equals((object) this._ApprovalSheet, (object) ((ApprovalTxn) obj)._ApprovalSheet) && object.Equals((object) this._ChangePackageHeader, (object) ((ApprovalTxn) obj)._ChangePackageHeader)) && object.Equals((object) this._TrackableObject, (object) ((ApprovalTxn) obj)._TrackableObject) && base.Equals(obj);
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

    public NamedSubentityRef ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalSheet));
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

    public BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }
  }
}

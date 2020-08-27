// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidate
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RemovalCandidateLotStock))]
  [KnownType(typeof (RemovalCandidateQuantity))]
  [KnownType(typeof (RemovalCandidateStock))]
  [KnownType(typeof (RemovalCandidateBulk))]
  [KnownType(typeof (RemovalCandidateSerial))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class RemovalCandidate : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_IssueActualHistory")]
    protected IssueActualsHistory _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_NetQty2Issued")]
    protected Primitive<double> _NetQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_IssueControl")]
    protected Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_RemovalDetail")]
    protected RemovalDetail _RemovalDetail;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_IssuedFrom")]
    protected Primitive<string> _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_IssueControlName")]
    protected Primitive<string> _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_IssuedLocation")]
    protected Primitive<string> _IssuedLocation;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_QtyIssued")]
    protected Primitive<double> _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_ProductDescription")]
    protected Primitive<string> _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_NetQtyIssued")]
    protected Primitive<double> _NetQtyIssued;

    public override bool Equals(object obj)
    {
      return obj is RemovalCandidate && object.Equals((object) this._IssueActualHistory, (object) ((RemovalCandidate) obj)._IssueActualHistory) && (object.Equals((object) this._NetQty2Issued, (object) ((RemovalCandidate) obj)._NetQty2Issued) && object.Equals((object) this._IssueControl, (object) ((RemovalCandidate) obj)._IssueControl)) && (object.Equals((object) this._RemovalDetail, (object) ((RemovalCandidate) obj)._RemovalDetail) && object.Equals((object) this._Container, (object) ((RemovalCandidate) obj)._Container) && (object.Equals((object) this._IssuedFrom, (object) ((RemovalCandidate) obj)._IssuedFrom) && object.Equals((object) this._IssueControlName, (object) ((RemovalCandidate) obj)._IssueControlName))) && (object.Equals((object) this._IssuedLocation, (object) ((RemovalCandidate) obj)._IssuedLocation) && object.Equals((object) this._QtyIssued, (object) ((RemovalCandidate) obj)._QtyIssued) && (object.Equals((object) this._ProductDescription, (object) ((RemovalCandidate) obj)._ProductDescription) && object.Equals((object) this._Product, (object) ((RemovalCandidate) obj)._Product)) && object.Equals((object) this._NetQtyIssued, (object) ((RemovalCandidate) obj)._NetQtyIssued)) && base.Equals(obj);
    }

    public IssueActualsHistory IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public Primitive<double> NetQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NetQty2Issued));
      }
    }

    public Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public RemovalDetail RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetail) this.PropertyGet(nameof (RemovalDetail));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<string> IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public Primitive<string> IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Primitive<string> IssuedLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedLocation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssuedLocation));
      }
    }

    public Primitive<double> QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyIssued));
      }
    }

    public Primitive<string> ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public Primitive<double> NetQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NetQtyIssued));
      }
    }
  }
}

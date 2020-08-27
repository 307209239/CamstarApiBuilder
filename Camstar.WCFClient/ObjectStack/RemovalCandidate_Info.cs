// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalCandidate_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RemovalCandidateLotStock_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RemovalCandidateStock_Info))]
  [KnownType(typeof (RemovalCandidateQuantity_Info))]
  [KnownType(typeof (RemovalCandidateBulk_Info))]
  [KnownType(typeof (RemovalCandidateSerial_Info))]
  [Serializable]
  public class RemovalCandidate_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_IssueActualHistory")]
    protected IssueActualsHistory_Info _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_NetQty2Issued")]
    protected Info _NetQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_RemovalDetail")]
    protected RemovalDetail_Info _RemovalDetail;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_IssuedFrom")]
    protected Info _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_IssueControlName")]
    protected Info _IssueControlName;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_IssuedLocation")]
    protected Info _IssuedLocation;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_QtyIssued")]
    protected Info _QtyIssued;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_ProductDescription")]
    protected Info _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "RemovalCandidate_Info_NetQtyIssued")]
    protected Info _NetQtyIssued;

    public IssueActualsHistory_Info IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (IssueActualsHistory_Info) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public Info NetQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQty2Issued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NetQty2Issued));
      }
    }

    public Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }

    public RemovalDetail_Info RemovalDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemovalDetail), (object) value);
      }
      get
      {
        return (RemovalDetail_Info) this.PropertyGet(nameof (RemovalDetail));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public Info IssueControlName
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControlName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControlName));
      }
    }

    public Info IssuedLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuedLocation));
      }
    }

    public Info QtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyIssued));
      }
    }

    public Info ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public Info NetQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (NetQtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NetQtyIssued));
      }
    }
  }
}

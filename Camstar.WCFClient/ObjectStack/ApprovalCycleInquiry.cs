// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalCycleInquiry
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
  public class ApprovalCycleInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_ApprovalCycleInquiryDetails")]
    protected Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails[] _ApprovalCycleInquiryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_ApprovalCycleGMT")]
    protected Primitive<DateTime> _ApprovalCycleGMT;

    public override bool Equals(object obj)
    {
      return obj is ApprovalCycleInquiry && object.Equals((object) this._GeneralInstructions, (object) ((ApprovalCycleInquiry) obj)._GeneralInstructions) && (object.Equals((object) this._ApprovalSheet, (object) ((ApprovalCycleInquiry) obj)._ApprovalSheet) && this.CompareArrays((Array) this._ApprovalCycleInquiryDetails, (Array) ((ApprovalCycleInquiry) obj)._ApprovalCycleInquiryDetails)) && object.Equals((object) this._ApprovalCycleGMT, (object) ((ApprovalCycleInquiry) obj)._ApprovalCycleGMT) && base.Equals(obj);
    }

    public Primitive<string> GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralInstructions));
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

    public Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails[] ApprovalCycleInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleInquiryDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails[]) this.PropertyGet(nameof (ApprovalCycleInquiryDetails));
      }
    }

    public Primitive<DateTime> ApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ApprovalCycleGMT));
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalCycleInquiry_Info
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
  public class ApprovalCycleInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_Info_GeneralInstructions")]
    protected Info _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_Info_ApprovalCycleInquiryDetails")]
    protected ApprovalCycleInquiryDetails_Info _ApprovalCycleInquiryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_Info_ApprovalCycleGMT")]
    protected Info _ApprovalCycleGMT;

    public Info GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public Info ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public ApprovalCycleInquiryDetails_Info ApprovalCycleInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleInquiryDetails), (object) value);
      }
      get
      {
        return (ApprovalCycleInquiryDetails_Info) this.PropertyGet(nameof (ApprovalCycleInquiryDetails));
      }
    }

    public Info ApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalCycleGMT));
      }
    }
  }
}

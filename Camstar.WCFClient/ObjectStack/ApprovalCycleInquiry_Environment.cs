// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalCycleInquiry_Environment
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
  public class ApprovalCycleInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_Environment_GeneralInstructions")]
    [Metadata("Comments", "", false, false, true, "String", 1051979, false, false, false, null)]
    protected Environment _GeneralInstructions;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, true, false, "NamedSubentityRef", 1051639, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_Environment_ApprovalSheet")]
    protected Environment _ApprovalSheet;
    [Metadata("The detail information for the ApprovalCycleInquiry.", "ApprovalCycleInquiryDetails", false, false, true, "ApprovalCycleInquiryDetails", 1052002, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_Environment_ApprovalCycleInquiryDetails")]
    protected ApprovalCycleInquiryDetails_Environment _ApprovalCycleInquiryDetails;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051987, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiry_Environment_ApprovalCycleGMT")]
    protected Environment _ApprovalCycleGMT;

    public Environment GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public Environment ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public ApprovalCycleInquiryDetails_Environment ApprovalCycleInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleInquiryDetails), (object) value);
      }
      get
      {
        return (ApprovalCycleInquiryDetails_Environment) this.PropertyGet(nameof (ApprovalCycleInquiryDetails));
      }
    }

    public Environment ApprovalCycleGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalCycleGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalCycleGMT));
      }
    }
  }
}

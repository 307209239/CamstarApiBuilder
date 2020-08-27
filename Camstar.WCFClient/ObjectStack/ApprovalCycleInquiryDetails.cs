// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalCycleInquiryDetails
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
  public class ApprovalCycleInquiryDetails : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_PLMApprovalURL")]
    protected Primitive<string> _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_SpecialInstructions")]
    protected Primitive<string> _SpecialInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_ApproverRole")]
    protected NamedObjectRef _ApproverRole;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_PLMApprovalCode")]
    protected Primitive<string> _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_DecisionType")]
    protected Enumeration<DecisionTypeEnum, int> _DecisionType;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_LastRoutedOnGMT")]
    protected Primitive<DateTime> _LastRoutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_LastCompletedOnGMT")]
    protected Primitive<DateTime> _LastCompletedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_SheetLevel")]
    protected Primitive<int> _SheetLevel;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_CompleteByGMT")]
    protected Primitive<DateTime> _CompleteByGMT;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_DecisionTypeName")]
    protected Primitive<string> _DecisionTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_Approver")]
    protected NamedObjectRef _Approver;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalCycleInquiryDetails_ApprovedBy")]
    protected NamedObjectRef _ApprovedBy;

    public override bool Equals(object obj)
    {
      return obj is ApprovalCycleInquiryDetails && object.Equals((object) this._PLMApprovalURL, (object) ((ApprovalCycleInquiryDetails) obj)._PLMApprovalURL) && (object.Equals((object) this._SpecialInstructions, (object) ((ApprovalCycleInquiryDetails) obj)._SpecialInstructions) && object.Equals((object) this._ApproverRole, (object) ((ApprovalCycleInquiryDetails) obj)._ApproverRole)) && (object.Equals((object) this._Comments, (object) ((ApprovalCycleInquiryDetails) obj)._Comments) && object.Equals((object) this._PLMApprovalCode, (object) ((ApprovalCycleInquiryDetails) obj)._PLMApprovalCode) && (object.Equals((object) this._DecisionType, (object) ((ApprovalCycleInquiryDetails) obj)._DecisionType) && object.Equals((object) this._LastRoutedOnGMT, (object) ((ApprovalCycleInquiryDetails) obj)._LastRoutedOnGMT))) && (object.Equals((object) this._LastCompletedOnGMT, (object) ((ApprovalCycleInquiryDetails) obj)._LastCompletedOnGMT) && object.Equals((object) this._SheetLevel, (object) ((ApprovalCycleInquiryDetails) obj)._SheetLevel) && (object.Equals((object) this._CompleteByGMT, (object) ((ApprovalCycleInquiryDetails) obj)._CompleteByGMT) && object.Equals((object) this._DecisionTypeName, (object) ((ApprovalCycleInquiryDetails) obj)._DecisionTypeName)) && (object.Equals((object) this._Approver, (object) ((ApprovalCycleInquiryDetails) obj)._Approver) && object.Equals((object) this._ApprovedBy, (object) ((ApprovalCycleInquiryDetails) obj)._ApprovedBy))) && base.Equals(obj);
    }

    public Primitive<string> PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public Primitive<string> SpecialInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecialInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecialInstructions));
      }
    }

    public NamedObjectRef ApproverRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApproverRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApproverRole));
      }
    }

    public Primitive<string> Comments
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

    public Primitive<string> PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public Enumeration<DecisionTypeEnum, int> DecisionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionType), (object) value);
      }
      get
      {
        return (Enumeration<DecisionTypeEnum, int>) this.PropertyGet(nameof (DecisionType));
      }
    }

    public Primitive<DateTime> LastRoutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastRoutedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastRoutedOnGMT));
      }
    }

    public Primitive<DateTime> LastCompletedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastCompletedOnGMT));
      }
    }

    public Primitive<int> SheetLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SheetLevel), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SheetLevel));
      }
    }

    public Primitive<DateTime> CompleteByGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteByGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompleteByGMT));
      }
    }

    public Primitive<string> DecisionTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DecisionTypeName));
      }
    }

    public NamedObjectRef Approver
    {
      [param: In] set
      {
        this.PropertySet(nameof (Approver), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Approver));
      }
    }

    public NamedObjectRef ApprovedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovedBy));
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ApprovalCycleInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ApprovalCycleInquiryService : InquiryBase
  {
    public ApprovalCycleInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IApprovalCycleInquiryService), userProfile);
    }

    public ResultStatus GetApprovalCycleDetails(
      ApprovalCycleInquiry approvalCycleInquiry,
      ApprovalCycleInquiry_Parameters parameters,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      result = (ApprovalCycleInquiry_Result) null;
      this.OnBeforeCall(nameof (GetApprovalCycleDetails), (DCObject) approvalCycleInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalCycleInquiryService) this._Channel).GetApprovalCycleDetails(this._UserProfile, approvalCycleInquiry, parameters, request, out result) : this.AddMethod((Method) new ApprovalCycleInquiryMethod(approvalCycleInquiry, ApprovalCycleInquiryMethods.GetApprovalCycleDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalCycleDetails), res, (DCObject) approvalCycleInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalCycleDetails()
    {
      return this.GetApprovalCycleDetails((ApprovalCycleInquiry) null, (ApprovalCycleInquiry_Parameters) null, (ApprovalCycleInquiry_Request) null, out ApprovalCycleInquiry_Result _);
    }

    public ResultStatus GetApprovalCycleDetails(
      ApprovalCycleInquiry approvalCycleInquiry)
    {
      return this.GetApprovalCycleDetails(approvalCycleInquiry, (ApprovalCycleInquiry_Parameters) null, (ApprovalCycleInquiry_Request) null, out ApprovalCycleInquiry_Result _);
    }

    public ResultStatus GetApprovalCycleDetails(
      ApprovalCycleInquiry approvalCycleInquiry,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      return this.GetApprovalCycleDetails(approvalCycleInquiry, (ApprovalCycleInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalCycleInquiry approvalCycleInquiry,
      ApprovalCycleInquiry_Parameters parameters,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      result = (ApprovalCycleInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) approvalCycleInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalCycleInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, approvalCycleInquiry, parameters, request, out result) : this.AddMethod((Method) new ApprovalCycleInquiryMethod(approvalCycleInquiry, ApprovalCycleInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) approvalCycleInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ApprovalCycleInquiry) null, (ApprovalCycleInquiry_Parameters) null, (ApprovalCycleInquiry_Request) null, out ApprovalCycleInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ApprovalCycleInquiry approvalCycleInquiry)
    {
      return this.GetWIPMsgs(approvalCycleInquiry, (ApprovalCycleInquiry_Parameters) null, (ApprovalCycleInquiry_Request) null, out ApprovalCycleInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ApprovalCycleInquiry approvalCycleInquiry,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      return this.GetWIPMsgs(approvalCycleInquiry, (ApprovalCycleInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject approvalCycleInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalCycleInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ApprovalCycleInquiry) approvalCycleInquiry, (ApprovalCycleInquiry_Parameters) parameters, (ApprovalCycleInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      result = (ApprovalCycleInquiry_Result) null;
      try
      {
        ApprovalCycleInquiryMethod[] methods = new ApprovalCycleInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IApprovalCycleInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalCycleInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ApprovalCycleInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApprovalCycleInquiry cdo,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      result = (ApprovalCycleInquiry_Result) null;
      try
      {
        return ((IApprovalCycleInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalCycleInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ApprovalCycleInquiry) cdo, (ApprovalCycleInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      return this.GetEnvironment((ApprovalCycleInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ApprovalCycleInquiry cdo,
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      result = (ApprovalCycleInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IApprovalCycleInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ApprovalCycleInquiryMethod(cdo, ApprovalCycleInquiryMethods.ExecuteTransaction, (ApprovalCycleInquiry_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ApprovalCycleInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ApprovalCycleInquiry) cdo, (ApprovalCycleInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ApprovalCycleInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ApprovalCycleInquiry_Request) null, out ApprovalCycleInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ApprovalCycleInquiry_Request request,
      out ApprovalCycleInquiry_Result result)
    {
      return this.ExecuteTransaction((ApprovalCycleInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ApprovalCycleInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ApprovalCycleInquiryMethod(cdo, ApprovalCycleInquiryMethods.AddDataTransaction, (ApprovalCycleInquiry_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ApprovalCycleInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

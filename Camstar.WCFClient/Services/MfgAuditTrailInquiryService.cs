// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MfgAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MfgAuditTrailInquiryService : ContainerHistoryInquiryBase
  {
    public MfgAuditTrailInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMfgAuditTrailInquiryService), userProfile);
    }

    public ResultStatus GetParameters(
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_GetParameters_Parameters parameters,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      result = (MfgAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetParameters), (DCObject) mfgAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgAuditTrailInquiryService) this._Channel).GetParameters(this._UserProfile, mfgAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new MfgAuditTrailInquiryMethod(mfgAuditTrailInquiry, MfgAuditTrailInquiryMethods.GetParameters, (MfgAuditTrailInquiry_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetParameters), res, (DCObject) mfgAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetParameters()
    {
      return this.GetParameters((MfgAuditTrailInquiry) null, (MfgAuditTrailInquiry_GetParameters_Parameters) null, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus GetParameters(MfgAuditTrailInquiry mfgAuditTrailInquiry)
    {
      return this.GetParameters(mfgAuditTrailInquiry, (MfgAuditTrailInquiry_GetParameters_Parameters) null, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus GetParameters(
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      return this.GetParameters(mfgAuditTrailInquiry, (MfgAuditTrailInquiry_GetParameters_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Parameters parameters,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      result = (MfgAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) mfgAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgAuditTrailInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, mfgAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new MfgAuditTrailInquiryMethod(mfgAuditTrailInquiry, MfgAuditTrailInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) mfgAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MfgAuditTrailInquiry) null, (MfgAuditTrailInquiry_Parameters) null, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(MfgAuditTrailInquiry mfgAuditTrailInquiry)
    {
      return this.GetWIPMsgs(mfgAuditTrailInquiry, (MfgAuditTrailInquiry_Parameters) null, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      return this.GetWIPMsgs(mfgAuditTrailInquiry, (MfgAuditTrailInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GMTToLocal(
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_GMTToLocal_Parameters parameters,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      result = (MfgAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GMTToLocal), (DCObject) mfgAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgAuditTrailInquiryService) this._Channel).GMTToLocal(this._UserProfile, mfgAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new MfgAuditTrailInquiryMethod(mfgAuditTrailInquiry, MfgAuditTrailInquiryMethods.GMTToLocal, (MfgAuditTrailInquiry_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GMTToLocal), res, (DCObject) mfgAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GMTToLocal()
    {
      return this.GMTToLocal((MfgAuditTrailInquiry) null, (MfgAuditTrailInquiry_GMTToLocal_Parameters) null, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus GMTToLocal(MfgAuditTrailInquiry mfgAuditTrailInquiry)
    {
      return this.GMTToLocal(mfgAuditTrailInquiry, (MfgAuditTrailInquiry_GMTToLocal_Parameters) null, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus GMTToLocal(
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      return this.GMTToLocal(mfgAuditTrailInquiry, (MfgAuditTrailInquiry_GMTToLocal_Parameters) null, request, out result);
    }

    public ResultStatus InitSummaryAndDetails(
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Parameters parameters,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      result = (MfgAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (InitSummaryAndDetails), (DCObject) mfgAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgAuditTrailInquiryService) this._Channel).InitSummaryAndDetails(this._UserProfile, mfgAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new MfgAuditTrailInquiryMethod(mfgAuditTrailInquiry, MfgAuditTrailInquiryMethods.InitSummaryAndDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitSummaryAndDetails), res, (DCObject) mfgAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitSummaryAndDetails()
    {
      return this.InitSummaryAndDetails((MfgAuditTrailInquiry) null, (MfgAuditTrailInquiry_Parameters) null, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus InitSummaryAndDetails(MfgAuditTrailInquiry mfgAuditTrailInquiry)
    {
      return this.InitSummaryAndDetails(mfgAuditTrailInquiry, (MfgAuditTrailInquiry_Parameters) null, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus InitSummaryAndDetails(
      MfgAuditTrailInquiry mfgAuditTrailInquiry,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      return this.InitSummaryAndDetails(mfgAuditTrailInquiry, (MfgAuditTrailInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject mfgAuditTrailInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgAuditTrailInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MfgAuditTrailInquiry) mfgAuditTrailInquiry, (MfgAuditTrailInquiry_Parameters) parameters, (MfgAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      result = (MfgAuditTrailInquiry_Result) null;
      try
      {
        MfgAuditTrailInquiryMethod[] methods = new MfgAuditTrailInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMfgAuditTrailInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MfgAuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MfgAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MfgAuditTrailInquiry cdo,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      result = (MfgAuditTrailInquiry_Result) null;
      try
      {
        return ((IMfgAuditTrailInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MfgAuditTrailInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((MfgAuditTrailInquiry) cdo, (MfgAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      return this.GetEnvironment((MfgAuditTrailInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MfgAuditTrailInquiry cdo,
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      result = (MfgAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgAuditTrailInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MfgAuditTrailInquiryMethod(cdo, MfgAuditTrailInquiryMethods.ExecuteTransaction, (MfgAuditTrailInquiry_Parameters) null));
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
        MfgAuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MfgAuditTrailInquiry) cdo, (MfgAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MfgAuditTrailInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (MfgAuditTrailInquiry_Request) null, out MfgAuditTrailInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MfgAuditTrailInquiry_Request request,
      out MfgAuditTrailInquiry_Result result)
    {
      return this.ExecuteTransaction((MfgAuditTrailInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MfgAuditTrailInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MfgAuditTrailInquiryMethod(cdo, MfgAuditTrailInquiryMethods.AddDataTransaction, (MfgAuditTrailInquiry_Parameters) null));
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
        return this.AddDataTransaction((MfgAuditTrailInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

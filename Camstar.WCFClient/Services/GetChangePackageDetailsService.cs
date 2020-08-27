// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetChangePackageDetailsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GetChangePackageDetailsService : InquiryBase
  {
    public GetChangePackageDetailsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGetChangePackageDetailsService), userProfile);
    }

    public ResultStatus GetApprovalDetails(
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Parameters parameters,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      result = (GetChangePackageDetails_Result) null;
      this.OnBeforeCall(nameof (GetApprovalDetails), (DCObject) getChangePackageDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetChangePackageDetailsService) this._Channel).GetApprovalDetails(this._UserProfile, getChangePackageDetails, parameters, request, out result) : this.AddMethod((Method) new GetChangePackageDetailsMethod(getChangePackageDetails, GetChangePackageDetailsMethods.GetApprovalDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalDetails), res, (DCObject) getChangePackageDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalDetails()
    {
      return this.GetApprovalDetails((GetChangePackageDetails) null, (GetChangePackageDetails_Parameters) null, (GetChangePackageDetails_Request) null, out GetChangePackageDetails_Result _);
    }

    public ResultStatus GetApprovalDetails(
      GetChangePackageDetails getChangePackageDetails)
    {
      return this.GetApprovalDetails(getChangePackageDetails, (GetChangePackageDetails_Parameters) null, (GetChangePackageDetails_Request) null, out GetChangePackageDetails_Result _);
    }

    public ResultStatus GetApprovalDetails(
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      return this.GetApprovalDetails(getChangePackageDetails, (GetChangePackageDetails_Parameters) null, request, out result);
    }

    public ResultStatus GetPackageDetails(
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Parameters parameters,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      result = (GetChangePackageDetails_Result) null;
      this.OnBeforeCall(nameof (GetPackageDetails), (DCObject) getChangePackageDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetChangePackageDetailsService) this._Channel).GetPackageDetails(this._UserProfile, getChangePackageDetails, parameters, request, out result) : this.AddMethod((Method) new GetChangePackageDetailsMethod(getChangePackageDetails, GetChangePackageDetailsMethods.GetPackageDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetPackageDetails), res, (DCObject) getChangePackageDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetPackageDetails()
    {
      return this.GetPackageDetails((GetChangePackageDetails) null, (GetChangePackageDetails_Parameters) null, (GetChangePackageDetails_Request) null, out GetChangePackageDetails_Result _);
    }

    public ResultStatus GetPackageDetails(
      GetChangePackageDetails getChangePackageDetails)
    {
      return this.GetPackageDetails(getChangePackageDetails, (GetChangePackageDetails_Parameters) null, (GetChangePackageDetails_Request) null, out GetChangePackageDetails_Result _);
    }

    public ResultStatus GetPackageDetails(
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      return this.GetPackageDetails(getChangePackageDetails, (GetChangePackageDetails_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Parameters parameters,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      result = (GetChangePackageDetails_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) getChangePackageDetails, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetChangePackageDetailsService) this._Channel).GetWIPMsgs(this._UserProfile, getChangePackageDetails, parameters, request, out result) : this.AddMethod((Method) new GetChangePackageDetailsMethod(getChangePackageDetails, GetChangePackageDetailsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) getChangePackageDetails, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GetChangePackageDetails) null, (GetChangePackageDetails_Parameters) null, (GetChangePackageDetails_Request) null, out GetChangePackageDetails_Result _);
    }

    public ResultStatus GetWIPMsgs(GetChangePackageDetails getChangePackageDetails)
    {
      return this.GetWIPMsgs(getChangePackageDetails, (GetChangePackageDetails_Parameters) null, (GetChangePackageDetails_Request) null, out GetChangePackageDetails_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GetChangePackageDetails getChangePackageDetails,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      return this.GetWIPMsgs(getChangePackageDetails, (GetChangePackageDetails_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject getChangePackageDetails,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetChangePackageDetails_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GetChangePackageDetails) getChangePackageDetails, (GetChangePackageDetails_Parameters) parameters, (GetChangePackageDetails_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      result = (GetChangePackageDetails_Result) null;
      try
      {
        GetChangePackageDetailsMethod[] methods = new GetChangePackageDetailsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGetChangePackageDetailsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GetChangePackageDetails_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GetChangePackageDetails_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetChangePackageDetails cdo,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      result = (GetChangePackageDetails_Result) null;
      try
      {
        return ((IGetChangePackageDetailsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GetChangePackageDetails_Result result1;
        ResultStatus environment = this.GetEnvironment((GetChangePackageDetails) cdo, (GetChangePackageDetails_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      return this.GetEnvironment((GetChangePackageDetails) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GetChangePackageDetails cdo,
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      result = (GetChangePackageDetails_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetChangePackageDetailsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GetChangePackageDetailsMethod(cdo, GetChangePackageDetailsMethods.ExecuteTransaction, (GetChangePackageDetails_Parameters) null));
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
        GetChangePackageDetails_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GetChangePackageDetails) cdo, (GetChangePackageDetails_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GetChangePackageDetails cdo)
    {
      return this.ExecuteTransaction(cdo, (GetChangePackageDetails_Request) null, out GetChangePackageDetails_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GetChangePackageDetails_Request request,
      out GetChangePackageDetails_Result result)
    {
      return this.ExecuteTransaction((GetChangePackageDetails) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GetChangePackageDetails cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GetChangePackageDetailsMethod(cdo, GetChangePackageDetailsMethods.AddDataTransaction, (GetChangePackageDetails_Parameters) null));
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
        return this.AddDataTransaction((GetChangePackageDetails) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

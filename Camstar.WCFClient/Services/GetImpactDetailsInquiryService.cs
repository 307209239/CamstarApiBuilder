// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetImpactDetailsInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GetImpactDetailsInquiryService : GetChangePackageDetailsBase
  {
    public GetImpactDetailsInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGetImpactDetailsInquiryService), userProfile);
    }

    public ResultStatus GetImpactPackageDetails(
      GetImpactDetailsInquiry getImpactDetailsInquiry,
      GetImpactDetailsInquiry_Parameters parameters,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      result = (GetImpactDetailsInquiry_Result) null;
      this.OnBeforeCall(nameof (GetImpactPackageDetails), (DCObject) getImpactDetailsInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetImpactDetailsInquiryService) this._Channel).GetImpactPackageDetails(this._UserProfile, getImpactDetailsInquiry, parameters, request, out result) : this.AddMethod((Method) new GetImpactDetailsInquiryMethod(getImpactDetailsInquiry, GetImpactDetailsInquiryMethods.GetImpactPackageDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetImpactPackageDetails), res, (DCObject) getImpactDetailsInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetImpactPackageDetails()
    {
      return this.GetImpactPackageDetails((GetImpactDetailsInquiry) null, (GetImpactDetailsInquiry_Parameters) null, (GetImpactDetailsInquiry_Request) null, out GetImpactDetailsInquiry_Result _);
    }

    public ResultStatus GetImpactPackageDetails(
      GetImpactDetailsInquiry getImpactDetailsInquiry)
    {
      return this.GetImpactPackageDetails(getImpactDetailsInquiry, (GetImpactDetailsInquiry_Parameters) null, (GetImpactDetailsInquiry_Request) null, out GetImpactDetailsInquiry_Result _);
    }

    public ResultStatus GetImpactPackageDetails(
      GetImpactDetailsInquiry getImpactDetailsInquiry,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      return this.GetImpactPackageDetails(getImpactDetailsInquiry, (GetImpactDetailsInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      GetImpactDetailsInquiry getImpactDetailsInquiry,
      GetImpactDetailsInquiry_Parameters parameters,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      result = (GetImpactDetailsInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) getImpactDetailsInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetImpactDetailsInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, getImpactDetailsInquiry, parameters, request, out result) : this.AddMethod((Method) new GetImpactDetailsInquiryMethod(getImpactDetailsInquiry, GetImpactDetailsInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) getImpactDetailsInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GetImpactDetailsInquiry) null, (GetImpactDetailsInquiry_Parameters) null, (GetImpactDetailsInquiry_Request) null, out GetImpactDetailsInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(GetImpactDetailsInquiry getImpactDetailsInquiry)
    {
      return this.GetWIPMsgs(getImpactDetailsInquiry, (GetImpactDetailsInquiry_Parameters) null, (GetImpactDetailsInquiry_Request) null, out GetImpactDetailsInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GetImpactDetailsInquiry getImpactDetailsInquiry,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      return this.GetWIPMsgs(getImpactDetailsInquiry, (GetImpactDetailsInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject getImpactDetailsInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetImpactDetailsInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GetImpactDetailsInquiry) getImpactDetailsInquiry, (GetImpactDetailsInquiry_Parameters) parameters, (GetImpactDetailsInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      result = (GetImpactDetailsInquiry_Result) null;
      try
      {
        GetImpactDetailsInquiryMethod[] methods = new GetImpactDetailsInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGetImpactDetailsInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GetImpactDetailsInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GetImpactDetailsInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetImpactDetailsInquiry cdo,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      result = (GetImpactDetailsInquiry_Result) null;
      try
      {
        return ((IGetImpactDetailsInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GetImpactDetailsInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((GetImpactDetailsInquiry) cdo, (GetImpactDetailsInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      return this.GetEnvironment((GetImpactDetailsInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GetImpactDetailsInquiry cdo,
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      result = (GetImpactDetailsInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetImpactDetailsInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GetImpactDetailsInquiryMethod(cdo, GetImpactDetailsInquiryMethods.ExecuteTransaction, (GetImpactDetailsInquiry_Parameters) null));
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
        GetImpactDetailsInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GetImpactDetailsInquiry) cdo, (GetImpactDetailsInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GetImpactDetailsInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (GetImpactDetailsInquiry_Request) null, out GetImpactDetailsInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GetImpactDetailsInquiry_Request request,
      out GetImpactDetailsInquiry_Result result)
    {
      return this.ExecuteTransaction((GetImpactDetailsInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GetImpactDetailsInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GetImpactDetailsInquiryMethod(cdo, GetImpactDetailsInquiryMethods.AddDataTransaction, (GetImpactDetailsInquiry_Parameters) null));
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
        return this.AddDataTransaction((GetImpactDetailsInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

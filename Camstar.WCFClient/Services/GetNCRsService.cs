// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetNCRsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GetNCRsService : InquiryBase
  {
    public GetNCRsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGetNCRsService), userProfile);
    }

    public ResultStatus GetNonconformances(
      GetNCRs getNCRs,
      GetNCRs_Parameters parameters,
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      result = (GetNCRs_Result) null;
      this.OnBeforeCall(nameof (GetNonconformances), (DCObject) getNCRs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetNCRsService) this._Channel).GetNonconformances(this._UserProfile, getNCRs, parameters, request, out result) : this.AddMethod((Method) new GetNCRsMethod(getNCRs, GetNCRsMethods.GetNonconformances, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetNonconformances), res, (DCObject) getNCRs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetNonconformances()
    {
      return this.GetNonconformances((GetNCRs) null, (GetNCRs_Parameters) null, (GetNCRs_Request) null, out GetNCRs_Result _);
    }

    public ResultStatus GetNonconformances(GetNCRs getNCRs)
    {
      return this.GetNonconformances(getNCRs, (GetNCRs_Parameters) null, (GetNCRs_Request) null, out GetNCRs_Result _);
    }

    public ResultStatus GetNonconformances(
      GetNCRs getNCRs,
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      return this.GetNonconformances(getNCRs, (GetNCRs_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      GetNCRs getNCRs,
      GetNCRs_Parameters parameters,
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      result = (GetNCRs_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) getNCRs, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetNCRsService) this._Channel).GetWIPMsgs(this._UserProfile, getNCRs, parameters, request, out result) : this.AddMethod((Method) new GetNCRsMethod(getNCRs, GetNCRsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) getNCRs, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GetNCRs) null, (GetNCRs_Parameters) null, (GetNCRs_Request) null, out GetNCRs_Result _);
    }

    public ResultStatus GetWIPMsgs(GetNCRs getNCRs)
    {
      return this.GetWIPMsgs(getNCRs, (GetNCRs_Parameters) null, (GetNCRs_Request) null, out GetNCRs_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GetNCRs getNCRs,
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      return this.GetWIPMsgs(getNCRs, (GetNCRs_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject getNCRs,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetNCRs_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GetNCRs) getNCRs, (GetNCRs_Parameters) parameters, (GetNCRs_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      result = (GetNCRs_Result) null;
      try
      {
        GetNCRsMethod[] methods = new GetNCRsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGetNCRsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GetNCRs_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GetNCRs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetNCRs cdo,
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      result = (GetNCRs_Result) null;
      try
      {
        return ((IGetNCRsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GetNCRs_Result result1;
        ResultStatus environment = this.GetEnvironment((GetNCRs) cdo, (GetNCRs_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      return this.GetEnvironment((GetNCRs) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GetNCRs cdo,
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      result = (GetNCRs_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetNCRsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GetNCRsMethod(cdo, GetNCRsMethods.ExecuteTransaction, (GetNCRs_Parameters) null));
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
        GetNCRs_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GetNCRs) cdo, (GetNCRs_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GetNCRs cdo)
    {
      return this.ExecuteTransaction(cdo, (GetNCRs_Request) null, out GetNCRs_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GetNCRs_Request request,
      out GetNCRs_Result result)
    {
      return this.ExecuteTransaction((GetNCRs) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GetNCRs cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GetNCRsMethod(cdo, GetNCRsMethods.AddDataTransaction, (GetNCRs_Parameters) null));
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
        return this.AddDataTransaction((GetNCRs) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

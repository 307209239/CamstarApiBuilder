// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetMfgLotsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GetMfgLotsService : GetMfgDataBase
  {
    public GetMfgLotsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGetMfgLotsService), userProfile);
    }

    public ResultStatus GetData(
      GetMfgLots getMfgLots,
      GetMfgLots_Parameters parameters,
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      result = (GetMfgLots_Result) null;
      this.OnBeforeCall(nameof (GetData), (DCObject) getMfgLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMfgLotsService) this._Channel).GetData(this._UserProfile, getMfgLots, parameters, request, out result) : this.AddMethod((Method) new GetMfgLotsMethod(getMfgLots, GetMfgLotsMethods.GetData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetData), res, (DCObject) getMfgLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetData()
    {
      return this.GetData((GetMfgLots) null, (GetMfgLots_Parameters) null, (GetMfgLots_Request) null, out GetMfgLots_Result _);
    }

    public ResultStatus GetData(GetMfgLots getMfgLots)
    {
      return this.GetData(getMfgLots, (GetMfgLots_Parameters) null, (GetMfgLots_Request) null, out GetMfgLots_Result _);
    }

    public ResultStatus GetData(
      GetMfgLots getMfgLots,
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      return this.GetData(getMfgLots, (GetMfgLots_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      GetMfgLots getMfgLots,
      GetMfgLots_Parameters parameters,
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      result = (GetMfgLots_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) getMfgLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMfgLotsService) this._Channel).GetWIPMsgs(this._UserProfile, getMfgLots, parameters, request, out result) : this.AddMethod((Method) new GetMfgLotsMethod(getMfgLots, GetMfgLotsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) getMfgLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GetMfgLots) null, (GetMfgLots_Parameters) null, (GetMfgLots_Request) null, out GetMfgLots_Result _);
    }

    public ResultStatus GetWIPMsgs(GetMfgLots getMfgLots)
    {
      return this.GetWIPMsgs(getMfgLots, (GetMfgLots_Parameters) null, (GetMfgLots_Request) null, out GetMfgLots_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GetMfgLots getMfgLots,
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      return this.GetWIPMsgs(getMfgLots, (GetMfgLots_Parameters) null, request, out result);
    }

    public ResultStatus RetrieveContainers(
      GetMfgLots getMfgLots,
      GetMfgLots_Parameters parameters,
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      result = (GetMfgLots_Result) null;
      this.OnBeforeCall(nameof (RetrieveContainers), (DCObject) getMfgLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMfgLotsService) this._Channel).RetrieveContainers(this._UserProfile, getMfgLots, parameters, request, out result) : this.AddMethod((Method) new GetMfgLotsMethod(getMfgLots, GetMfgLotsMethods.RetrieveContainers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RetrieveContainers), res, (DCObject) getMfgLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RetrieveContainers()
    {
      return this.RetrieveContainers((GetMfgLots) null, (GetMfgLots_Parameters) null, (GetMfgLots_Request) null, out GetMfgLots_Result _);
    }

    public ResultStatus RetrieveContainers(GetMfgLots getMfgLots)
    {
      return this.RetrieveContainers(getMfgLots, (GetMfgLots_Parameters) null, (GetMfgLots_Request) null, out GetMfgLots_Result _);
    }

    public ResultStatus RetrieveContainers(
      GetMfgLots getMfgLots,
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      return this.RetrieveContainers(getMfgLots, (GetMfgLots_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetData(
      DCObject getMfgLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetMfgLots_Result result1;
        ResultStatus data = this.GetData((GetMfgLots) getMfgLots, (GetMfgLots_Parameters) parameters, (GetMfgLots_Request) request, out result1);
        result = (Result) result1;
        return data;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject getMfgLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetMfgLots_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GetMfgLots) getMfgLots, (GetMfgLots_Parameters) parameters, (GetMfgLots_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      result = (GetMfgLots_Result) null;
      try
      {
        GetMfgLotsMethod[] methods = new GetMfgLotsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGetMfgLotsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GetMfgLots_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GetMfgLots_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetMfgLots cdo,
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      result = (GetMfgLots_Result) null;
      try
      {
        return ((IGetMfgLotsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GetMfgLots_Result result1;
        ResultStatus environment = this.GetEnvironment((GetMfgLots) cdo, (GetMfgLots_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      return this.GetEnvironment((GetMfgLots) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GetMfgLots cdo,
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      result = (GetMfgLots_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMfgLotsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GetMfgLotsMethod(cdo, GetMfgLotsMethods.ExecuteTransaction, (GetMfgLots_Parameters) null));
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
        GetMfgLots_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GetMfgLots) cdo, (GetMfgLots_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GetMfgLots cdo)
    {
      return this.ExecuteTransaction(cdo, (GetMfgLots_Request) null, out GetMfgLots_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GetMfgLots_Request request,
      out GetMfgLots_Result result)
    {
      return this.ExecuteTransaction((GetMfgLots) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GetMfgLots cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GetMfgLotsMethod(cdo, GetMfgLotsMethods.AddDataTransaction, (GetMfgLots_Parameters) null));
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
        return this.AddDataTransaction((GetMfgLots) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

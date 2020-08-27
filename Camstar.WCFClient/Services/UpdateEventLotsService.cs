// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventLotsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventLotsService : UpdateEventDetailsBase
  {
    public UpdateEventLotsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventLotsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).CreateParametricData(this._UserProfile, updateEventLots, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(updateEventLots, UpdateEventLotsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventLots) null, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus CreateParametricData(UpdateEventLots updateEventLots)
    {
      return this.CreateParametricData(updateEventLots, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.CreateParametricData(updateEventLots, (UpdateEventLots_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).GetActions(this._UserProfile, updateEventLots, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(updateEventLots, UpdateEventLotsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventLots) null, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus GetActions(UpdateEventLots updateEventLots)
    {
      return this.GetActions(updateEventLots, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.GetActions(updateEventLots, (UpdateEventLots_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).GetDataPoints(this._UserProfile, updateEventLots, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(updateEventLots, UpdateEventLotsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventLots) null, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventLots updateEventLots)
    {
      return this.GetDataPoints(updateEventLots, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.GetDataPoints(updateEventLots, (UpdateEventLots_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventLots, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(updateEventLots, UpdateEventLotsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventLots) null, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventLots updateEventLots)
    {
      return this.GetWIPMsgs(updateEventLots, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.GetWIPMsgs(updateEventLots, (UpdateEventLots_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).Load(this._UserProfile, updateEventLots, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(updateEventLots, UpdateEventLotsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventLots) null, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus Load(UpdateEventLots updateEventLots)
    {
      return this.Load(updateEventLots, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus Load(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.Load(updateEventLots, (UpdateEventLots_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).LoadESigDetails(this._UserProfile, updateEventLots, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(updateEventLots, UpdateEventLotsMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventLots) null, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEventLots updateEventLots)
    {
      return this.LoadESigDetails(updateEventLots, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.LoadESigDetails(updateEventLots, (UpdateEventLots_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).ProcessComputation(this._UserProfile, updateEventLots, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(updateEventLots, UpdateEventLotsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventLots) null, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus ProcessComputation(UpdateEventLots updateEventLots)
    {
      return this.ProcessComputation(updateEventLots, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.ProcessComputation(updateEventLots, (UpdateEventLots_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Parameters parameters,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventLots, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).ResolveParametricData(this._UserProfile, updateEventLots, parameters, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(updateEventLots, UpdateEventLotsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventLots, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventLots) null, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateEventLots updateEventLots)
    {
      return this.ResolveParametricData(updateEventLots, (UpdateEventLots_Parameters) null, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventLots updateEventLots,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.ResolveParametricData(updateEventLots, (UpdateEventLots_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLots_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventLots) updateEventLots, (UpdateEventLots_Parameters) parameters, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLots_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventLots) updateEventLots, (UpdateEventLots_Parameters) parameters, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLots_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventLots) updateEventLots, (UpdateEventLots_Parameters) parameters, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLots_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventLots) updateEventLots, (UpdateEventLots_Parameters) parameters, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLots_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventLots) updateEventLots, (UpdateEventLots_Parameters) parameters, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLots_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventLots) updateEventLots, (UpdateEventLots_Parameters) parameters, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLots_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventLots) updateEventLots, (UpdateEventLots_Parameters) parameters, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventLots,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventLots_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventLots) updateEventLots, (UpdateEventLots_Parameters) parameters, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      try
      {
        UpdateEventLotsMethod[] methods = new UpdateEventLotsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventLotsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventLots_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventLots cdo,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      try
      {
        return ((IUpdateEventLotsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventLots_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventLots) cdo, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.GetEnvironment((UpdateEventLots) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventLots cdo,
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      result = (UpdateEventLots_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventLotsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventLotsMethod(cdo, UpdateEventLotsMethods.ExecuteTransaction, (UpdateEventLots_Parameters) null));
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
        UpdateEventLots_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventLots) cdo, (UpdateEventLots_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventLots cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventLots_Request) null, out UpdateEventLots_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventLots_Request request,
      out UpdateEventLots_Result result)
    {
      return this.ExecuteTransaction((UpdateEventLots) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventLots cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventLotsMethod(cdo, UpdateEventLotsMethods.AddDataTransaction, (UpdateEventLots_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventLots) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

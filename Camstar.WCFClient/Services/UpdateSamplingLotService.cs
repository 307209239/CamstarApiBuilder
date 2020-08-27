// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateSamplingLotService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateSamplingLotService : SamplingLotTxnBase
  {
    public UpdateSamplingLotService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateSamplingLotService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).CreateParametricData(this._UserProfile, updateSamplingLot, parameters, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(updateSamplingLot, UpdateSamplingLotMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateSamplingLot) null, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus CreateParametricData(UpdateSamplingLot updateSamplingLot)
    {
      return this.CreateParametricData(updateSamplingLot, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.CreateParametricData(updateSamplingLot, (UpdateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).GetActions(this._UserProfile, updateSamplingLot, parameters, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(updateSamplingLot, UpdateSamplingLotMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateSamplingLot) null, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus GetActions(UpdateSamplingLot updateSamplingLot)
    {
      return this.GetActions(updateSamplingLot, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus GetActions(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.GetActions(updateSamplingLot, (UpdateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).GetDataPoints(this._UserProfile, updateSamplingLot, parameters, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(updateSamplingLot, UpdateSamplingLotMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateSamplingLot) null, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus GetDataPoints(UpdateSamplingLot updateSamplingLot)
    {
      return this.GetDataPoints(updateSamplingLot, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.GetDataPoints(updateSamplingLot, (UpdateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).GetWIPMsgs(this._UserProfile, updateSamplingLot, parameters, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(updateSamplingLot, UpdateSamplingLotMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateSamplingLot) null, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateSamplingLot updateSamplingLot)
    {
      return this.GetWIPMsgs(updateSamplingLot, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.GetWIPMsgs(updateSamplingLot, (UpdateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).Load(this._UserProfile, updateSamplingLot, parameters, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(updateSamplingLot, UpdateSamplingLotMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateSamplingLot) null, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus Load(UpdateSamplingLot updateSamplingLot)
    {
      return this.Load(updateSamplingLot, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus Load(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.Load(updateSamplingLot, (UpdateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_LoadESigDetails_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).LoadESigDetails(this._UserProfile, updateSamplingLot, parameters, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(updateSamplingLot, UpdateSamplingLotMethods.LoadESigDetails, (UpdateSamplingLot_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateSamplingLot) null, (UpdateSamplingLot_LoadESigDetails_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateSamplingLot updateSamplingLot)
    {
      return this.LoadESigDetails(updateSamplingLot, (UpdateSamplingLot_LoadESigDetails_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.LoadESigDetails(updateSamplingLot, (UpdateSamplingLot_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).ProcessComputation(this._UserProfile, updateSamplingLot, parameters, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(updateSamplingLot, UpdateSamplingLotMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateSamplingLot) null, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus ProcessComputation(UpdateSamplingLot updateSamplingLot)
    {
      return this.ProcessComputation(updateSamplingLot, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.ProcessComputation(updateSamplingLot, (UpdateSamplingLot_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Parameters parameters,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).ResolveParametricData(this._UserProfile, updateSamplingLot, parameters, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(updateSamplingLot, UpdateSamplingLotMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateSamplingLot, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateSamplingLot) null, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateSamplingLot updateSamplingLot)
    {
      return this.ResolveParametricData(updateSamplingLot, (UpdateSamplingLot_Parameters) null, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateSamplingLot updateSamplingLot,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.ResolveParametricData(updateSamplingLot, (UpdateSamplingLot_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateSamplingLot_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateSamplingLot) updateSamplingLot, (UpdateSamplingLot_Parameters) parameters, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateSamplingLot_Result result1;
        ResultStatus actions = this.GetActions((UpdateSamplingLot) updateSamplingLot, (UpdateSamplingLot_Parameters) parameters, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateSamplingLot_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateSamplingLot) updateSamplingLot, (UpdateSamplingLot_Parameters) parameters, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateSamplingLot_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateSamplingLot) updateSamplingLot, (UpdateSamplingLot_LoadESigDetails_Parameters) parameters, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateSamplingLot_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateSamplingLot) updateSamplingLot, (UpdateSamplingLot_Parameters) parameters, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateSamplingLot_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateSamplingLot) updateSamplingLot, (UpdateSamplingLot_Parameters) parameters, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateSamplingLot_Result result1;
        ResultStatus resultStatus = this.Load((UpdateSamplingLot) updateSamplingLot, (UpdateSamplingLot_Parameters) parameters, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateSamplingLot,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateSamplingLot_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateSamplingLot) updateSamplingLot, (UpdateSamplingLot_Parameters) parameters, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      try
      {
        UpdateSamplingLotMethod[] methods = new UpdateSamplingLotMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateSamplingLotService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateSamplingLot_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateSamplingLot cdo,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      try
      {
        return ((IUpdateSamplingLotService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateSamplingLot_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateSamplingLot) cdo, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.GetEnvironment((UpdateSamplingLot) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateSamplingLot cdo,
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      result = (UpdateSamplingLot_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateSamplingLotService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateSamplingLotMethod(cdo, UpdateSamplingLotMethods.ExecuteTransaction, (UpdateSamplingLot_Parameters) null));
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
        UpdateSamplingLot_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateSamplingLot) cdo, (UpdateSamplingLot_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateSamplingLot cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateSamplingLot_Request) null, out UpdateSamplingLot_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateSamplingLot_Request request,
      out UpdateSamplingLot_Result result)
    {
      return this.ExecuteTransaction((UpdateSamplingLot) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateSamplingLot cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateSamplingLotMethod(cdo, UpdateSamplingLotMethods.AddDataTransaction, (UpdateSamplingLot_Parameters) null));
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
        return this.AddDataTransaction((UpdateSamplingLot) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

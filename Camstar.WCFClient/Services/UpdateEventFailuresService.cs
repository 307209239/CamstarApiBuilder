// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventFailuresService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventFailuresService : UpdateEventDetailsBase
  {
    public UpdateEventFailuresService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventFailuresService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventFailures, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).CreateParametricData(this._UserProfile, updateEventFailures, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(updateEventFailures, UpdateEventFailuresMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventFailures, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventFailures) null, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus CreateParametricData(UpdateEventFailures updateEventFailures)
    {
      return this.CreateParametricData(updateEventFailures, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.CreateParametricData(updateEventFailures, (UpdateEventFailures_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventFailures, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).GetActions(this._UserProfile, updateEventFailures, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(updateEventFailures, UpdateEventFailuresMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventFailures, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventFailures) null, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus GetActions(UpdateEventFailures updateEventFailures)
    {
      return this.GetActions(updateEventFailures, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.GetActions(updateEventFailures, (UpdateEventFailures_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventFailures, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).GetDataPoints(this._UserProfile, updateEventFailures, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(updateEventFailures, UpdateEventFailuresMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventFailures, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventFailures) null, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus GetDataPoints(UpdateEventFailures updateEventFailures)
    {
      return this.GetDataPoints(updateEventFailures, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.GetDataPoints(updateEventFailures, (UpdateEventFailures_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventFailures, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventFailures, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(updateEventFailures, UpdateEventFailuresMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventFailures, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventFailures) null, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateEventFailures updateEventFailures)
    {
      return this.GetWIPMsgs(updateEventFailures, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.GetWIPMsgs(updateEventFailures, (UpdateEventFailures_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventFailures, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).Load(this._UserProfile, updateEventFailures, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(updateEventFailures, UpdateEventFailuresMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventFailures, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventFailures) null, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus Load(UpdateEventFailures updateEventFailures)
    {
      return this.Load(updateEventFailures, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus Load(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.Load(updateEventFailures, (UpdateEventFailures_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventFailures, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).LoadESigDetails(this._UserProfile, updateEventFailures, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(updateEventFailures, UpdateEventFailuresMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventFailures, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventFailures) null, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateEventFailures updateEventFailures)
    {
      return this.LoadESigDetails(updateEventFailures, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.LoadESigDetails(updateEventFailures, (UpdateEventFailures_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventFailures, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).ProcessComputation(this._UserProfile, updateEventFailures, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(updateEventFailures, UpdateEventFailuresMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventFailures, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventFailures) null, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus ProcessComputation(UpdateEventFailures updateEventFailures)
    {
      return this.ProcessComputation(updateEventFailures, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.ProcessComputation(updateEventFailures, (UpdateEventFailures_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Parameters parameters,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventFailures, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).ResolveParametricData(this._UserProfile, updateEventFailures, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(updateEventFailures, UpdateEventFailuresMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventFailures, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventFailures) null, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateEventFailures updateEventFailures)
    {
      return this.ResolveParametricData(updateEventFailures, (UpdateEventFailures_Parameters) null, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventFailures updateEventFailures,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.ResolveParametricData(updateEventFailures, (UpdateEventFailures_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventFailures,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailures_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventFailures) updateEventFailures, (UpdateEventFailures_Parameters) parameters, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventFailures,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailures_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventFailures) updateEventFailures, (UpdateEventFailures_Parameters) parameters, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventFailures,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailures_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventFailures) updateEventFailures, (UpdateEventFailures_Parameters) parameters, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventFailures,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailures_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventFailures) updateEventFailures, (UpdateEventFailures_Parameters) parameters, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventFailures,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailures_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventFailures) updateEventFailures, (UpdateEventFailures_Parameters) parameters, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventFailures,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailures_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventFailures) updateEventFailures, (UpdateEventFailures_Parameters) parameters, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventFailures,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailures_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventFailures) updateEventFailures, (UpdateEventFailures_Parameters) parameters, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventFailures,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailures_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventFailures) updateEventFailures, (UpdateEventFailures_Parameters) parameters, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      try
      {
        UpdateEventFailuresMethod[] methods = new UpdateEventFailuresMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventFailuresService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventFailures_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventFailures cdo,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      try
      {
        return ((IUpdateEventFailuresService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventFailures_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventFailures) cdo, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.GetEnvironment((UpdateEventFailures) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventFailures cdo,
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      result = (UpdateEventFailures_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailuresService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventFailuresMethod(cdo, UpdateEventFailuresMethods.ExecuteTransaction, (UpdateEventFailures_Parameters) null));
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
        UpdateEventFailures_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventFailures) cdo, (UpdateEventFailures_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventFailures cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventFailures_Request) null, out UpdateEventFailures_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventFailures_Request request,
      out UpdateEventFailures_Result result)
    {
      return this.ExecuteTransaction((UpdateEventFailures) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventFailures cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventFailuresMethod(cdo, UpdateEventFailuresMethods.AddDataTransaction, (UpdateEventFailures_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventFailures) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

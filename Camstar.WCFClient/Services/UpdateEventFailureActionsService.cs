// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventFailureActionsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateEventFailureActionsService : UpdateEventDetailsBase
  {
    public UpdateEventFailureActionsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateEventFailureActionsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).CreateParametricData(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.CreateParametricData(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.CreateParametricData(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).GetActions(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.GetActions(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetActions(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.GetActions(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).GetDataPoints(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.GetDataPoints(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.GetDataPoints(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus GetEventActions(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_GetEventActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (GetEventActions), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).GetEventActions(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.GetEventActions, (UpdateEventFailureActions_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetEventActions), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetEventActions()
    {
      return this.GetEventActions((UpdateEventFailureActions) null, (UpdateEventFailureActions_GetEventActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetEventActions(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.GetEventActions(updateEventFailureActions, (UpdateEventFailureActions_GetEventActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetEventActions(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.GetEventActions(updateEventFailureActions, (UpdateEventFailureActions_GetEventActions_Parameters) null, request, out result);
    }

    public ResultStatus GetFailures(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_GetFailures_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (GetFailures), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).GetFailures(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.GetFailures, (UpdateEventFailureActions_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetFailures), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetFailures()
    {
      return this.GetFailures((UpdateEventFailureActions) null, (UpdateEventFailureActions_GetFailures_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetFailures(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.GetFailures(updateEventFailureActions, (UpdateEventFailureActions_GetFailures_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetFailures(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.GetFailures(updateEventFailureActions, (UpdateEventFailureActions_GetFailures_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).GetWIPMsgs(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.GetWIPMsgs(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.GetWIPMsgs(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).Load(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus Load(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.Load(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus Load(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.Load(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).LoadESigDetails(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.LoadESigDetails(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.LoadESigDetails(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus ModifyEventActions(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (ModifyEventActions), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).ModifyEventActions(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.ModifyEventActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ModifyEventActions), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ModifyEventActions()
    {
      return this.ModifyEventActions((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ModifyEventActions(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.ModifyEventActions(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ModifyEventActions(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.ModifyEventActions(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus ModifyFailures(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (ModifyFailures), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).ModifyFailures(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.ModifyFailures, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ModifyFailures), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ModifyFailures()
    {
      return this.ModifyFailures((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ModifyFailures(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.ModifyFailures(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ModifyFailures(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.ModifyFailures(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).ProcessComputation(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.ProcessComputation(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.ProcessComputation(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Parameters parameters,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).ResolveParametricData(this._UserProfile, updateEventFailureActions, parameters, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(updateEventFailureActions, UpdateEventFailureActionsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateEventFailureActions, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateEventFailureActions) null, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventFailureActions updateEventFailureActions)
    {
      return this.ResolveParametricData(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateEventFailureActions updateEventFailureActions,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.ResolveParametricData(updateEventFailureActions, (UpdateEventFailureActions_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateEventFailureActions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureActions_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateEventFailureActions) updateEventFailureActions, (UpdateEventFailureActions_Parameters) parameters, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateEventFailureActions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureActions_Result result1;
        ResultStatus actions = this.GetActions((UpdateEventFailureActions) updateEventFailureActions, (UpdateEventFailureActions_Parameters) parameters, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateEventFailureActions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureActions_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateEventFailureActions) updateEventFailureActions, (UpdateEventFailureActions_Parameters) parameters, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateEventFailureActions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureActions_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateEventFailureActions) updateEventFailureActions, (UpdateEventFailureActions_Parameters) parameters, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateEventFailureActions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureActions_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateEventFailureActions) updateEventFailureActions, (UpdateEventFailureActions_Parameters) parameters, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateEventFailureActions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureActions_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateEventFailureActions) updateEventFailureActions, (UpdateEventFailureActions_Parameters) parameters, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateEventFailureActions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureActions_Result result1;
        ResultStatus resultStatus = this.Load((UpdateEventFailureActions) updateEventFailureActions, (UpdateEventFailureActions_Parameters) parameters, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateEventFailureActions,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateEventFailureActions_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateEventFailureActions) updateEventFailureActions, (UpdateEventFailureActions_Parameters) parameters, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      try
      {
        UpdateEventFailureActionsMethod[] methods = new UpdateEventFailureActionsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateEventFailureActionsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UpdateEventFailureActions_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventFailureActions cdo,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      try
      {
        return ((IUpdateEventFailureActionsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UpdateEventFailureActions_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateEventFailureActions) cdo, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.GetEnvironment((UpdateEventFailureActions) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventFailureActions cdo,
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      result = (UpdateEventFailureActions_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateEventFailureActionsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateEventFailureActionsMethod(cdo, UpdateEventFailureActionsMethods.ExecuteTransaction, (UpdateEventFailureActions_Parameters) null));
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
        UpdateEventFailureActions_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateEventFailureActions) cdo, (UpdateEventFailureActions_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateEventFailureActions cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateEventFailureActions_Request) null, out UpdateEventFailureActions_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateEventFailureActions_Request request,
      out UpdateEventFailureActions_Result result)
    {
      return this.ExecuteTransaction((UpdateEventFailureActions) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateEventFailureActions cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateEventFailureActionsMethod(cdo, UpdateEventFailureActionsMethods.AddDataTransaction, (UpdateEventFailureActions_Parameters) null));
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
        return this.AddDataTransaction((UpdateEventFailureActions) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

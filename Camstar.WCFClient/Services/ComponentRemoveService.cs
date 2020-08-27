// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentRemoveService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentRemoveService : ContainerTxnBase
  {
    public ComponentRemoveService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentRemoveService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).CreateParametricData(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus CreateParametricData(ComponentRemove componentRemove)
    {
      return this.CreateParametricData(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus CreateParametricData(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.CreateParametricData(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).GetActions(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetActions(ComponentRemove componentRemove)
    {
      return this.GetActions(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetActions(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.GetActions(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).GetDataPoints(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetDataPoints(ComponentRemove componentRemove)
    {
      return this.GetDataPoints(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetDataPoints(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.GetDataPoints(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus GetIssueActualsHistory(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (GetIssueActualsHistory), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).GetIssueActualsHistory(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.GetIssueActualsHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetIssueActualsHistory), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetIssueActualsHistory()
    {
      return this.GetIssueActualsHistory((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetIssueActualsHistory(ComponentRemove componentRemove)
    {
      return this.GetIssueActualsHistory(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetIssueActualsHistory(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.GetIssueActualsHistory(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus GetRemovalCandidates(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (GetRemovalCandidates), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).GetRemovalCandidates(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.GetRemovalCandidates, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetRemovalCandidates), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetRemovalCandidates()
    {
      return this.GetRemovalCandidates((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetRemovalCandidates(ComponentRemove componentRemove)
    {
      return this.GetRemovalCandidates(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetRemovalCandidates(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.GetRemovalCandidates(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus GetRemovalHistoryDetails(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (GetRemovalHistoryDetails), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).GetRemovalHistoryDetails(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.GetRemovalHistoryDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetRemovalHistoryDetails), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetRemovalHistoryDetails()
    {
      return this.GetRemovalHistoryDetails((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetRemovalHistoryDetails(ComponentRemove componentRemove)
    {
      return this.GetRemovalHistoryDetails(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetRemovalHistoryDetails(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.GetRemovalHistoryDetails(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).GetWIPMsgs(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetWIPMsgs(ComponentRemove componentRemove)
    {
      return this.GetWIPMsgs(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.GetWIPMsgs(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).Load(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus Load(ComponentRemove componentRemove)
    {
      return this.Load(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus Load(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.Load(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ComponentRemove componentRemove,
      ComponentRemove_LoadESigDetails_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).LoadESigDetails(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.LoadESigDetails, (ComponentRemove_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ComponentRemove) null, (ComponentRemove_LoadESigDetails_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus LoadESigDetails(ComponentRemove componentRemove)
    {
      return this.LoadESigDetails(componentRemove, (ComponentRemove_LoadESigDetails_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.LoadESigDetails(componentRemove, (ComponentRemove_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).ProcessComputation(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus ProcessComputation(ComponentRemove componentRemove)
    {
      return this.ProcessComputation(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus ProcessComputation(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.ProcessComputation(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ComponentRemove componentRemove,
      ComponentRemove_Parameters parameters,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) componentRemove, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).ResolveParametricData(this._UserProfile, componentRemove, parameters, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(componentRemove, ComponentRemoveMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) componentRemove, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ComponentRemove) null, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus ResolveParametricData(ComponentRemove componentRemove)
    {
      return this.ResolveParametricData(componentRemove, (ComponentRemove_Parameters) null, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus ResolveParametricData(
      ComponentRemove componentRemove,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.ResolveParametricData(componentRemove, (ComponentRemove_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject componentRemove,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentRemove_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ComponentRemove) componentRemove, (ComponentRemove_Parameters) parameters, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject componentRemove,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentRemove_Result result1;
        ResultStatus actions = this.GetActions((ComponentRemove) componentRemove, (ComponentRemove_Parameters) parameters, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject componentRemove,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentRemove_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ComponentRemove) componentRemove, (ComponentRemove_Parameters) parameters, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject componentRemove,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentRemove_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ComponentRemove) componentRemove, (ComponentRemove_LoadESigDetails_Parameters) parameters, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject componentRemove,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentRemove_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ComponentRemove) componentRemove, (ComponentRemove_Parameters) parameters, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject componentRemove,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentRemove_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ComponentRemove) componentRemove, (ComponentRemove_Parameters) parameters, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject componentRemove,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentRemove_Result result1;
        ResultStatus resultStatus = this.Load((ComponentRemove) componentRemove, (ComponentRemove_Parameters) parameters, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentRemove,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentRemove_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentRemove) componentRemove, (ComponentRemove_Parameters) parameters, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      try
      {
        ComponentRemoveMethod[] methods = new ComponentRemoveMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentRemoveService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentRemove_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentRemove cdo,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      try
      {
        return ((IComponentRemoveService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentRemove_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentRemove) cdo, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.GetEnvironment((ComponentRemove) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentRemove cdo,
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      result = (ComponentRemove_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentRemoveService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentRemoveMethod(cdo, ComponentRemoveMethods.ExecuteTransaction, (ComponentRemove_Parameters) null));
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
        ComponentRemove_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentRemove) cdo, (ComponentRemove_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentRemove cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentRemove_Request) null, out ComponentRemove_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentRemove_Request request,
      out ComponentRemove_Result result)
    {
      return this.ExecuteTransaction((ComponentRemove) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentRemove cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentRemoveMethod(cdo, ComponentRemoveMethods.AddDataTransaction, (ComponentRemove_Parameters) null));
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
        return this.AddDataTransaction((ComponentRemove) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

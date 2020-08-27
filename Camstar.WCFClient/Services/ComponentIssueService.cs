// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentIssueService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentIssueService : ContainerTxnBase
  {
    public ComponentIssueService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentIssueService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).CreateParametricData(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus CreateParametricData(ComponentIssue componentIssue)
    {
      return this.CreateParametricData(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus CreateParametricData(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.CreateParametricData(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).GetActions(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetActions(ComponentIssue componentIssue)
    {
      return this.GetActions(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetActions(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.GetActions(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    public ResultStatus GetAllRequirements(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (GetAllRequirements), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).GetAllRequirements(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.GetAllRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAllRequirements), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAllRequirements()
    {
      return this.GetAllRequirements((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetAllRequirements(ComponentIssue componentIssue)
    {
      return this.GetAllRequirements(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetAllRequirements(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.GetAllRequirements(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).GetDataPoints(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetDataPoints(ComponentIssue componentIssue)
    {
      return this.GetDataPoints(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetDataPoints(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.GetDataPoints(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    public ResultStatus GetRequirements(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (GetRequirements), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).GetRequirements(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.GetRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetRequirements), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetRequirements()
    {
      return this.GetRequirements((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetRequirements(ComponentIssue componentIssue)
    {
      return this.GetRequirements(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetRequirements(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.GetRequirements(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).GetWIPMsgs(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetWIPMsgs(ComponentIssue componentIssue)
    {
      return this.GetWIPMsgs(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.GetWIPMsgs(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).Load(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus Load(ComponentIssue componentIssue)
    {
      return this.Load(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus Load(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.Load(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ComponentIssue componentIssue,
      ComponentIssue_LoadESigDetails_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).LoadESigDetails(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.LoadESigDetails, (ComponentIssue_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ComponentIssue) null, (ComponentIssue_LoadESigDetails_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus LoadESigDetails(ComponentIssue componentIssue)
    {
      return this.LoadESigDetails(componentIssue, (ComponentIssue_LoadESigDetails_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.LoadESigDetails(componentIssue, (ComponentIssue_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).ProcessComputation(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus ProcessComputation(ComponentIssue componentIssue)
    {
      return this.ProcessComputation(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus ProcessComputation(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.ProcessComputation(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ComponentIssue componentIssue,
      ComponentIssue_Parameters parameters,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) componentIssue, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).ResolveParametricData(this._UserProfile, componentIssue, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(componentIssue, ComponentIssueMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) componentIssue, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ComponentIssue) null, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus ResolveParametricData(ComponentIssue componentIssue)
    {
      return this.ResolveParametricData(componentIssue, (ComponentIssue_Parameters) null, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus ResolveParametricData(
      ComponentIssue componentIssue,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.ResolveParametricData(componentIssue, (ComponentIssue_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject componentIssue,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssue_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ComponentIssue) componentIssue, (ComponentIssue_Parameters) parameters, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject componentIssue,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssue_Result result1;
        ResultStatus actions = this.GetActions((ComponentIssue) componentIssue, (ComponentIssue_Parameters) parameters, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject componentIssue,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssue_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ComponentIssue) componentIssue, (ComponentIssue_Parameters) parameters, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject componentIssue,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssue_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ComponentIssue) componentIssue, (ComponentIssue_LoadESigDetails_Parameters) parameters, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject componentIssue,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssue_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ComponentIssue) componentIssue, (ComponentIssue_Parameters) parameters, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject componentIssue,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssue_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ComponentIssue) componentIssue, (ComponentIssue_Parameters) parameters, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject componentIssue,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssue_Result result1;
        ResultStatus resultStatus = this.Load((ComponentIssue) componentIssue, (ComponentIssue_Parameters) parameters, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentIssue,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssue_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentIssue) componentIssue, (ComponentIssue_Parameters) parameters, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      try
      {
        ComponentIssueMethod[] methods = new ComponentIssueMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentIssueService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentIssue_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentIssue cdo,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      try
      {
        return ((IComponentIssueService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentIssue_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentIssue) cdo, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.GetEnvironment((ComponentIssue) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentIssue cdo,
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      result = (ComponentIssue_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentIssueMethod(cdo, ComponentIssueMethods.ExecuteTransaction, (ComponentIssue_Parameters) null));
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
        ComponentIssue_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentIssue) cdo, (ComponentIssue_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentIssue cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentIssue_Request) null, out ComponentIssue_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentIssue_Request request,
      out ComponentIssue_Result result)
    {
      return this.ExecuteTransaction((ComponentIssue) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentIssue cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentIssueMethod(cdo, ComponentIssueMethods.AddDataTransaction, (ComponentIssue_Parameters) null));
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
        return this.AddDataTransaction((ComponentIssue) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

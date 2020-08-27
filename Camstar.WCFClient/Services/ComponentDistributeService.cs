// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentDistributeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentDistributeService : ContainerTxnBase
  {
    public ComponentDistributeService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentDistributeService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).CreateParametricData(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ComponentDistribute) null, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus CreateParametricData(ComponentDistribute componentDistribute)
    {
      return this.CreateParametricData(componentDistribute, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus CreateParametricData(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.CreateParametricData(componentDistribute, (ComponentDistribute_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).GetActions(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ComponentDistribute) null, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus GetActions(ComponentDistribute componentDistribute)
    {
      return this.GetActions(componentDistribute, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus GetActions(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.GetActions(componentDistribute, (ComponentDistribute_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).GetDataPoints(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ComponentDistribute) null, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus GetDataPoints(ComponentDistribute componentDistribute)
    {
      return this.GetDataPoints(componentDistribute, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus GetDataPoints(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.GetDataPoints(componentDistribute, (ComponentDistribute_Parameters) null, request, out result);
    }

    public ResultStatus GetRequirements(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (GetRequirements), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).GetRequirements(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.GetRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetRequirements), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetRequirements()
    {
      return this.GetRequirements((ComponentDistribute) null, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus GetRequirements(ComponentDistribute componentDistribute)
    {
      return this.GetRequirements(componentDistribute, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus GetRequirements(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.GetRequirements(componentDistribute, (ComponentDistribute_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).GetWIPMsgs(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentDistribute) null, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus GetWIPMsgs(ComponentDistribute componentDistribute)
    {
      return this.GetWIPMsgs(componentDistribute, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.GetWIPMsgs(componentDistribute, (ComponentDistribute_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).Load(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ComponentDistribute) null, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus Load(ComponentDistribute componentDistribute)
    {
      return this.Load(componentDistribute, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus Load(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.Load(componentDistribute, (ComponentDistribute_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ComponentDistribute componentDistribute,
      ComponentDistribute_LoadESigDetails_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).LoadESigDetails(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.LoadESigDetails, (ComponentDistribute_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ComponentDistribute) null, (ComponentDistribute_LoadESigDetails_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus LoadESigDetails(ComponentDistribute componentDistribute)
    {
      return this.LoadESigDetails(componentDistribute, (ComponentDistribute_LoadESigDetails_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.LoadESigDetails(componentDistribute, (ComponentDistribute_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).ProcessComputation(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ComponentDistribute) null, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus ProcessComputation(ComponentDistribute componentDistribute)
    {
      return this.ProcessComputation(componentDistribute, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus ProcessComputation(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.ProcessComputation(componentDistribute, (ComponentDistribute_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Parameters parameters,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) componentDistribute, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).ResolveParametricData(this._UserProfile, componentDistribute, parameters, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(componentDistribute, ComponentDistributeMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) componentDistribute, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ComponentDistribute) null, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus ResolveParametricData(ComponentDistribute componentDistribute)
    {
      return this.ResolveParametricData(componentDistribute, (ComponentDistribute_Parameters) null, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus ResolveParametricData(
      ComponentDistribute componentDistribute,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.ResolveParametricData(componentDistribute, (ComponentDistribute_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject componentDistribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDistribute_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ComponentDistribute) componentDistribute, (ComponentDistribute_Parameters) parameters, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject componentDistribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDistribute_Result result1;
        ResultStatus actions = this.GetActions((ComponentDistribute) componentDistribute, (ComponentDistribute_Parameters) parameters, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject componentDistribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDistribute_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ComponentDistribute) componentDistribute, (ComponentDistribute_Parameters) parameters, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject componentDistribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDistribute_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ComponentDistribute) componentDistribute, (ComponentDistribute_LoadESigDetails_Parameters) parameters, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject componentDistribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDistribute_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ComponentDistribute) componentDistribute, (ComponentDistribute_Parameters) parameters, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject componentDistribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDistribute_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ComponentDistribute) componentDistribute, (ComponentDistribute_Parameters) parameters, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject componentDistribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDistribute_Result result1;
        ResultStatus resultStatus = this.Load((ComponentDistribute) componentDistribute, (ComponentDistribute_Parameters) parameters, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentDistribute,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDistribute_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentDistribute) componentDistribute, (ComponentDistribute_Parameters) parameters, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      try
      {
        ComponentDistributeMethod[] methods = new ComponentDistributeMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentDistributeService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentDistribute_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentDistribute cdo,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      try
      {
        return ((IComponentDistributeService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentDistribute_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentDistribute) cdo, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.GetEnvironment((ComponentDistribute) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentDistribute cdo,
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      result = (ComponentDistribute_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDistributeService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentDistributeMethod(cdo, ComponentDistributeMethods.ExecuteTransaction, (ComponentDistribute_Parameters) null));
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
        ComponentDistribute_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentDistribute) cdo, (ComponentDistribute_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentDistribute cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentDistribute_Request) null, out ComponentDistribute_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentDistribute_Request request,
      out ComponentDistribute_Result result)
    {
      return this.ExecuteTransaction((ComponentDistribute) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentDistribute cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentDistributeMethod(cdo, ComponentDistributeMethods.AddDataTransaction, (ComponentDistribute_Parameters) null));
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
        return this.AddDataTransaction((ComponentDistribute) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

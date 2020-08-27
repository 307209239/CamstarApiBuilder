// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentDefectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentDefectService : DefectBase
  {
    public ComponentDefectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentDefectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).CreateParametricData(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ComponentDefect) null, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus CreateParametricData(ComponentDefect componentDefect)
    {
      return this.CreateParametricData(componentDefect, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus CreateParametricData(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.CreateParametricData(componentDefect, (ComponentDefect_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).GetActions(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ComponentDefect) null, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus GetActions(ComponentDefect componentDefect)
    {
      return this.GetActions(componentDefect, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus GetActions(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.GetActions(componentDefect, (ComponentDefect_Parameters) null, request, out result);
    }

    public ResultStatus GetActuals(
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (GetActuals), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).GetActuals(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.GetActuals, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActuals), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActuals()
    {
      return this.GetActuals((ComponentDefect) null, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus GetActuals(ComponentDefect componentDefect)
    {
      return this.GetActuals(componentDefect, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus GetActuals(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.GetActuals(componentDefect, (ComponentDefect_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).GetDataPoints(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ComponentDefect) null, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus GetDataPoints(ComponentDefect componentDefect)
    {
      return this.GetDataPoints(componentDefect, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus GetDataPoints(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.GetDataPoints(componentDefect, (ComponentDefect_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).GetWIPMsgs(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentDefect) null, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus GetWIPMsgs(ComponentDefect componentDefect)
    {
      return this.GetWIPMsgs(componentDefect, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.GetWIPMsgs(componentDefect, (ComponentDefect_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).Load(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ComponentDefect) null, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus Load(ComponentDefect componentDefect)
    {
      return this.Load(componentDefect, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus Load(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.Load(componentDefect, (ComponentDefect_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ComponentDefect componentDefect,
      ComponentDefect_LoadESigDetails_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).LoadESigDetails(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.LoadESigDetails, (ComponentDefect_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ComponentDefect) null, (ComponentDefect_LoadESigDetails_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus LoadESigDetails(ComponentDefect componentDefect)
    {
      return this.LoadESigDetails(componentDefect, (ComponentDefect_LoadESigDetails_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.LoadESigDetails(componentDefect, (ComponentDefect_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).ProcessComputation(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ComponentDefect) null, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus ProcessComputation(ComponentDefect componentDefect)
    {
      return this.ProcessComputation(componentDefect, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus ProcessComputation(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.ProcessComputation(componentDefect, (ComponentDefect_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ComponentDefect componentDefect,
      ComponentDefect_Parameters parameters,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) componentDefect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).ResolveParametricData(this._UserProfile, componentDefect, parameters, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(componentDefect, ComponentDefectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) componentDefect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ComponentDefect) null, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus ResolveParametricData(ComponentDefect componentDefect)
    {
      return this.ResolveParametricData(componentDefect, (ComponentDefect_Parameters) null, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus ResolveParametricData(
      ComponentDefect componentDefect,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.ResolveParametricData(componentDefect, (ComponentDefect_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetActuals(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus actuals = this.GetActuals((ComponentDefect) componentDefect, (ComponentDefect_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return actuals;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ComponentDefect) componentDefect, (ComponentDefect_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus actions = this.GetActions((ComponentDefect) componentDefect, (ComponentDefect_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ComponentDefect) componentDefect, (ComponentDefect_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ComponentDefect) componentDefect, (ComponentDefect_LoadESigDetails_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ComponentDefect) componentDefect, (ComponentDefect_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ComponentDefect) componentDefect, (ComponentDefect_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus resultStatus = this.Load((ComponentDefect) componentDefect, (ComponentDefect_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentDefect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentDefect_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentDefect) componentDefect, (ComponentDefect_Parameters) parameters, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      try
      {
        ComponentDefectMethod[] methods = new ComponentDefectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentDefectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentDefect_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentDefect cdo,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      try
      {
        return ((IComponentDefectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentDefect_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentDefect) cdo, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.GetEnvironment((ComponentDefect) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentDefect cdo,
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      result = (ComponentDefect_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentDefectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentDefectMethod(cdo, ComponentDefectMethods.ExecuteTransaction, (ComponentDefect_Parameters) null));
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
        ComponentDefect_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentDefect) cdo, (ComponentDefect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentDefect cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentDefect_Request) null, out ComponentDefect_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentDefect_Request request,
      out ComponentDefect_Result result)
    {
      return this.ExecuteTransaction((ComponentDefect) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentDefect cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentDefectMethod(cdo, ComponentDefectMethods.AddDataTransaction, (ComponentDefect_Parameters) null));
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
        return this.AddDataTransaction((ComponentDefect) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

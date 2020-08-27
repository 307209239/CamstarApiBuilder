// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentReplaceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentReplaceService : ContainerTxnBase
  {
    public ComponentReplaceService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentReplaceService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).CreateParametricData(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ComponentReplace) null, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus CreateParametricData(ComponentReplace componentReplace)
    {
      return this.CreateParametricData(componentReplace, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus CreateParametricData(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.CreateParametricData(componentReplace, (ComponentReplace_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).GetActions(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ComponentReplace) null, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus GetActions(ComponentReplace componentReplace)
    {
      return this.GetActions(componentReplace, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus GetActions(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.GetActions(componentReplace, (ComponentReplace_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).GetDataPoints(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ComponentReplace) null, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus GetDataPoints(ComponentReplace componentReplace)
    {
      return this.GetDataPoints(componentReplace, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus GetDataPoints(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.GetDataPoints(componentReplace, (ComponentReplace_Parameters) null, request, out result);
    }

    public ResultStatus GetRemovalDetails(
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (GetRemovalDetails), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).GetRemovalDetails(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.GetRemovalDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetRemovalDetails), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetRemovalDetails()
    {
      return this.GetRemovalDetails((ComponentReplace) null, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus GetRemovalDetails(ComponentReplace componentReplace)
    {
      return this.GetRemovalDetails(componentReplace, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus GetRemovalDetails(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.GetRemovalDetails(componentReplace, (ComponentReplace_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).GetWIPMsgs(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentReplace) null, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus GetWIPMsgs(ComponentReplace componentReplace)
    {
      return this.GetWIPMsgs(componentReplace, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.GetWIPMsgs(componentReplace, (ComponentReplace_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).Load(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ComponentReplace) null, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus Load(ComponentReplace componentReplace)
    {
      return this.Load(componentReplace, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus Load(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.Load(componentReplace, (ComponentReplace_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ComponentReplace componentReplace,
      ComponentReplace_LoadESigDetails_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).LoadESigDetails(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.LoadESigDetails, (ComponentReplace_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ComponentReplace) null, (ComponentReplace_LoadESigDetails_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus LoadESigDetails(ComponentReplace componentReplace)
    {
      return this.LoadESigDetails(componentReplace, (ComponentReplace_LoadESigDetails_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus LoadESigDetails(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.LoadESigDetails(componentReplace, (ComponentReplace_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).ProcessComputation(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ComponentReplace) null, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus ProcessComputation(ComponentReplace componentReplace)
    {
      return this.ProcessComputation(componentReplace, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus ProcessComputation(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.ProcessComputation(componentReplace, (ComponentReplace_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ComponentReplace componentReplace,
      ComponentReplace_Parameters parameters,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) componentReplace, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).ResolveParametricData(this._UserProfile, componentReplace, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(componentReplace, ComponentReplaceMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) componentReplace, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ComponentReplace) null, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus ResolveParametricData(ComponentReplace componentReplace)
    {
      return this.ResolveParametricData(componentReplace, (ComponentReplace_Parameters) null, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus ResolveParametricData(
      ComponentReplace componentReplace,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.ResolveParametricData(componentReplace, (ComponentReplace_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject componentReplace,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplace_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ComponentReplace) componentReplace, (ComponentReplace_Parameters) parameters, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject componentReplace,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplace_Result result1;
        ResultStatus actions = this.GetActions((ComponentReplace) componentReplace, (ComponentReplace_Parameters) parameters, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject componentReplace,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplace_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ComponentReplace) componentReplace, (ComponentReplace_Parameters) parameters, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject componentReplace,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplace_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ComponentReplace) componentReplace, (ComponentReplace_LoadESigDetails_Parameters) parameters, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject componentReplace,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplace_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ComponentReplace) componentReplace, (ComponentReplace_Parameters) parameters, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject componentReplace,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplace_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ComponentReplace) componentReplace, (ComponentReplace_Parameters) parameters, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject componentReplace,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplace_Result result1;
        ResultStatus resultStatus = this.Load((ComponentReplace) componentReplace, (ComponentReplace_Parameters) parameters, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentReplace,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplace_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentReplace) componentReplace, (ComponentReplace_Parameters) parameters, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      try
      {
        ComponentReplaceMethod[] methods = new ComponentReplaceMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentReplaceService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentReplace_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentReplace cdo,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      try
      {
        return ((IComponentReplaceService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentReplace_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentReplace) cdo, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.GetEnvironment((ComponentReplace) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentReplace cdo,
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      result = (ComponentReplace_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentReplaceMethod(cdo, ComponentReplaceMethods.ExecuteTransaction, (ComponentReplace_Parameters) null));
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
        ComponentReplace_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentReplace) cdo, (ComponentReplace_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentReplace cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentReplace_Request) null, out ComponentReplace_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentReplace_Request request,
      out ComponentReplace_Result result)
    {
      return this.ExecuteTransaction((ComponentReplace) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentReplace cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentReplaceMethod(cdo, ComponentReplaceMethods.AddDataTransaction, (ComponentReplace_Parameters) null));
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
        return this.AddDataTransaction((ComponentReplace) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

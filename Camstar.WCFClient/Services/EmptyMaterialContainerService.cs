// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EmptyMaterialContainerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EmptyMaterialContainerService : EmptyCarrierBase
  {
    public EmptyMaterialContainerService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEmptyMaterialContainerService), userProfile);
    }

    public ResultStatus CreateParametricData(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).CreateParametricData(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((EmptyMaterialContainer) null, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus CreateParametricData(
      EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.CreateParametricData(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus CreateParametricData(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.CreateParametricData(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).GetActions(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((EmptyMaterialContainer) null, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus GetActions(EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.GetActions(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus GetActions(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.GetActions(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).GetDataPoints(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((EmptyMaterialContainer) null, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus GetDataPoints(EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.GetDataPoints(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus GetDataPoints(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.GetDataPoints(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, request, out result);
    }

    public ResultStatus GetMaterialSelectionValues(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_GetMaterialSelectionValues_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (GetMaterialSelectionValues), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).GetMaterialSelectionValues(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.GetMaterialSelectionValues, (EmptyMaterialContainer_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetMaterialSelectionValues), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetMaterialSelectionValues()
    {
      return this.GetMaterialSelectionValues((EmptyMaterialContainer) null, (EmptyMaterialContainer_GetMaterialSelectionValues_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus GetMaterialSelectionValues(
      EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.GetMaterialSelectionValues(emptyMaterialContainer, (EmptyMaterialContainer_GetMaterialSelectionValues_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus GetMaterialSelectionValues(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.GetMaterialSelectionValues(emptyMaterialContainer, (EmptyMaterialContainer_GetMaterialSelectionValues_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).GetWIPMsgs(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EmptyMaterialContainer) null, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus GetWIPMsgs(EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.GetWIPMsgs(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.GetWIPMsgs(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).Load(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EmptyMaterialContainer) null, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus Load(EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.Load(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus Load(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.Load(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_LoadESigDetails_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).LoadESigDetails(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.LoadESigDetails, (EmptyMaterialContainer_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EmptyMaterialContainer) null, (EmptyMaterialContainer_LoadESigDetails_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus LoadESigDetails(EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.LoadESigDetails(emptyMaterialContainer, (EmptyMaterialContainer_LoadESigDetails_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus LoadESigDetails(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.LoadESigDetails(emptyMaterialContainer, (EmptyMaterialContainer_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).ProcessComputation(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((EmptyMaterialContainer) null, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus ProcessComputation(EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.ProcessComputation(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus ProcessComputation(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.ProcessComputation(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Parameters parameters,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).ResolveParametricData(this._UserProfile, emptyMaterialContainer, parameters, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(emptyMaterialContainer, EmptyMaterialContainerMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) emptyMaterialContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((EmptyMaterialContainer) null, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus ResolveParametricData(
      EmptyMaterialContainer emptyMaterialContainer)
    {
      return this.ResolveParametricData(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus ResolveParametricData(
      EmptyMaterialContainer emptyMaterialContainer,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.ResolveParametricData(emptyMaterialContainer, (EmptyMaterialContainer_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject emptyMaterialContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyMaterialContainer_Result result1;
        ResultStatus parametricData = this.CreateParametricData((EmptyMaterialContainer) emptyMaterialContainer, (EmptyMaterialContainer_Parameters) parameters, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject emptyMaterialContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyMaterialContainer_Result result1;
        ResultStatus actions = this.GetActions((EmptyMaterialContainer) emptyMaterialContainer, (EmptyMaterialContainer_Parameters) parameters, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject emptyMaterialContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyMaterialContainer_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((EmptyMaterialContainer) emptyMaterialContainer, (EmptyMaterialContainer_Parameters) parameters, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject emptyMaterialContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyMaterialContainer_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EmptyMaterialContainer) emptyMaterialContainer, (EmptyMaterialContainer_LoadESigDetails_Parameters) parameters, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject emptyMaterialContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyMaterialContainer_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((EmptyMaterialContainer) emptyMaterialContainer, (EmptyMaterialContainer_Parameters) parameters, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject emptyMaterialContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyMaterialContainer_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((EmptyMaterialContainer) emptyMaterialContainer, (EmptyMaterialContainer_Parameters) parameters, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject emptyMaterialContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyMaterialContainer_Result result1;
        ResultStatus resultStatus = this.Load((EmptyMaterialContainer) emptyMaterialContainer, (EmptyMaterialContainer_Parameters) parameters, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject emptyMaterialContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyMaterialContainer_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EmptyMaterialContainer) emptyMaterialContainer, (EmptyMaterialContainer_Parameters) parameters, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      try
      {
        EmptyMaterialContainerMethod[] methods = new EmptyMaterialContainerMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEmptyMaterialContainerService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EmptyMaterialContainer_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmptyMaterialContainer cdo,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      try
      {
        return ((IEmptyMaterialContainerService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EmptyMaterialContainer_Result result1;
        ResultStatus environment = this.GetEnvironment((EmptyMaterialContainer) cdo, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.GetEnvironment((EmptyMaterialContainer) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EmptyMaterialContainer cdo,
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      result = (EmptyMaterialContainer_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyMaterialContainerService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EmptyMaterialContainerMethod(cdo, EmptyMaterialContainerMethods.ExecuteTransaction, (EmptyMaterialContainer_Parameters) null));
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
        EmptyMaterialContainer_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EmptyMaterialContainer) cdo, (EmptyMaterialContainer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EmptyMaterialContainer cdo)
    {
      return this.ExecuteTransaction(cdo, (EmptyMaterialContainer_Request) null, out EmptyMaterialContainer_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EmptyMaterialContainer_Request request,
      out EmptyMaterialContainer_Result result)
    {
      return this.ExecuteTransaction((EmptyMaterialContainer) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EmptyMaterialContainer cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EmptyMaterialContainerMethod(cdo, EmptyMaterialContainerMethods.AddDataTransaction, (EmptyMaterialContainer_Parameters) null));
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
        return this.AddDataTransaction((EmptyMaterialContainer) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

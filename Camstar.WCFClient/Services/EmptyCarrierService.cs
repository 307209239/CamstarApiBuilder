// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EmptyCarrierService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EmptyCarrierService : ChangeQtyBase
  {
    public EmptyCarrierService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEmptyCarrierService), userProfile);
    }

    public ResultStatus CreateParametricData(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) emptyCarrier, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).CreateParametricData(this._UserProfile, emptyCarrier, parameters, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(emptyCarrier, EmptyCarrierMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) emptyCarrier, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((EmptyCarrier) null, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus CreateParametricData(EmptyCarrier emptyCarrier)
    {
      return this.CreateParametricData(emptyCarrier, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus CreateParametricData(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.CreateParametricData(emptyCarrier, (EmptyCarrier_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) emptyCarrier, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).GetActions(this._UserProfile, emptyCarrier, parameters, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(emptyCarrier, EmptyCarrierMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) emptyCarrier, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((EmptyCarrier) null, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus GetActions(EmptyCarrier emptyCarrier)
    {
      return this.GetActions(emptyCarrier, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus GetActions(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.GetActions(emptyCarrier, (EmptyCarrier_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) emptyCarrier, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).GetDataPoints(this._UserProfile, emptyCarrier, parameters, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(emptyCarrier, EmptyCarrierMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) emptyCarrier, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((EmptyCarrier) null, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus GetDataPoints(EmptyCarrier emptyCarrier)
    {
      return this.GetDataPoints(emptyCarrier, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus GetDataPoints(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.GetDataPoints(emptyCarrier, (EmptyCarrier_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) emptyCarrier, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).GetWIPMsgs(this._UserProfile, emptyCarrier, parameters, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(emptyCarrier, EmptyCarrierMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) emptyCarrier, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EmptyCarrier) null, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus GetWIPMsgs(EmptyCarrier emptyCarrier)
    {
      return this.GetWIPMsgs(emptyCarrier, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.GetWIPMsgs(emptyCarrier, (EmptyCarrier_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) emptyCarrier, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).Load(this._UserProfile, emptyCarrier, parameters, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(emptyCarrier, EmptyCarrierMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) emptyCarrier, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EmptyCarrier) null, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus Load(EmptyCarrier emptyCarrier)
    {
      return this.Load(emptyCarrier, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus Load(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.Load(emptyCarrier, (EmptyCarrier_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_LoadESigDetails_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) emptyCarrier, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).LoadESigDetails(this._UserProfile, emptyCarrier, parameters, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(emptyCarrier, EmptyCarrierMethods.LoadESigDetails, (EmptyCarrier_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) emptyCarrier, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EmptyCarrier) null, (EmptyCarrier_LoadESigDetails_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus LoadESigDetails(EmptyCarrier emptyCarrier)
    {
      return this.LoadESigDetails(emptyCarrier, (EmptyCarrier_LoadESigDetails_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus LoadESigDetails(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.LoadESigDetails(emptyCarrier, (EmptyCarrier_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) emptyCarrier, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).ProcessComputation(this._UserProfile, emptyCarrier, parameters, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(emptyCarrier, EmptyCarrierMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) emptyCarrier, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((EmptyCarrier) null, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus ProcessComputation(EmptyCarrier emptyCarrier)
    {
      return this.ProcessComputation(emptyCarrier, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus ProcessComputation(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.ProcessComputation(emptyCarrier, (EmptyCarrier_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Parameters parameters,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) emptyCarrier, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).ResolveParametricData(this._UserProfile, emptyCarrier, parameters, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(emptyCarrier, EmptyCarrierMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) emptyCarrier, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((EmptyCarrier) null, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus ResolveParametricData(EmptyCarrier emptyCarrier)
    {
      return this.ResolveParametricData(emptyCarrier, (EmptyCarrier_Parameters) null, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus ResolveParametricData(
      EmptyCarrier emptyCarrier,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.ResolveParametricData(emptyCarrier, (EmptyCarrier_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject emptyCarrier,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyCarrier_Result result1;
        ResultStatus parametricData = this.CreateParametricData((EmptyCarrier) emptyCarrier, (EmptyCarrier_Parameters) parameters, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject emptyCarrier,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyCarrier_Result result1;
        ResultStatus actions = this.GetActions((EmptyCarrier) emptyCarrier, (EmptyCarrier_Parameters) parameters, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject emptyCarrier,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyCarrier_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((EmptyCarrier) emptyCarrier, (EmptyCarrier_Parameters) parameters, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject emptyCarrier,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyCarrier_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EmptyCarrier) emptyCarrier, (EmptyCarrier_LoadESigDetails_Parameters) parameters, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject emptyCarrier,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyCarrier_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((EmptyCarrier) emptyCarrier, (EmptyCarrier_Parameters) parameters, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject emptyCarrier,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyCarrier_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((EmptyCarrier) emptyCarrier, (EmptyCarrier_Parameters) parameters, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject emptyCarrier,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyCarrier_Result result1;
        ResultStatus resultStatus = this.Load((EmptyCarrier) emptyCarrier, (EmptyCarrier_Parameters) parameters, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject emptyCarrier,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EmptyCarrier_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EmptyCarrier) emptyCarrier, (EmptyCarrier_Parameters) parameters, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      try
      {
        EmptyCarrierMethod[] methods = new EmptyCarrierMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEmptyCarrierService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EmptyCarrier_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmptyCarrier cdo,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      try
      {
        return ((IEmptyCarrierService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EmptyCarrier_Result result1;
        ResultStatus environment = this.GetEnvironment((EmptyCarrier) cdo, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.GetEnvironment((EmptyCarrier) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EmptyCarrier cdo,
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      result = (EmptyCarrier_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEmptyCarrierService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EmptyCarrierMethod(cdo, EmptyCarrierMethods.ExecuteTransaction, (EmptyCarrier_Parameters) null));
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
        EmptyCarrier_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EmptyCarrier) cdo, (EmptyCarrier_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EmptyCarrier cdo)
    {
      return this.ExecuteTransaction(cdo, (EmptyCarrier_Request) null, out EmptyCarrier_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EmptyCarrier_Request request,
      out EmptyCarrier_Result result)
    {
      return this.ExecuteTransaction((EmptyCarrier) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EmptyCarrier cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EmptyCarrierMethod(cdo, EmptyCarrierMethods.AddDataTransaction, (EmptyCarrier_Parameters) null));
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
        return this.AddDataTransaction((EmptyCarrier) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

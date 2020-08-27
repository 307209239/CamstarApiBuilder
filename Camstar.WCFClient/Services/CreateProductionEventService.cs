// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CreateProductionEventService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CreateProductionEventService : CreateEventBase
  {
    public CreateProductionEventService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICreateProductionEventService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).CreateParametricData(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus CreateParametricData(CreateProductionEvent createProductionEvent)
    {
      return this.CreateParametricData(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus CreateParametricData(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.CreateParametricData(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).GetActions(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus GetActions(CreateProductionEvent createProductionEvent)
    {
      return this.GetActions(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus GetActions(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.GetActions(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).GetDataPoints(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus GetDataPoints(CreateProductionEvent createProductionEvent)
    {
      return this.GetDataPoints(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus GetDataPoints(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.GetDataPoints(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).GetWIPMsgs(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus GetWIPMsgs(CreateProductionEvent createProductionEvent)
    {
      return this.GetWIPMsgs(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.GetWIPMsgs(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus Hold(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (Hold), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).Hold(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.Hold, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Hold), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Hold()
    {
      return this.Hold((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus Hold(CreateProductionEvent createProductionEvent)
    {
      return this.Hold(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus Hold(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.Hold(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).Load(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus Load(CreateProductionEvent createProductionEvent)
    {
      return this.Load(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus Load(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.Load(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).LoadESigDetails(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus LoadESigDetails(CreateProductionEvent createProductionEvent)
    {
      return this.LoadESigDetails(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus LoadESigDetails(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.LoadESigDetails(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus PrintLabels(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (PrintLabels), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).PrintLabels(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.PrintLabels, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PrintLabels), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PrintLabels()
    {
      return this.PrintLabels((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus PrintLabels(CreateProductionEvent createProductionEvent)
    {
      return this.PrintLabels(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus PrintLabels(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.PrintLabels(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).ProcessComputation(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus ProcessComputation(CreateProductionEvent createProductionEvent)
    {
      return this.ProcessComputation(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus ProcessComputation(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.ProcessComputation(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Parameters parameters,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) createProductionEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).ResolveParametricData(this._UserProfile, createProductionEvent, parameters, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(createProductionEvent, CreateProductionEventMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) createProductionEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CreateProductionEvent) null, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus ResolveParametricData(
      CreateProductionEvent createProductionEvent)
    {
      return this.ResolveParametricData(createProductionEvent, (CreateProductionEvent_Parameters) null, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus ResolveParametricData(
      CreateProductionEvent createProductionEvent,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.ResolveParametricData(createProductionEvent, (CreateProductionEvent_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject createProductionEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateProductionEvent_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CreateProductionEvent) createProductionEvent, (CreateProductionEvent_Parameters) parameters, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject createProductionEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateProductionEvent_Result result1;
        ResultStatus actions = this.GetActions((CreateProductionEvent) createProductionEvent, (CreateProductionEvent_Parameters) parameters, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject createProductionEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateProductionEvent_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CreateProductionEvent) createProductionEvent, (CreateProductionEvent_Parameters) parameters, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject createProductionEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateProductionEvent_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CreateProductionEvent) createProductionEvent, (CreateProductionEvent_Parameters) parameters, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject createProductionEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateProductionEvent_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CreateProductionEvent) createProductionEvent, (CreateProductionEvent_Parameters) parameters, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject createProductionEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateProductionEvent_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CreateProductionEvent) createProductionEvent, (CreateProductionEvent_Parameters) parameters, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject createProductionEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateProductionEvent_Result result1;
        ResultStatus resultStatus = this.Load((CreateProductionEvent) createProductionEvent, (CreateProductionEvent_Parameters) parameters, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject createProductionEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateProductionEvent_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CreateProductionEvent) createProductionEvent, (CreateProductionEvent_Parameters) parameters, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      try
      {
        CreateProductionEventMethod[] methods = new CreateProductionEventMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICreateProductionEventService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CreateProductionEvent_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateProductionEvent cdo,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      try
      {
        return ((ICreateProductionEventService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CreateProductionEvent_Result result1;
        ResultStatus environment = this.GetEnvironment((CreateProductionEvent) cdo, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.GetEnvironment((CreateProductionEvent) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CreateProductionEvent cdo,
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      result = (CreateProductionEvent_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateProductionEventService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CreateProductionEventMethod(cdo, CreateProductionEventMethods.ExecuteTransaction, (CreateProductionEvent_Parameters) null));
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
        CreateProductionEvent_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CreateProductionEvent) cdo, (CreateProductionEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CreateProductionEvent cdo)
    {
      return this.ExecuteTransaction(cdo, (CreateProductionEvent_Request) null, out CreateProductionEvent_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CreateProductionEvent_Request request,
      out CreateProductionEvent_Result result)
    {
      return this.ExecuteTransaction((CreateProductionEvent) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CreateProductionEvent cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CreateProductionEventMethod(cdo, CreateProductionEventMethods.AddDataTransaction, (CreateProductionEvent_Parameters) null));
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
        return this.AddDataTransaction((CreateProductionEvent) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

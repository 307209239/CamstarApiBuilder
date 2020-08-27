// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CreateEventService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CreateEventService : QualityTxnBase
  {
    public CreateEventService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICreateEventService), userProfile);
    }

    public ResultStatus AddHistoryCrossRefs(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (AddHistoryCrossRefs), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).AddHistoryCrossRefs(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.AddHistoryCrossRefs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddHistoryCrossRefs), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddHistoryCrossRefs()
    {
      return this.AddHistoryCrossRefs((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus AddHistoryCrossRefs(CreateEvent createEvent)
    {
      return this.AddHistoryCrossRefs(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus AddHistoryCrossRefs(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.AddHistoryCrossRefs(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).CreateParametricData(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus CreateParametricData(CreateEvent createEvent)
    {
      return this.CreateParametricData(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus CreateParametricData(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.CreateParametricData(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).GetActions(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus GetActions(CreateEvent createEvent)
    {
      return this.GetActions(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus GetActions(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.GetActions(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).GetDataPoints(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus GetDataPoints(CreateEvent createEvent)
    {
      return this.GetDataPoints(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus GetDataPoints(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.GetDataPoints(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetEventName(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (GetEventName), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).GetEventName(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.GetEventName, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetEventName), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetEventName()
    {
      return this.GetEventName((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus GetEventName(CreateEvent createEvent)
    {
      return this.GetEventName(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus GetEventName(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.GetEventName(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).GetWIPMsgs(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus GetWIPMsgs(CreateEvent createEvent)
    {
      return this.GetWIPMsgs(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.GetWIPMsgs(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).Load(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus Load(CreateEvent createEvent)
    {
      return this.Load(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus Load(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.Load(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).LoadESigDetails(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus LoadESigDetails(CreateEvent createEvent)
    {
      return this.LoadESigDetails(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus LoadESigDetails(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.LoadESigDetails(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).ProcessComputation(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus ProcessComputation(CreateEvent createEvent)
    {
      return this.ProcessComputation(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus ProcessComputation(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.ProcessComputation(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).ResolveParametricData(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus ResolveParametricData(CreateEvent createEvent)
    {
      return this.ResolveParametricData(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus ResolveParametricData(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.ResolveParametricData(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus SubmitEvent(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (SubmitEvent), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).SubmitEvent(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.SubmitEvent, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SubmitEvent), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SubmitEvent()
    {
      return this.SubmitEvent((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus SubmitEvent(CreateEvent createEvent)
    {
      return this.SubmitEvent(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus SubmitEvent(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.SubmitEvent(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    public ResultStatus ValidateEvent(
      CreateEvent createEvent,
      CreateEvent_Parameters parameters,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (ValidateEvent), (DCObject) createEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).ValidateEvent(this._UserProfile, createEvent, parameters, request, out result) : this.AddMethod((Method) new CreateEventMethod(createEvent, CreateEventMethods.ValidateEvent, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateEvent), res, (DCObject) createEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateEvent()
    {
      return this.ValidateEvent((CreateEvent) null, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus ValidateEvent(CreateEvent createEvent)
    {
      return this.ValidateEvent(createEvent, (CreateEvent_Parameters) null, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus ValidateEvent(
      CreateEvent createEvent,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.ValidateEvent(createEvent, (CreateEvent_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject createEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateEvent_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CreateEvent) createEvent, (CreateEvent_Parameters) parameters, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject createEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateEvent_Result result1;
        ResultStatus actions = this.GetActions((CreateEvent) createEvent, (CreateEvent_Parameters) parameters, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject createEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateEvent_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CreateEvent) createEvent, (CreateEvent_Parameters) parameters, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject createEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateEvent_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CreateEvent) createEvent, (CreateEvent_Parameters) parameters, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject createEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateEvent_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CreateEvent) createEvent, (CreateEvent_Parameters) parameters, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject createEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateEvent_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CreateEvent) createEvent, (CreateEvent_Parameters) parameters, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject createEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateEvent_Result result1;
        ResultStatus resultStatus = this.Load((CreateEvent) createEvent, (CreateEvent_Parameters) parameters, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject createEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateEvent_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CreateEvent) createEvent, (CreateEvent_Parameters) parameters, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      try
      {
        CreateEventMethod[] methods = new CreateEventMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICreateEventService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CreateEvent_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateEvent cdo,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      try
      {
        return ((ICreateEventService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CreateEvent_Result result1;
        ResultStatus environment = this.GetEnvironment((CreateEvent) cdo, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.GetEnvironment((CreateEvent) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CreateEvent cdo,
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      result = (CreateEvent_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateEventService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CreateEventMethod(cdo, CreateEventMethods.ExecuteTransaction, (CreateEvent_Parameters) null));
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
        CreateEvent_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CreateEvent) cdo, (CreateEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CreateEvent cdo)
    {
      return this.ExecuteTransaction(cdo, (CreateEvent_Request) null, out CreateEvent_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CreateEvent_Request request,
      out CreateEvent_Result result)
    {
      return this.ExecuteTransaction((CreateEvent) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CreateEvent cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CreateEventMethod(cdo, CreateEventMethods.AddDataTransaction, (CreateEvent_Parameters) null));
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
        return this.AddDataTransaction((CreateEvent) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

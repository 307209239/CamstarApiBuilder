// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignChecklistToEventService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssignChecklistToEventService : QualityTxnBase
  {
    public AssignChecklistToEventService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssignChecklistToEventService), userProfile);
    }

    public ResultStatus CreateParametricData(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).CreateParametricData(this._UserProfile, assignChecklistToEvent, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(assignChecklistToEvent, AssignChecklistToEventMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AssignChecklistToEvent) null, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus CreateParametricData(
      AssignChecklistToEvent assignChecklistToEvent)
    {
      return this.CreateParametricData(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus CreateParametricData(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.CreateParametricData(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).GetActions(this._UserProfile, assignChecklistToEvent, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(assignChecklistToEvent, AssignChecklistToEventMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AssignChecklistToEvent) null, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus GetActions(AssignChecklistToEvent assignChecklistToEvent)
    {
      return this.GetActions(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus GetActions(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.GetActions(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).GetDataPoints(this._UserProfile, assignChecklistToEvent, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(assignChecklistToEvent, AssignChecklistToEventMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AssignChecklistToEvent) null, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus GetDataPoints(AssignChecklistToEvent assignChecklistToEvent)
    {
      return this.GetDataPoints(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus GetDataPoints(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.GetDataPoints(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).GetWIPMsgs(this._UserProfile, assignChecklistToEvent, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(assignChecklistToEvent, AssignChecklistToEventMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AssignChecklistToEvent) null, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus GetWIPMsgs(AssignChecklistToEvent assignChecklistToEvent)
    {
      return this.GetWIPMsgs(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.GetWIPMsgs(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).Load(this._UserProfile, assignChecklistToEvent, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(assignChecklistToEvent, AssignChecklistToEventMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AssignChecklistToEvent) null, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus Load(AssignChecklistToEvent assignChecklistToEvent)
    {
      return this.Load(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus Load(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.Load(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).LoadESigDetails(this._UserProfile, assignChecklistToEvent, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(assignChecklistToEvent, AssignChecklistToEventMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AssignChecklistToEvent) null, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus LoadESigDetails(AssignChecklistToEvent assignChecklistToEvent)
    {
      return this.LoadESigDetails(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus LoadESigDetails(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.LoadESigDetails(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).ProcessComputation(this._UserProfile, assignChecklistToEvent, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(assignChecklistToEvent, AssignChecklistToEventMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AssignChecklistToEvent) null, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus ProcessComputation(AssignChecklistToEvent assignChecklistToEvent)
    {
      return this.ProcessComputation(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus ProcessComputation(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.ProcessComputation(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Parameters parameters,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).ResolveParametricData(this._UserProfile, assignChecklistToEvent, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(assignChecklistToEvent, AssignChecklistToEventMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) assignChecklistToEvent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AssignChecklistToEvent) null, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignChecklistToEvent assignChecklistToEvent)
    {
      return this.ResolveParametricData(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignChecklistToEvent assignChecklistToEvent,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.ResolveParametricData(assignChecklistToEvent, (AssignChecklistToEvent_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject assignChecklistToEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklistToEvent_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AssignChecklistToEvent) assignChecklistToEvent, (AssignChecklistToEvent_Parameters) parameters, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject assignChecklistToEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklistToEvent_Result result1;
        ResultStatus actions = this.GetActions((AssignChecklistToEvent) assignChecklistToEvent, (AssignChecklistToEvent_Parameters) parameters, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject assignChecklistToEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklistToEvent_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AssignChecklistToEvent) assignChecklistToEvent, (AssignChecklistToEvent_Parameters) parameters, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject assignChecklistToEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklistToEvent_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AssignChecklistToEvent) assignChecklistToEvent, (AssignChecklistToEvent_Parameters) parameters, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject assignChecklistToEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklistToEvent_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AssignChecklistToEvent) assignChecklistToEvent, (AssignChecklistToEvent_Parameters) parameters, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject assignChecklistToEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklistToEvent_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AssignChecklistToEvent) assignChecklistToEvent, (AssignChecklistToEvent_Parameters) parameters, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject assignChecklistToEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklistToEvent_Result result1;
        ResultStatus resultStatus = this.Load((AssignChecklistToEvent) assignChecklistToEvent, (AssignChecklistToEvent_Parameters) parameters, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject assignChecklistToEvent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklistToEvent_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AssignChecklistToEvent) assignChecklistToEvent, (AssignChecklistToEvent_Parameters) parameters, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      try
      {
        AssignChecklistToEventMethod[] methods = new AssignChecklistToEventMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssignChecklistToEventService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AssignChecklistToEvent_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignChecklistToEvent cdo,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      try
      {
        return ((IAssignChecklistToEventService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AssignChecklistToEvent_Result result1;
        ResultStatus environment = this.GetEnvironment((AssignChecklistToEvent) cdo, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.GetEnvironment((AssignChecklistToEvent) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AssignChecklistToEvent cdo,
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      result = (AssignChecklistToEvent_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistToEventService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssignChecklistToEventMethod(cdo, AssignChecklistToEventMethods.ExecuteTransaction, (AssignChecklistToEvent_Parameters) null));
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
        AssignChecklistToEvent_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AssignChecklistToEvent) cdo, (AssignChecklistToEvent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AssignChecklistToEvent cdo)
    {
      return this.ExecuteTransaction(cdo, (AssignChecklistToEvent_Request) null, out AssignChecklistToEvent_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AssignChecklistToEvent_Request request,
      out AssignChecklistToEvent_Result result)
    {
      return this.ExecuteTransaction((AssignChecklistToEvent) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AssignChecklistToEvent cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssignChecklistToEventMethod(cdo, AssignChecklistToEventMethods.AddDataTransaction, (AssignChecklistToEvent_Parameters) null));
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
        return this.AddDataTransaction((AssignChecklistToEvent) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

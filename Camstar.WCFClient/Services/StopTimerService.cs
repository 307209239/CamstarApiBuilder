// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.StopTimerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class StopTimerService : ContainerTxnBase
  {
    public StopTimerService(UserProfile userProfile)
    {
      this.Initialize(typeof (IStopTimerService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).CreateParametricData(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus CreateParametricData(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.CreateParametricData(stopTimer, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus CreateParametricData(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.CreateParametricData(stopTimer, (StopTimer_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).GetActions(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus GetActions(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.GetActions(stopTimer, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus GetActions(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.GetActions(stopTimer, (StopTimer_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).GetDataPoints(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus GetDataPoints(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.GetDataPoints(stopTimer, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus GetDataPoints(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.GetDataPoints(stopTimer, (StopTimer_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).GetWIPMsgs(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus GetWIPMsgs(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.GetWIPMsgs(stopTimer, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.GetWIPMsgs(stopTimer, (StopTimer_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).Load(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus Load(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.Load(stopTimer, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus Load(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.Load(stopTimer, (StopTimer_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_LoadESigDetails_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).LoadESigDetails(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.LoadESigDetails, (StopTimer_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_LoadESigDetails_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus LoadESigDetails(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.LoadESigDetails(stopTimer, (StopTimer_LoadESigDetails_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus LoadESigDetails(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.LoadESigDetails(stopTimer, (StopTimer_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).ProcessComputation(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus ProcessComputation(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.ProcessComputation(stopTimer, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus ProcessComputation(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.ProcessComputation(stopTimer, (StopTimer_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).ResolveParametricData(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus ResolveParametricData(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.ResolveParametricData(stopTimer, (StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus ResolveParametricData(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.ResolveParametricData(stopTimer, (StopTimer_Parameters) null, request, out result);
    }

    public ResultStatus StopTimer(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_StopTimer_Parameters parameters,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (StopTimer), (DCObject) stopTimer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).StopTimer(this._UserProfile, stopTimer, parameters, request, out result) : this.AddMethod((Method) new StopTimerMethod(stopTimer, StopTimerMethods.StopTimer, (StopTimer_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (StopTimer), res, (DCObject) stopTimer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus StopTimer()
    {
      return this.StopTimer((Camstar.WCF.ObjectStack.StopTimer) null, (StopTimer_StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus StopTimer(Camstar.WCF.ObjectStack.StopTimer stopTimer)
    {
      return this.StopTimer(stopTimer, (StopTimer_StopTimer_Parameters) null, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus StopTimer(
      Camstar.WCF.ObjectStack.StopTimer stopTimer,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.StopTimer(stopTimer, (StopTimer_StopTimer_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject stopTimer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StopTimer_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Camstar.WCF.ObjectStack.StopTimer) stopTimer, (StopTimer_Parameters) parameters, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject stopTimer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StopTimer_Result result1;
        ResultStatus actions = this.GetActions((Camstar.WCF.ObjectStack.StopTimer) stopTimer, (StopTimer_Parameters) parameters, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject stopTimer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StopTimer_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Camstar.WCF.ObjectStack.StopTimer) stopTimer, (StopTimer_Parameters) parameters, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject stopTimer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StopTimer_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Camstar.WCF.ObjectStack.StopTimer) stopTimer, (StopTimer_LoadESigDetails_Parameters) parameters, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject stopTimer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StopTimer_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Camstar.WCF.ObjectStack.StopTimer) stopTimer, (StopTimer_Parameters) parameters, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject stopTimer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StopTimer_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Camstar.WCF.ObjectStack.StopTimer) stopTimer, (StopTimer_Parameters) parameters, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject stopTimer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StopTimer_Result result1;
        ResultStatus resultStatus = this.Load((Camstar.WCF.ObjectStack.StopTimer) stopTimer, (StopTimer_Parameters) parameters, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject stopTimer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StopTimer_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Camstar.WCF.ObjectStack.StopTimer) stopTimer, (StopTimer_Parameters) parameters, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      try
      {
        StopTimerMethod[] methods = new StopTimerMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IStopTimerService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        StopTimer_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((StopTimer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Camstar.WCF.ObjectStack.StopTimer cdo,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      try
      {
        return ((IStopTimerService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        StopTimer_Result result1;
        ResultStatus environment = this.GetEnvironment((Camstar.WCF.ObjectStack.StopTimer) cdo, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.GetEnvironment((Camstar.WCF.ObjectStack.StopTimer) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Camstar.WCF.ObjectStack.StopTimer cdo,
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      result = (StopTimer_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStopTimerService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new StopTimerMethod(cdo, StopTimerMethods.ExecuteTransaction, (StopTimer_Parameters) null));
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
        StopTimer_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Camstar.WCF.ObjectStack.StopTimer) cdo, (StopTimer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Camstar.WCF.ObjectStack.StopTimer cdo)
    {
      return this.ExecuteTransaction(cdo, (StopTimer_Request) null, out StopTimer_Result _);
    }

    public ResultStatus ExecuteTransaction(
      StopTimer_Request request,
      out StopTimer_Result result)
    {
      return this.ExecuteTransaction((Camstar.WCF.ObjectStack.StopTimer) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Camstar.WCF.ObjectStack.StopTimer cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new StopTimerMethod(cdo, StopTimerMethods.AddDataTransaction, (StopTimer_Parameters) null));
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
        return this.AddDataTransaction((Camstar.WCF.ObjectStack.StopTimer) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

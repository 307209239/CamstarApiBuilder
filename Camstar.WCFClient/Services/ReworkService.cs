// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReworkService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReworkService : MoveTxnBase
  {
    public ReworkService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReworkService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).CreateParametricData(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Rework) null, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus CreateParametricData(Rework rework)
    {
      return this.CreateParametricData(rework, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus CreateParametricData(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.CreateParametricData(rework, (Rework_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).GetActions(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Rework) null, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus GetActions(Rework rework)
    {
      return this.GetActions(rework, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus GetActions(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.GetActions(rework, (Rework_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).GetDataPoints(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Rework) null, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus GetDataPoints(Rework rework)
    {
      return this.GetDataPoints(rework, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus GetDataPoints(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.GetDataPoints(rework, (Rework_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).GetWIPMsgs(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Rework) null, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus GetWIPMsgs(Rework rework)
    {
      return this.GetWIPMsgs(rework, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.GetWIPMsgs(rework, (Rework_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).Load(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Rework) null, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus Load(Rework rework)
    {
      return this.Load(rework, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus Load(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.Load(rework, (Rework_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Rework rework,
      Rework_LoadESigDetails_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).LoadESigDetails(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.LoadESigDetails, (Rework_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Rework) null, (Rework_LoadESigDetails_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus LoadESigDetails(Rework rework)
    {
      return this.LoadESigDetails(rework, (Rework_LoadESigDetails_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus LoadESigDetails(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.LoadESigDetails(rework, (Rework_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).ProcessComputation(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Rework) null, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus ProcessComputation(Rework rework)
    {
      return this.ProcessComputation(rework, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus ProcessComputation(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.ProcessComputation(rework, (Rework_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).ResolveParametricData(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Rework) null, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus ResolveParametricData(Rework rework)
    {
      return this.ResolveParametricData(rework, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus ResolveParametricData(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.ResolveParametricData(rework, (Rework_Parameters) null, request, out result);
    }

    public ResultStatus ValidateReworkReason(
      Rework rework,
      Rework_Parameters parameters,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (ValidateReworkReason), (DCObject) rework, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).ValidateReworkReason(this._UserProfile, rework, parameters, request, out result) : this.AddMethod((Method) new ReworkMethod(rework, ReworkMethods.ValidateReworkReason, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateReworkReason), res, (DCObject) rework, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateReworkReason()
    {
      return this.ValidateReworkReason((Rework) null, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus ValidateReworkReason(Rework rework)
    {
      return this.ValidateReworkReason(rework, (Rework_Parameters) null, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus ValidateReworkReason(
      Rework rework,
      Rework_Request request,
      out Rework_Result result)
    {
      return this.ValidateReworkReason(rework, (Rework_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject rework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Rework_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Rework) rework, (Rework_Parameters) parameters, (Rework_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject rework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Rework_Result result1;
        ResultStatus actions = this.GetActions((Rework) rework, (Rework_Parameters) parameters, (Rework_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject rework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Rework_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Rework) rework, (Rework_Parameters) parameters, (Rework_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject rework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Rework_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Rework) rework, (Rework_LoadESigDetails_Parameters) parameters, (Rework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject rework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Rework_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Rework) rework, (Rework_Parameters) parameters, (Rework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject rework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Rework_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Rework) rework, (Rework_Parameters) parameters, (Rework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject rework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Rework_Result result1;
        ResultStatus resultStatus = this.Load((Rework) rework, (Rework_Parameters) parameters, (Rework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject rework,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Rework_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Rework) rework, (Rework_Parameters) parameters, (Rework_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      try
      {
        ReworkMethod[] methods = new ReworkMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReworkService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Rework_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Rework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Rework cdo,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      try
      {
        return ((IReworkService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Rework_Result result1;
        ResultStatus environment = this.GetEnvironment((Rework) cdo, (Rework_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Rework_Request request, out Rework_Result result)
    {
      return this.GetEnvironment((Rework) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Rework cdo,
      Rework_Request request,
      out Rework_Result result)
    {
      result = (Rework_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReworkService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReworkMethod(cdo, ReworkMethods.ExecuteTransaction, (Rework_Parameters) null));
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
        Rework_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Rework) cdo, (Rework_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Rework cdo)
    {
      return this.ExecuteTransaction(cdo, (Rework_Request) null, out Rework_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Rework_Request request,
      out Rework_Result result)
    {
      return this.ExecuteTransaction((Rework) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Rework cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReworkMethod(cdo, ReworkMethods.AddDataTransaction, (Rework_Parameters) null));
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
        return this.AddDataTransaction((Rework) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

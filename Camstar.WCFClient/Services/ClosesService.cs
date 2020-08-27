// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ClosesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ClosesService : ContainerStatusChangesBase
  {
    public ClosesService(UserProfile userProfile)
    {
      this.Initialize(typeof (IClosesService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) closes, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).CreateParametricData(this._UserProfile, closes, parameters, request, out result) : this.AddMethod((Method) new ClosesMethod(closes, ClosesMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) closes, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Closes) null, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus CreateParametricData(Closes closes)
    {
      return this.CreateParametricData(closes, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus CreateParametricData(
      Closes closes,
      Closes_Request request,
      out Closes_Result result)
    {
      return this.CreateParametricData(closes, (Closes_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) closes, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).GetActions(this._UserProfile, closes, parameters, request, out result) : this.AddMethod((Method) new ClosesMethod(closes, ClosesMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) closes, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Closes) null, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus GetActions(Closes closes)
    {
      return this.GetActions(closes, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus GetActions(
      Closes closes,
      Closes_Request request,
      out Closes_Result result)
    {
      return this.GetActions(closes, (Closes_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) closes, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).GetDataPoints(this._UserProfile, closes, parameters, request, out result) : this.AddMethod((Method) new ClosesMethod(closes, ClosesMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) closes, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Closes) null, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus GetDataPoints(Closes closes)
    {
      return this.GetDataPoints(closes, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus GetDataPoints(
      Closes closes,
      Closes_Request request,
      out Closes_Result result)
    {
      return this.GetDataPoints(closes, (Closes_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) closes, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).GetWIPMsgs(this._UserProfile, closes, parameters, request, out result) : this.AddMethod((Method) new ClosesMethod(closes, ClosesMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) closes, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Closes) null, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus GetWIPMsgs(Closes closes)
    {
      return this.GetWIPMsgs(closes, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Closes closes,
      Closes_Request request,
      out Closes_Result result)
    {
      return this.GetWIPMsgs(closes, (Closes_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) closes, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).Load(this._UserProfile, closes, parameters, request, out result) : this.AddMethod((Method) new ClosesMethod(closes, ClosesMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) closes, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Closes) null, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus Load(Closes closes)
    {
      return this.Load(closes, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus Load(
      Closes closes,
      Closes_Request request,
      out Closes_Result result)
    {
      return this.Load(closes, (Closes_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Closes closes,
      Closes_LoadESigDetails_Parameters parameters,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) closes, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).LoadESigDetails(this._UserProfile, closes, parameters, request, out result) : this.AddMethod((Method) new ClosesMethod(closes, ClosesMethods.LoadESigDetails, (Closes_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) closes, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Closes) null, (Closes_LoadESigDetails_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus LoadESigDetails(Closes closes)
    {
      return this.LoadESigDetails(closes, (Closes_LoadESigDetails_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus LoadESigDetails(
      Closes closes,
      Closes_Request request,
      out Closes_Result result)
    {
      return this.LoadESigDetails(closes, (Closes_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) closes, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).ProcessComputation(this._UserProfile, closes, parameters, request, out result) : this.AddMethod((Method) new ClosesMethod(closes, ClosesMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) closes, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Closes) null, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus ProcessComputation(Closes closes)
    {
      return this.ProcessComputation(closes, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus ProcessComputation(
      Closes closes,
      Closes_Request request,
      out Closes_Result result)
    {
      return this.ProcessComputation(closes, (Closes_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Closes closes,
      Closes_Parameters parameters,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) closes, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).ResolveParametricData(this._UserProfile, closes, parameters, request, out result) : this.AddMethod((Method) new ClosesMethod(closes, ClosesMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) closes, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Closes) null, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus ResolveParametricData(Closes closes)
    {
      return this.ResolveParametricData(closes, (Closes_Parameters) null, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus ResolveParametricData(
      Closes closes,
      Closes_Request request,
      out Closes_Result result)
    {
      return this.ResolveParametricData(closes, (Closes_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject closes,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Closes_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Closes) closes, (Closes_Parameters) parameters, (Closes_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject closes,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Closes_Result result1;
        ResultStatus actions = this.GetActions((Closes) closes, (Closes_Parameters) parameters, (Closes_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject closes,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Closes_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Closes) closes, (Closes_Parameters) parameters, (Closes_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject closes,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Closes_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Closes) closes, (Closes_LoadESigDetails_Parameters) parameters, (Closes_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject closes,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Closes_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Closes) closes, (Closes_Parameters) parameters, (Closes_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject closes,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Closes_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Closes) closes, (Closes_Parameters) parameters, (Closes_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject closes,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Closes_Result result1;
        ResultStatus resultStatus = this.Load((Closes) closes, (Closes_Parameters) parameters, (Closes_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject closes,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Closes_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Closes) closes, (Closes_Parameters) parameters, (Closes_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      try
      {
        ClosesMethod[] methods = new ClosesMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IClosesService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Closes_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Closes_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Closes cdo,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      try
      {
        return ((IClosesService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Closes_Result result1;
        ResultStatus environment = this.GetEnvironment((Closes) cdo, (Closes_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Closes_Request request, out Closes_Result result)
    {
      return this.GetEnvironment((Closes) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Closes cdo,
      Closes_Request request,
      out Closes_Result result)
    {
      result = (Closes_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IClosesService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ClosesMethod(cdo, ClosesMethods.ExecuteTransaction, (Closes_Parameters) null));
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
        Closes_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Closes) cdo, (Closes_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Closes cdo)
    {
      return this.ExecuteTransaction(cdo, (Closes_Request) null, out Closes_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Closes_Request request,
      out Closes_Result result)
    {
      return this.ExecuteTransaction((Closes) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Closes cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ClosesMethod(cdo, ClosesMethods.AddDataTransaction, (Closes_Parameters) null));
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
        return this.AddDataTransaction((Closes) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

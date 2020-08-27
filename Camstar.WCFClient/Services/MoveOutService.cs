// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveOutService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MoveOutService : CompoundTxnBase
  {
    public MoveOutService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMoveOutService), userProfile);
    }

    public ResultStatus CreateParametricData(
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).CreateParametricData(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((MoveOut) null, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus CreateParametricData(MoveOut moveOut)
    {
      return this.CreateParametricData(moveOut, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus CreateParametricData(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.CreateParametricData(moveOut, (MoveOut_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).GetActions(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((MoveOut) null, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus GetActions(MoveOut moveOut)
    {
      return this.GetActions(moveOut, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus GetActions(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.GetActions(moveOut, (MoveOut_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).GetDataPoints(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((MoveOut) null, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus GetDataPoints(MoveOut moveOut)
    {
      return this.GetDataPoints(moveOut, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus GetDataPoints(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.GetDataPoints(moveOut, (MoveOut_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).GetWIPMsgs(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MoveOut) null, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus GetWIPMsgs(MoveOut moveOut)
    {
      return this.GetWIPMsgs(moveOut, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.GetWIPMsgs(moveOut, (MoveOut_Parameters) null, request, out result);
    }

    public ResultStatus InitializeService(
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (InitializeService), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).InitializeService(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.InitializeService, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitializeService), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitializeService()
    {
      return this.InitializeService((MoveOut) null, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus InitializeService(MoveOut moveOut)
    {
      return this.InitializeService(moveOut, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus InitializeService(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.InitializeService(moveOut, (MoveOut_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).Load(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MoveOut) null, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus Load(MoveOut moveOut)
    {
      return this.Load(moveOut, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus Load(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.Load(moveOut, (MoveOut_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MoveOut moveOut,
      MoveOut_LoadESigDetails_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).LoadESigDetails(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.LoadESigDetails, (MoveOut_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MoveOut) null, (MoveOut_LoadESigDetails_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus LoadESigDetails(MoveOut moveOut)
    {
      return this.LoadESigDetails(moveOut, (MoveOut_LoadESigDetails_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus LoadESigDetails(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.LoadESigDetails(moveOut, (MoveOut_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).ProcessComputation(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((MoveOut) null, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus ProcessComputation(MoveOut moveOut)
    {
      return this.ProcessComputation(moveOut, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus ProcessComputation(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.ProcessComputation(moveOut, (MoveOut_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      MoveOut moveOut,
      MoveOut_Parameters parameters,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) moveOut, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).ResolveParametricData(this._UserProfile, moveOut, parameters, request, out result) : this.AddMethod((Method) new MoveOutMethod(moveOut, MoveOutMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) moveOut, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((MoveOut) null, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus ResolveParametricData(MoveOut moveOut)
    {
      return this.ResolveParametricData(moveOut, (MoveOut_Parameters) null, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus ResolveParametricData(
      MoveOut moveOut,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.ResolveParametricData(moveOut, (MoveOut_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject moveOut,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveOut_Result result1;
        ResultStatus parametricData = this.CreateParametricData((MoveOut) moveOut, (MoveOut_Parameters) parameters, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject moveOut,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveOut_Result result1;
        ResultStatus actions = this.GetActions((MoveOut) moveOut, (MoveOut_Parameters) parameters, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject moveOut,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveOut_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((MoveOut) moveOut, (MoveOut_Parameters) parameters, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject moveOut,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveOut_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MoveOut) moveOut, (MoveOut_LoadESigDetails_Parameters) parameters, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject moveOut,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveOut_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((MoveOut) moveOut, (MoveOut_Parameters) parameters, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject moveOut,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveOut_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((MoveOut) moveOut, (MoveOut_Parameters) parameters, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject moveOut,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveOut_Result result1;
        ResultStatus resultStatus = this.Load((MoveOut) moveOut, (MoveOut_Parameters) parameters, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject moveOut,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MoveOut_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MoveOut) moveOut, (MoveOut_Parameters) parameters, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      try
      {
        MoveOutMethod[] methods = new MoveOutMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMoveOutService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MoveOut_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MoveOut_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveOut cdo,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      try
      {
        return ((IMoveOutService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MoveOut_Result result1;
        ResultStatus environment = this.GetEnvironment((MoveOut) cdo, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.GetEnvironment((MoveOut) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MoveOut cdo,
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      result = (MoveOut_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMoveOutService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MoveOutMethod(cdo, MoveOutMethods.ExecuteTransaction, (MoveOut_Parameters) null));
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
        MoveOut_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MoveOut) cdo, (MoveOut_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MoveOut cdo)
    {
      return this.ExecuteTransaction(cdo, (MoveOut_Request) null, out MoveOut_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MoveOut_Request request,
      out MoveOut_Result result)
    {
      return this.ExecuteTransaction((MoveOut) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MoveOut cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MoveOutMethod(cdo, MoveOutMethods.AddDataTransaction, (MoveOut_Parameters) null));
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
        return this.AddDataTransaction((MoveOut) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

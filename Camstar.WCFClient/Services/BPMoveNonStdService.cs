// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BPMoveNonStdService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BPMoveNonStdService : BPMoveTxnBase
  {
    public BPMoveNonStdService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBPMoveNonStdService), userProfile);
    }

    public ResultStatus CreateParametricData(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).CreateParametricData(this._UserProfile, bPMoveNonStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(bPMoveNonStd, BPMoveNonStdMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((BPMoveNonStd) null, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus CreateParametricData(BPMoveNonStd bPMoveNonStd)
    {
      return this.CreateParametricData(bPMoveNonStd, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus CreateParametricData(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.CreateParametricData(bPMoveNonStd, (BPMoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).GetActions(this._UserProfile, bPMoveNonStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(bPMoveNonStd, BPMoveNonStdMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((BPMoveNonStd) null, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus GetActions(BPMoveNonStd bPMoveNonStd)
    {
      return this.GetActions(bPMoveNonStd, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus GetActions(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.GetActions(bPMoveNonStd, (BPMoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).GetDataPoints(this._UserProfile, bPMoveNonStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(bPMoveNonStd, BPMoveNonStdMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((BPMoveNonStd) null, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus GetDataPoints(BPMoveNonStd bPMoveNonStd)
    {
      return this.GetDataPoints(bPMoveNonStd, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus GetDataPoints(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.GetDataPoints(bPMoveNonStd, (BPMoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).GetWIPMsgs(this._UserProfile, bPMoveNonStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(bPMoveNonStd, BPMoveNonStdMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BPMoveNonStd) null, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus GetWIPMsgs(BPMoveNonStd bPMoveNonStd)
    {
      return this.GetWIPMsgs(bPMoveNonStd, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.GetWIPMsgs(bPMoveNonStd, (BPMoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).Load(this._UserProfile, bPMoveNonStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(bPMoveNonStd, BPMoveNonStdMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BPMoveNonStd) null, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus Load(BPMoveNonStd bPMoveNonStd)
    {
      return this.Load(bPMoveNonStd, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus Load(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.Load(bPMoveNonStd, (BPMoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_LoadESigDetails_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).LoadESigDetails(this._UserProfile, bPMoveNonStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(bPMoveNonStd, BPMoveNonStdMethods.LoadESigDetails, (BPMoveNonStd_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BPMoveNonStd) null, (BPMoveNonStd_LoadESigDetails_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus LoadESigDetails(BPMoveNonStd bPMoveNonStd)
    {
      return this.LoadESigDetails(bPMoveNonStd, (BPMoveNonStd_LoadESigDetails_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus LoadESigDetails(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.LoadESigDetails(bPMoveNonStd, (BPMoveNonStd_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).ProcessComputation(this._UserProfile, bPMoveNonStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(bPMoveNonStd, BPMoveNonStdMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((BPMoveNonStd) null, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus ProcessComputation(BPMoveNonStd bPMoveNonStd)
    {
      return this.ProcessComputation(bPMoveNonStd, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus ProcessComputation(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.ProcessComputation(bPMoveNonStd, (BPMoveNonStd_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Parameters parameters,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).ResolveParametricData(this._UserProfile, bPMoveNonStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(bPMoveNonStd, BPMoveNonStdMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) bPMoveNonStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((BPMoveNonStd) null, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus ResolveParametricData(BPMoveNonStd bPMoveNonStd)
    {
      return this.ResolveParametricData(bPMoveNonStd, (BPMoveNonStd_Parameters) null, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus ResolveParametricData(
      BPMoveNonStd bPMoveNonStd,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.ResolveParametricData(bPMoveNonStd, (BPMoveNonStd_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject bPMoveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveNonStd_Result result1;
        ResultStatus parametricData = this.CreateParametricData((BPMoveNonStd) bPMoveNonStd, (BPMoveNonStd_Parameters) parameters, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject bPMoveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveNonStd_Result result1;
        ResultStatus actions = this.GetActions((BPMoveNonStd) bPMoveNonStd, (BPMoveNonStd_Parameters) parameters, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject bPMoveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveNonStd_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((BPMoveNonStd) bPMoveNonStd, (BPMoveNonStd_Parameters) parameters, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject bPMoveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveNonStd_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BPMoveNonStd) bPMoveNonStd, (BPMoveNonStd_LoadESigDetails_Parameters) parameters, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject bPMoveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveNonStd_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((BPMoveNonStd) bPMoveNonStd, (BPMoveNonStd_Parameters) parameters, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject bPMoveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveNonStd_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((BPMoveNonStd) bPMoveNonStd, (BPMoveNonStd_Parameters) parameters, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject bPMoveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveNonStd_Result result1;
        ResultStatus resultStatus = this.Load((BPMoveNonStd) bPMoveNonStd, (BPMoveNonStd_Parameters) parameters, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject bPMoveNonStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveNonStd_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BPMoveNonStd) bPMoveNonStd, (BPMoveNonStd_Parameters) parameters, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      try
      {
        BPMoveNonStdMethod[] methods = new BPMoveNonStdMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBPMoveNonStdService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BPMoveNonStd_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BPMoveNonStd cdo,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      try
      {
        return ((IBPMoveNonStdService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BPMoveNonStd_Result result1;
        ResultStatus environment = this.GetEnvironment((BPMoveNonStd) cdo, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.GetEnvironment((BPMoveNonStd) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BPMoveNonStd cdo,
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      result = (BPMoveNonStd_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveNonStdService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BPMoveNonStdMethod(cdo, BPMoveNonStdMethods.ExecuteTransaction, (BPMoveNonStd_Parameters) null));
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
        BPMoveNonStd_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BPMoveNonStd) cdo, (BPMoveNonStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BPMoveNonStd cdo)
    {
      return this.ExecuteTransaction(cdo, (BPMoveNonStd_Request) null, out BPMoveNonStd_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BPMoveNonStd_Request request,
      out BPMoveNonStd_Result result)
    {
      return this.ExecuteTransaction((BPMoveNonStd) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BPMoveNonStd cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BPMoveNonStdMethod(cdo, BPMoveNonStdMethods.AddDataTransaction, (BPMoveNonStd_Parameters) null));
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
        return this.AddDataTransaction((BPMoveNonStd) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BPMoveStdService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BPMoveStdService : BPMoveTxnBase
  {
    public BPMoveStdService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBPMoveStdService), userProfile);
    }

    public ResultStatus CreateParametricData(
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) bPMoveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).CreateParametricData(this._UserProfile, bPMoveStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(bPMoveStd, BPMoveStdMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) bPMoveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((BPMoveStd) null, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus CreateParametricData(BPMoveStd bPMoveStd)
    {
      return this.CreateParametricData(bPMoveStd, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus CreateParametricData(
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.CreateParametricData(bPMoveStd, (BPMoveStd_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) bPMoveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).GetActions(this._UserProfile, bPMoveStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(bPMoveStd, BPMoveStdMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) bPMoveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((BPMoveStd) null, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus GetActions(BPMoveStd bPMoveStd)
    {
      return this.GetActions(bPMoveStd, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus GetActions(
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.GetActions(bPMoveStd, (BPMoveStd_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) bPMoveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).GetDataPoints(this._UserProfile, bPMoveStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(bPMoveStd, BPMoveStdMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) bPMoveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((BPMoveStd) null, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus GetDataPoints(BPMoveStd bPMoveStd)
    {
      return this.GetDataPoints(bPMoveStd, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus GetDataPoints(
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.GetDataPoints(bPMoveStd, (BPMoveStd_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) bPMoveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).GetWIPMsgs(this._UserProfile, bPMoveStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(bPMoveStd, BPMoveStdMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) bPMoveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BPMoveStd) null, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus GetWIPMsgs(BPMoveStd bPMoveStd)
    {
      return this.GetWIPMsgs(bPMoveStd, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.GetWIPMsgs(bPMoveStd, (BPMoveStd_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) bPMoveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).Load(this._UserProfile, bPMoveStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(bPMoveStd, BPMoveStdMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) bPMoveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BPMoveStd) null, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus Load(BPMoveStd bPMoveStd)
    {
      return this.Load(bPMoveStd, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus Load(
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.Load(bPMoveStd, (BPMoveStd_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BPMoveStd bPMoveStd,
      BPMoveStd_LoadESigDetails_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) bPMoveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).LoadESigDetails(this._UserProfile, bPMoveStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(bPMoveStd, BPMoveStdMethods.LoadESigDetails, (BPMoveStd_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) bPMoveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BPMoveStd) null, (BPMoveStd_LoadESigDetails_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus LoadESigDetails(BPMoveStd bPMoveStd)
    {
      return this.LoadESigDetails(bPMoveStd, (BPMoveStd_LoadESigDetails_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus LoadESigDetails(
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.LoadESigDetails(bPMoveStd, (BPMoveStd_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) bPMoveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).ProcessComputation(this._UserProfile, bPMoveStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(bPMoveStd, BPMoveStdMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) bPMoveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((BPMoveStd) null, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus ProcessComputation(BPMoveStd bPMoveStd)
    {
      return this.ProcessComputation(bPMoveStd, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus ProcessComputation(
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.ProcessComputation(bPMoveStd, (BPMoveStd_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      BPMoveStd bPMoveStd,
      BPMoveStd_Parameters parameters,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) bPMoveStd, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).ResolveParametricData(this._UserProfile, bPMoveStd, parameters, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(bPMoveStd, BPMoveStdMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) bPMoveStd, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((BPMoveStd) null, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus ResolveParametricData(BPMoveStd bPMoveStd)
    {
      return this.ResolveParametricData(bPMoveStd, (BPMoveStd_Parameters) null, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus ResolveParametricData(
      BPMoveStd bPMoveStd,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.ResolveParametricData(bPMoveStd, (BPMoveStd_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject bPMoveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveStd_Result result1;
        ResultStatus parametricData = this.CreateParametricData((BPMoveStd) bPMoveStd, (BPMoveStd_Parameters) parameters, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject bPMoveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveStd_Result result1;
        ResultStatus actions = this.GetActions((BPMoveStd) bPMoveStd, (BPMoveStd_Parameters) parameters, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject bPMoveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveStd_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((BPMoveStd) bPMoveStd, (BPMoveStd_Parameters) parameters, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject bPMoveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveStd_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BPMoveStd) bPMoveStd, (BPMoveStd_LoadESigDetails_Parameters) parameters, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject bPMoveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveStd_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((BPMoveStd) bPMoveStd, (BPMoveStd_Parameters) parameters, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject bPMoveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveStd_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((BPMoveStd) bPMoveStd, (BPMoveStd_Parameters) parameters, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject bPMoveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveStd_Result result1;
        ResultStatus resultStatus = this.Load((BPMoveStd) bPMoveStd, (BPMoveStd_Parameters) parameters, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject bPMoveStd,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPMoveStd_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BPMoveStd) bPMoveStd, (BPMoveStd_Parameters) parameters, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      try
      {
        BPMoveStdMethod[] methods = new BPMoveStdMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBPMoveStdService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BPMoveStd_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BPMoveStd cdo,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      try
      {
        return ((IBPMoveStdService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BPMoveStd_Result result1;
        ResultStatus environment = this.GetEnvironment((BPMoveStd) cdo, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.GetEnvironment((BPMoveStd) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BPMoveStd cdo,
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      result = (BPMoveStd_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPMoveStdService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BPMoveStdMethod(cdo, BPMoveStdMethods.ExecuteTransaction, (BPMoveStd_Parameters) null));
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
        BPMoveStd_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BPMoveStd) cdo, (BPMoveStd_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BPMoveStd cdo)
    {
      return this.ExecuteTransaction(cdo, (BPMoveStd_Request) null, out BPMoveStd_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BPMoveStd_Request request,
      out BPMoveStd_Result result)
    {
      return this.ExecuteTransaction((BPMoveStd) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BPMoveStd cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BPMoveStdMethod(cdo, BPMoveStdMethods.AddDataTransaction, (BPMoveStd_Parameters) null));
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
        return this.AddDataTransaction((BPMoveStd) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

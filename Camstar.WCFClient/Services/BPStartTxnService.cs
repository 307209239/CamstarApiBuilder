// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BPStartTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BPStartTxnService : BusinessProcessTxnBase
  {
    public BPStartTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBPStartTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).CreateParametricData(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((BPStartTxn) null, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus CreateParametricData(BPStartTxn bPStartTxn)
    {
      return this.CreateParametricData(bPStartTxn, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.CreateParametricData(bPStartTxn, (BPStartTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).GetActions(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((BPStartTxn) null, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus GetActions(BPStartTxn bPStartTxn)
    {
      return this.GetActions(bPStartTxn, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus GetActions(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.GetActions(bPStartTxn, (BPStartTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).GetDataPoints(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((BPStartTxn) null, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus GetDataPoints(BPStartTxn bPStartTxn)
    {
      return this.GetDataPoints(bPStartTxn, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.GetDataPoints(bPStartTxn, (BPStartTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).GetWIPMsgs(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BPStartTxn) null, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(BPStartTxn bPStartTxn)
    {
      return this.GetWIPMsgs(bPStartTxn, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.GetWIPMsgs(bPStartTxn, (BPStartTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).Load(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BPStartTxn) null, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus Load(BPStartTxn bPStartTxn)
    {
      return this.Load(bPStartTxn, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus Load(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.Load(bPStartTxn, (BPStartTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BPStartTxn bPStartTxn,
      BPStartTxn_LoadESigDetails_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).LoadESigDetails(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.LoadESigDetails, (BPStartTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BPStartTxn) null, (BPStartTxn_LoadESigDetails_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus LoadESigDetails(BPStartTxn bPStartTxn)
    {
      return this.LoadESigDetails(bPStartTxn, (BPStartTxn_LoadESigDetails_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.LoadESigDetails(bPStartTxn, (BPStartTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).ProcessComputation(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((BPStartTxn) null, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus ProcessComputation(BPStartTxn bPStartTxn)
    {
      return this.ProcessComputation(bPStartTxn, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.ProcessComputation(bPStartTxn, (BPStartTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).ResolveParametricData(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((BPStartTxn) null, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus ResolveParametricData(BPStartTxn bPStartTxn)
    {
      return this.ResolveParametricData(bPStartTxn, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.ResolveParametricData(bPStartTxn, (BPStartTxn_Parameters) null, request, out result);
    }

    public ResultStatus SetWFStack(
      BPStartTxn bPStartTxn,
      BPStartTxn_Parameters parameters,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (SetWFStack), (DCObject) bPStartTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).SetWFStack(this._UserProfile, bPStartTxn, parameters, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(bPStartTxn, BPStartTxnMethods.SetWFStack, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetWFStack), res, (DCObject) bPStartTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetWFStack()
    {
      return this.SetWFStack((BPStartTxn) null, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus SetWFStack(BPStartTxn bPStartTxn)
    {
      return this.SetWFStack(bPStartTxn, (BPStartTxn_Parameters) null, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus SetWFStack(
      BPStartTxn bPStartTxn,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.SetWFStack(bPStartTxn, (BPStartTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject bPStartTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPStartTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((BPStartTxn) bPStartTxn, (BPStartTxn_Parameters) parameters, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject bPStartTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPStartTxn_Result result1;
        ResultStatus actions = this.GetActions((BPStartTxn) bPStartTxn, (BPStartTxn_Parameters) parameters, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject bPStartTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPStartTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((BPStartTxn) bPStartTxn, (BPStartTxn_Parameters) parameters, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject bPStartTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPStartTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BPStartTxn) bPStartTxn, (BPStartTxn_LoadESigDetails_Parameters) parameters, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject bPStartTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPStartTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((BPStartTxn) bPStartTxn, (BPStartTxn_Parameters) parameters, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject bPStartTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPStartTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((BPStartTxn) bPStartTxn, (BPStartTxn_Parameters) parameters, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject bPStartTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPStartTxn_Result result1;
        ResultStatus resultStatus = this.Load((BPStartTxn) bPStartTxn, (BPStartTxn_Parameters) parameters, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject bPStartTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BPStartTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BPStartTxn) bPStartTxn, (BPStartTxn_Parameters) parameters, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      try
      {
        BPStartTxnMethod[] methods = new BPStartTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBPStartTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BPStartTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BPStartTxn cdo,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      try
      {
        return ((IBPStartTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BPStartTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((BPStartTxn) cdo, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.GetEnvironment((BPStartTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BPStartTxn cdo,
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      result = (BPStartTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBPStartTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BPStartTxnMethod(cdo, BPStartTxnMethods.ExecuteTransaction, (BPStartTxn_Parameters) null));
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
        BPStartTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BPStartTxn) cdo, (BPStartTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BPStartTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (BPStartTxn_Request) null, out BPStartTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BPStartTxn_Request request,
      out BPStartTxn_Result result)
    {
      return this.ExecuteTransaction((BPStartTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BPStartTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BPStartTxnMethod(cdo, BPStartTxnMethods.AddDataTransaction, (BPStartTxn_Parameters) null));
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
        return this.AddDataTransaction((BPStartTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

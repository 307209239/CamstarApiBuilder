// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SignApprovalService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SignApprovalService : QualityTxnBase
  {
    public SignApprovalService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISignApprovalService), userProfile);
    }

    public ResultStatus CreateParametricData(
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) signApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).CreateParametricData(this._UserProfile, signApproval, parameters, request, out result) : this.AddMethod((Method) new SignApprovalMethod(signApproval, SignApprovalMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) signApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((SignApproval) null, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus CreateParametricData(SignApproval signApproval)
    {
      return this.CreateParametricData(signApproval, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus CreateParametricData(
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.CreateParametricData(signApproval, (SignApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) signApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).GetActions(this._UserProfile, signApproval, parameters, request, out result) : this.AddMethod((Method) new SignApprovalMethod(signApproval, SignApprovalMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) signApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((SignApproval) null, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus GetActions(SignApproval signApproval)
    {
      return this.GetActions(signApproval, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus GetActions(
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.GetActions(signApproval, (SignApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) signApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).GetDataPoints(this._UserProfile, signApproval, parameters, request, out result) : this.AddMethod((Method) new SignApprovalMethod(signApproval, SignApprovalMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) signApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((SignApproval) null, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus GetDataPoints(SignApproval signApproval)
    {
      return this.GetDataPoints(signApproval, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus GetDataPoints(
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.GetDataPoints(signApproval, (SignApproval_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) signApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).GetWIPMsgs(this._UserProfile, signApproval, parameters, request, out result) : this.AddMethod((Method) new SignApprovalMethod(signApproval, SignApprovalMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) signApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SignApproval) null, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus GetWIPMsgs(SignApproval signApproval)
    {
      return this.GetWIPMsgs(signApproval, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.GetWIPMsgs(signApproval, (SignApproval_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) signApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).Load(this._UserProfile, signApproval, parameters, request, out result) : this.AddMethod((Method) new SignApprovalMethod(signApproval, SignApprovalMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) signApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SignApproval) null, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus Load(SignApproval signApproval)
    {
      return this.Load(signApproval, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus Load(
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.Load(signApproval, (SignApproval_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) signApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).LoadESigDetails(this._UserProfile, signApproval, parameters, request, out result) : this.AddMethod((Method) new SignApprovalMethod(signApproval, SignApprovalMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) signApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SignApproval) null, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus LoadESigDetails(SignApproval signApproval)
    {
      return this.LoadESigDetails(signApproval, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus LoadESigDetails(
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.LoadESigDetails(signApproval, (SignApproval_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) signApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).ProcessComputation(this._UserProfile, signApproval, parameters, request, out result) : this.AddMethod((Method) new SignApprovalMethod(signApproval, SignApprovalMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) signApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((SignApproval) null, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus ProcessComputation(SignApproval signApproval)
    {
      return this.ProcessComputation(signApproval, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus ProcessComputation(
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.ProcessComputation(signApproval, (SignApproval_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      SignApproval signApproval,
      SignApproval_Parameters parameters,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) signApproval, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).ResolveParametricData(this._UserProfile, signApproval, parameters, request, out result) : this.AddMethod((Method) new SignApprovalMethod(signApproval, SignApprovalMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) signApproval, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((SignApproval) null, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus ResolveParametricData(SignApproval signApproval)
    {
      return this.ResolveParametricData(signApproval, (SignApproval_Parameters) null, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus ResolveParametricData(
      SignApproval signApproval,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.ResolveParametricData(signApproval, (SignApproval_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject signApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignApproval_Result result1;
        ResultStatus parametricData = this.CreateParametricData((SignApproval) signApproval, (SignApproval_Parameters) parameters, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject signApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignApproval_Result result1;
        ResultStatus actions = this.GetActions((SignApproval) signApproval, (SignApproval_Parameters) parameters, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject signApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignApproval_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((SignApproval) signApproval, (SignApproval_Parameters) parameters, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject signApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignApproval_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SignApproval) signApproval, (SignApproval_Parameters) parameters, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject signApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignApproval_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((SignApproval) signApproval, (SignApproval_Parameters) parameters, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject signApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignApproval_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((SignApproval) signApproval, (SignApproval_Parameters) parameters, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject signApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignApproval_Result result1;
        ResultStatus resultStatus = this.Load((SignApproval) signApproval, (SignApproval_Parameters) parameters, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject signApproval,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SignApproval_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SignApproval) signApproval, (SignApproval_Parameters) parameters, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      try
      {
        SignApprovalMethod[] methods = new SignApprovalMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISignApprovalService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SignApproval_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SignApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SignApproval cdo,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      try
      {
        return ((ISignApprovalService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SignApproval_Result result1;
        ResultStatus environment = this.GetEnvironment((SignApproval) cdo, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.GetEnvironment((SignApproval) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SignApproval cdo,
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      result = (SignApproval_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISignApprovalService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SignApprovalMethod(cdo, SignApprovalMethods.ExecuteTransaction, (SignApproval_Parameters) null));
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
        SignApproval_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SignApproval) cdo, (SignApproval_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SignApproval cdo)
    {
      return this.ExecuteTransaction(cdo, (SignApproval_Request) null, out SignApproval_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SignApproval_Request request,
      out SignApproval_Result result)
    {
      return this.ExecuteTransaction((SignApproval) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SignApproval cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SignApprovalMethod(cdo, SignApprovalMethods.AddDataTransaction, (SignApproval_Parameters) null));
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
        return this.AddDataTransaction((SignApproval) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

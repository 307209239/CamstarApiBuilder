// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompoundTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CompoundTxnService : ShopFloorBase
  {
    public CompoundTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICompoundTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).CreateParametricData(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus CreateParametricData(CompoundTxn compoundTxn)
    {
      return this.CreateParametricData(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.CreateParametricData(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteService(
      CompoundTxn compoundTxn,
      CompoundTxn_ExecuteService_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteService), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).ExecuteService(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.ExecuteService, (CompoundTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteService), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteService()
    {
      return this.ExecuteService((CompoundTxn) null, (CompoundTxn_ExecuteService_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ExecuteService(CompoundTxn compoundTxn)
    {
      return this.ExecuteService(compoundTxn, (CompoundTxn_ExecuteService_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ExecuteService(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.ExecuteService(compoundTxn, (CompoundTxn_ExecuteService_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteSubServices(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteSubServices), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).ExecuteSubServices(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.ExecuteSubServices, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteSubServices), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteSubServices()
    {
      return this.ExecuteSubServices((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ExecuteSubServices(CompoundTxn compoundTxn)
    {
      return this.ExecuteSubServices(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ExecuteSubServices(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.ExecuteSubServices(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).GetActions(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus GetActions(CompoundTxn compoundTxn)
    {
      return this.GetActions(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus GetActions(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.GetActions(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).GetDataPoints(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus GetDataPoints(CompoundTxn compoundTxn)
    {
      return this.GetDataPoints(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.GetDataPoints(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).GetWIPMsgs(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(CompoundTxn compoundTxn)
    {
      return this.GetWIPMsgs(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.GetWIPMsgs(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    public ResultStatus InitSubServiceHistories(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (InitSubServiceHistories), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).InitSubServiceHistories(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.InitSubServiceHistories, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitSubServiceHistories), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitSubServiceHistories()
    {
      return this.InitSubServiceHistories((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus InitSubServiceHistories(CompoundTxn compoundTxn)
    {
      return this.InitSubServiceHistories(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus InitSubServiceHistories(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.InitSubServiceHistories(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).Load(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus Load(CompoundTxn compoundTxn)
    {
      return this.Load(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus Load(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.Load(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CompoundTxn compoundTxn,
      CompoundTxn_LoadESigDetails_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).LoadESigDetails(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.LoadESigDetails, (CompoundTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CompoundTxn) null, (CompoundTxn_LoadESigDetails_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus LoadESigDetails(CompoundTxn compoundTxn)
    {
      return this.LoadESigDetails(compoundTxn, (CompoundTxn_LoadESigDetails_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.LoadESigDetails(compoundTxn, (CompoundTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).ProcessComputation(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ProcessComputation(CompoundTxn compoundTxn)
    {
      return this.ProcessComputation(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.ProcessComputation(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CompoundTxn compoundTxn,
      CompoundTxn_Parameters parameters,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) compoundTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).ResolveParametricData(this._UserProfile, compoundTxn, parameters, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(compoundTxn, CompoundTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) compoundTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CompoundTxn) null, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ResolveParametricData(CompoundTxn compoundTxn)
    {
      return this.ResolveParametricData(compoundTxn, (CompoundTxn_Parameters) null, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompoundTxn compoundTxn,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.ResolveParametricData(compoundTxn, (CompoundTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject compoundTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompoundTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CompoundTxn) compoundTxn, (CompoundTxn_Parameters) parameters, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject compoundTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompoundTxn_Result result1;
        ResultStatus actions = this.GetActions((CompoundTxn) compoundTxn, (CompoundTxn_Parameters) parameters, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject compoundTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompoundTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CompoundTxn) compoundTxn, (CompoundTxn_Parameters) parameters, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject compoundTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompoundTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CompoundTxn) compoundTxn, (CompoundTxn_LoadESigDetails_Parameters) parameters, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject compoundTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompoundTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CompoundTxn) compoundTxn, (CompoundTxn_Parameters) parameters, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject compoundTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompoundTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CompoundTxn) compoundTxn, (CompoundTxn_Parameters) parameters, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject compoundTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompoundTxn_Result result1;
        ResultStatus resultStatus = this.Load((CompoundTxn) compoundTxn, (CompoundTxn_Parameters) parameters, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject compoundTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompoundTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CompoundTxn) compoundTxn, (CompoundTxn_Parameters) parameters, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      try
      {
        CompoundTxnMethod[] methods = new CompoundTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICompoundTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CompoundTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompoundTxn cdo,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      try
      {
        return ((ICompoundTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CompoundTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((CompoundTxn) cdo, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.GetEnvironment((CompoundTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CompoundTxn cdo,
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      result = (CompoundTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompoundTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CompoundTxnMethod(cdo, CompoundTxnMethods.ExecuteTransaction, (CompoundTxn_Parameters) null));
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
        CompoundTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CompoundTxn) cdo, (CompoundTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CompoundTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (CompoundTxn_Request) null, out CompoundTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CompoundTxn_Request request,
      out CompoundTxn_Result result)
    {
      return this.ExecuteTransaction((CompoundTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CompoundTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CompoundTxnMethod(cdo, CompoundTxnMethods.AddDataTransaction, (CompoundTxn_Parameters) null));
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
        return this.AddDataTransaction((CompoundTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

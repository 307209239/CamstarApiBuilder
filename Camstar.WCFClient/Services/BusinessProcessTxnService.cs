// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BusinessProcessTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BusinessProcessTxnService : GenericTxnBase
  {
    public BusinessProcessTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBusinessProcessTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).CreateParametricData(this._UserProfile, businessProcessTxn, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(businessProcessTxn, BusinessProcessTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((BusinessProcessTxn) null, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus CreateParametricData(BusinessProcessTxn businessProcessTxn)
    {
      return this.CreateParametricData(businessProcessTxn, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.CreateParametricData(businessProcessTxn, (BusinessProcessTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).GetActions(this._UserProfile, businessProcessTxn, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(businessProcessTxn, BusinessProcessTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((BusinessProcessTxn) null, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus GetActions(BusinessProcessTxn businessProcessTxn)
    {
      return this.GetActions(businessProcessTxn, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus GetActions(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.GetActions(businessProcessTxn, (BusinessProcessTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).GetDataPoints(this._UserProfile, businessProcessTxn, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(businessProcessTxn, BusinessProcessTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((BusinessProcessTxn) null, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus GetDataPoints(BusinessProcessTxn businessProcessTxn)
    {
      return this.GetDataPoints(businessProcessTxn, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.GetDataPoints(businessProcessTxn, (BusinessProcessTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).GetWIPMsgs(this._UserProfile, businessProcessTxn, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(businessProcessTxn, BusinessProcessTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BusinessProcessTxn) null, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(BusinessProcessTxn businessProcessTxn)
    {
      return this.GetWIPMsgs(businessProcessTxn, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.GetWIPMsgs(businessProcessTxn, (BusinessProcessTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).Load(this._UserProfile, businessProcessTxn, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(businessProcessTxn, BusinessProcessTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BusinessProcessTxn) null, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus Load(BusinessProcessTxn businessProcessTxn)
    {
      return this.Load(businessProcessTxn, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus Load(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.Load(businessProcessTxn, (BusinessProcessTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_LoadESigDetails_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).LoadESigDetails(this._UserProfile, businessProcessTxn, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(businessProcessTxn, BusinessProcessTxnMethods.LoadESigDetails, (BusinessProcessTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BusinessProcessTxn) null, (BusinessProcessTxn_LoadESigDetails_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus LoadESigDetails(BusinessProcessTxn businessProcessTxn)
    {
      return this.LoadESigDetails(businessProcessTxn, (BusinessProcessTxn_LoadESigDetails_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.LoadESigDetails(businessProcessTxn, (BusinessProcessTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).ProcessComputation(this._UserProfile, businessProcessTxn, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(businessProcessTxn, BusinessProcessTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((BusinessProcessTxn) null, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus ProcessComputation(BusinessProcessTxn businessProcessTxn)
    {
      return this.ProcessComputation(businessProcessTxn, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.ProcessComputation(businessProcessTxn, (BusinessProcessTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Parameters parameters,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).ResolveParametricData(this._UserProfile, businessProcessTxn, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(businessProcessTxn, BusinessProcessTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) businessProcessTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((BusinessProcessTxn) null, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus ResolveParametricData(BusinessProcessTxn businessProcessTxn)
    {
      return this.ResolveParametricData(businessProcessTxn, (BusinessProcessTxn_Parameters) null, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      BusinessProcessTxn businessProcessTxn,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.ResolveParametricData(businessProcessTxn, (BusinessProcessTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject businessProcessTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((BusinessProcessTxn) businessProcessTxn, (BusinessProcessTxn_Parameters) parameters, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject businessProcessTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessTxn_Result result1;
        ResultStatus actions = this.GetActions((BusinessProcessTxn) businessProcessTxn, (BusinessProcessTxn_Parameters) parameters, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject businessProcessTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((BusinessProcessTxn) businessProcessTxn, (BusinessProcessTxn_Parameters) parameters, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject businessProcessTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BusinessProcessTxn) businessProcessTxn, (BusinessProcessTxn_LoadESigDetails_Parameters) parameters, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject businessProcessTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((BusinessProcessTxn) businessProcessTxn, (BusinessProcessTxn_Parameters) parameters, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject businessProcessTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((BusinessProcessTxn) businessProcessTxn, (BusinessProcessTxn_Parameters) parameters, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject businessProcessTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessTxn_Result result1;
        ResultStatus resultStatus = this.Load((BusinessProcessTxn) businessProcessTxn, (BusinessProcessTxn_Parameters) parameters, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject businessProcessTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BusinessProcessTxn) businessProcessTxn, (BusinessProcessTxn_Parameters) parameters, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      try
      {
        BusinessProcessTxnMethod[] methods = new BusinessProcessTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBusinessProcessTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BusinessProcessTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessProcessTxn cdo,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      try
      {
        return ((IBusinessProcessTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BusinessProcessTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((BusinessProcessTxn) cdo, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.GetEnvironment((BusinessProcessTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BusinessProcessTxn cdo,
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      result = (BusinessProcessTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BusinessProcessTxnMethod(cdo, BusinessProcessTxnMethods.ExecuteTransaction, (BusinessProcessTxn_Parameters) null));
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
        BusinessProcessTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BusinessProcessTxn) cdo, (BusinessProcessTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BusinessProcessTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (BusinessProcessTxn_Request) null, out BusinessProcessTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BusinessProcessTxn_Request request,
      out BusinessProcessTxn_Result result)
    {
      return this.ExecuteTransaction((BusinessProcessTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BusinessProcessTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BusinessProcessTxnMethod(cdo, BusinessProcessTxnMethods.AddDataTransaction, (BusinessProcessTxn_Parameters) null));
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
        return this.AddDataTransaction((BusinessProcessTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

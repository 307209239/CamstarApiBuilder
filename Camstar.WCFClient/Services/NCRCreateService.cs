// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRCreateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRCreateService : NCRTxnBase
  {
    public NCRCreateService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRCreateService), userProfile);
    }

    public ResultStatus AddHistoryCrossRefs(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (AddHistoryCrossRefs), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).AddHistoryCrossRefs(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.AddHistoryCrossRefs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddHistoryCrossRefs), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddHistoryCrossRefs()
    {
      return this.AddHistoryCrossRefs((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus AddHistoryCrossRefs(NCRCreate nCRCreate)
    {
      return this.AddHistoryCrossRefs(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus AddHistoryCrossRefs(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.AddHistoryCrossRefs(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).CreateParametricData(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus CreateParametricData(NCRCreate nCRCreate)
    {
      return this.CreateParametricData(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus CreateParametricData(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.CreateParametricData(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).GetActions(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetActions(NCRCreate nCRCreate)
    {
      return this.GetActions(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetActions(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.GetActions(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).GetDataPoints(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetDataPoints(NCRCreate nCRCreate)
    {
      return this.GetDataPoints(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetDataPoints(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.GetDataPoints(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus GetIssueActualsHistory(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (GetIssueActualsHistory), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).GetIssueActualsHistory(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.GetIssueActualsHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetIssueActualsHistory), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetIssueActualsHistory()
    {
      return this.GetIssueActualsHistory((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetIssueActualsHistory(NCRCreate nCRCreate)
    {
      return this.GetIssueActualsHistory(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetIssueActualsHistory(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.GetIssueActualsHistory(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus GetNonconformanceName(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (GetNonconformanceName), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).GetNonconformanceName(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.GetNonconformanceName, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetNonconformanceName), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetNonconformanceName()
    {
      return this.GetNonconformanceName((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetNonconformanceName(NCRCreate nCRCreate)
    {
      return this.GetNonconformanceName(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetNonconformanceName(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.GetNonconformanceName(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).GetWIPMsgs(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRCreate nCRCreate)
    {
      return this.GetWIPMsgs(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.GetWIPMsgs(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).Load(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus Load(NCRCreate nCRCreate)
    {
      return this.Load(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus Load(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.Load(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRCreate nCRCreate,
      NCRCreate_LoadESigDetails_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).LoadESigDetails(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.LoadESigDetails, (NCRCreate_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRCreate) null, (NCRCreate_LoadESigDetails_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus LoadESigDetails(NCRCreate nCRCreate)
    {
      return this.LoadESigDetails(nCRCreate, (NCRCreate_LoadESigDetails_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.LoadESigDetails(nCRCreate, (NCRCreate_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).ProcessComputation(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus ProcessComputation(NCRCreate nCRCreate)
    {
      return this.ProcessComputation(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus ProcessComputation(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.ProcessComputation(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      NCRCreate nCRCreate,
      NCRCreate_Parameters parameters,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) nCRCreate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).ResolveParametricData(this._UserProfile, nCRCreate, parameters, request, out result) : this.AddMethod((Method) new NCRCreateMethod(nCRCreate, NCRCreateMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) nCRCreate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((NCRCreate) null, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus ResolveParametricData(NCRCreate nCRCreate)
    {
      return this.ResolveParametricData(nCRCreate, (NCRCreate_Parameters) null, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus ResolveParametricData(
      NCRCreate nCRCreate,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.ResolveParametricData(nCRCreate, (NCRCreate_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject nCRCreate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCreate_Result result1;
        ResultStatus parametricData = this.CreateParametricData((NCRCreate) nCRCreate, (NCRCreate_Parameters) parameters, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject nCRCreate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCreate_Result result1;
        ResultStatus actions = this.GetActions((NCRCreate) nCRCreate, (NCRCreate_Parameters) parameters, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject nCRCreate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCreate_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((NCRCreate) nCRCreate, (NCRCreate_Parameters) parameters, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRCreate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCreate_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRCreate) nCRCreate, (NCRCreate_LoadESigDetails_Parameters) parameters, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject nCRCreate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCreate_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((NCRCreate) nCRCreate, (NCRCreate_Parameters) parameters, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject nCRCreate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCreate_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((NCRCreate) nCRCreate, (NCRCreate_Parameters) parameters, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRCreate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCreate_Result result1;
        ResultStatus resultStatus = this.Load((NCRCreate) nCRCreate, (NCRCreate_Parameters) parameters, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRCreate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCreate_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRCreate) nCRCreate, (NCRCreate_Parameters) parameters, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      try
      {
        NCRCreateMethod[] methods = new NCRCreateMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRCreateService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRCreate_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRCreate cdo,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      try
      {
        return ((INCRCreateService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRCreate_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRCreate) cdo, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.GetEnvironment((NCRCreate) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRCreate cdo,
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      result = (NCRCreate_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCreateService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRCreateMethod(cdo, NCRCreateMethods.ExecuteTransaction, (NCRCreate_Parameters) null));
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
        NCRCreate_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRCreate) cdo, (NCRCreate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRCreate cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRCreate_Request) null, out NCRCreate_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRCreate_Request request,
      out NCRCreate_Result result)
    {
      return this.ExecuteTransaction((NCRCreate) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRCreate cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRCreateMethod(cdo, NCRCreateMethods.AddDataTransaction, (NCRCreate_Parameters) null));
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
        return this.AddDataTransaction((NCRCreate) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

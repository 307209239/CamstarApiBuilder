// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRUpdateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRUpdateService : NCRTxnBase
  {
    public NCRUpdateService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRUpdateService), userProfile);
    }

    public ResultStatus CreateParametricData(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).CreateParametricData(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus CreateParametricData(NCRUpdate nCRUpdate)
    {
      return this.CreateParametricData(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus CreateParametricData(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.CreateParametricData(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).GetActions(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetActions(NCRUpdate nCRUpdate)
    {
      return this.GetActions(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetActions(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.GetActions(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetAttributes(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (GetAttributes), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).GetAttributes(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.GetAttributes, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAttributes), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAttributes()
    {
      return this.GetAttributes((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetAttributes(NCRUpdate nCRUpdate)
    {
      return this.GetAttributes(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetAttributes(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.GetAttributes(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).GetDataPoints(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetDataPoints(NCRUpdate nCRUpdate)
    {
      return this.GetDataPoints(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetDataPoints(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.GetDataPoints(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetDefectHistoryDetails(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (GetDefectHistoryDetails), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).GetDefectHistoryDetails(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.GetDefectHistoryDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDefectHistoryDetails), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDefectHistoryDetails()
    {
      return this.GetDefectHistoryDetails((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetDefectHistoryDetails(NCRUpdate nCRUpdate)
    {
      return this.GetDefectHistoryDetails(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetDefectHistoryDetails(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.GetDefectHistoryDetails(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetIssueActualsHistory(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (GetIssueActualsHistory), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).GetIssueActualsHistory(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.GetIssueActualsHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetIssueActualsHistory), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetIssueActualsHistory()
    {
      return this.GetIssueActualsHistory((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetIssueActualsHistory(NCRUpdate nCRUpdate)
    {
      return this.GetIssueActualsHistory(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetIssueActualsHistory(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.GetIssueActualsHistory(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).GetWIPMsgs(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRUpdate nCRUpdate)
    {
      return this.GetWIPMsgs(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.GetWIPMsgs(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).Load(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus Load(NCRUpdate nCRUpdate)
    {
      return this.Load(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus Load(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.Load(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRUpdate nCRUpdate,
      NCRUpdate_LoadESigDetails_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).LoadESigDetails(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.LoadESigDetails, (NCRUpdate_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRUpdate) null, (NCRUpdate_LoadESigDetails_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus LoadESigDetails(NCRUpdate nCRUpdate)
    {
      return this.LoadESigDetails(nCRUpdate, (NCRUpdate_LoadESigDetails_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.LoadESigDetails(nCRUpdate, (NCRUpdate_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).ProcessComputation(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus ProcessComputation(NCRUpdate nCRUpdate)
    {
      return this.ProcessComputation(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus ProcessComputation(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.ProcessComputation(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      NCRUpdate nCRUpdate,
      NCRUpdate_Parameters parameters,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) nCRUpdate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).ResolveParametricData(this._UserProfile, nCRUpdate, parameters, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(nCRUpdate, NCRUpdateMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) nCRUpdate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((NCRUpdate) null, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus ResolveParametricData(NCRUpdate nCRUpdate)
    {
      return this.ResolveParametricData(nCRUpdate, (NCRUpdate_Parameters) null, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus ResolveParametricData(
      NCRUpdate nCRUpdate,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.ResolveParametricData(nCRUpdate, (NCRUpdate_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRUpdate_Result result1;
        ResultStatus parametricData = this.CreateParametricData((NCRUpdate) nCRUpdate, (NCRUpdate_Parameters) parameters, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRUpdate_Result result1;
        ResultStatus actions = this.GetActions((NCRUpdate) nCRUpdate, (NCRUpdate_Parameters) parameters, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRUpdate_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((NCRUpdate) nCRUpdate, (NCRUpdate_Parameters) parameters, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRUpdate_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRUpdate) nCRUpdate, (NCRUpdate_LoadESigDetails_Parameters) parameters, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRUpdate_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((NCRUpdate) nCRUpdate, (NCRUpdate_Parameters) parameters, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRUpdate_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((NCRUpdate) nCRUpdate, (NCRUpdate_Parameters) parameters, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRUpdate_Result result1;
        ResultStatus resultStatus = this.Load((NCRUpdate) nCRUpdate, (NCRUpdate_Parameters) parameters, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRUpdate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRUpdate_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRUpdate) nCRUpdate, (NCRUpdate_Parameters) parameters, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      try
      {
        NCRUpdateMethod[] methods = new NCRUpdateMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRUpdateService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRUpdate_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRUpdate cdo,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      try
      {
        return ((INCRUpdateService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRUpdate_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRUpdate) cdo, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.GetEnvironment((NCRUpdate) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRUpdate cdo,
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      result = (NCRUpdate_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRUpdateService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRUpdateMethod(cdo, NCRUpdateMethods.ExecuteTransaction, (NCRUpdate_Parameters) null));
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
        NCRUpdate_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRUpdate) cdo, (NCRUpdate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRUpdate cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRUpdate_Request) null, out NCRUpdate_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRUpdate_Request request,
      out NCRUpdate_Result result)
    {
      return this.ExecuteTransaction((NCRUpdate) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRUpdate cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRUpdateMethod(cdo, NCRUpdateMethods.AddDataTransaction, (NCRUpdate_Parameters) null));
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
        return this.AddDataTransaction((NCRUpdate) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

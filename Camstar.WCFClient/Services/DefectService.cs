// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DefectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DefectService : ContainerTxnBase
  {
    public DefectService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDefectService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).CreateParametricData(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus CreateParametricData(Defect defect)
    {
      return this.CreateParametricData(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus CreateParametricData(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.CreateParametricData(defect, (Defect_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).GetActions(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetActions(Defect defect)
    {
      return this.GetActions(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetActions(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.GetActions(defect, (Defect_Parameters) null, request, out result);
    }

    public ResultStatus GetActuals(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (GetActuals), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).GetActuals(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.GetActuals, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActuals), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActuals()
    {
      return this.GetActuals((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetActuals(Defect defect)
    {
      return this.GetActuals(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetActuals(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.GetActuals(defect, (Defect_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).GetDataPoints(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetDataPoints(Defect defect)
    {
      return this.GetDataPoints(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetDataPoints(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.GetDataPoints(defect, (Defect_Parameters) null, request, out result);
    }

    public ResultStatus GetIssueActualsHistory(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (GetIssueActualsHistory), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).GetIssueActualsHistory(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.GetIssueActualsHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetIssueActualsHistory), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetIssueActualsHistory()
    {
      return this.GetIssueActualsHistory((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetIssueActualsHistory(Defect defect)
    {
      return this.GetIssueActualsHistory(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetIssueActualsHistory(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.GetIssueActualsHistory(defect, (Defect_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).GetWIPMsgs(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetWIPMsgs(Defect defect)
    {
      return this.GetWIPMsgs(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.GetWIPMsgs(defect, (Defect_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).Load(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus Load(Defect defect)
    {
      return this.Load(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus Load(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.Load(defect, (Defect_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Defect defect,
      Defect_LoadESigDetails_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).LoadESigDetails(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.LoadESigDetails, (Defect_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Defect) null, (Defect_LoadESigDetails_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus LoadESigDetails(Defect defect)
    {
      return this.LoadESigDetails(defect, (Defect_LoadESigDetails_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus LoadESigDetails(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.LoadESigDetails(defect, (Defect_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).ProcessComputation(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus ProcessComputation(Defect defect)
    {
      return this.ProcessComputation(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus ProcessComputation(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.ProcessComputation(defect, (Defect_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Defect defect,
      Defect_Parameters parameters,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) defect, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).ResolveParametricData(this._UserProfile, defect, parameters, request, out result) : this.AddMethod((Method) new DefectMethod(defect, DefectMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) defect, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Defect) null, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus ResolveParametricData(Defect defect)
    {
      return this.ResolveParametricData(defect, (Defect_Parameters) null, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus ResolveParametricData(
      Defect defect,
      Defect_Request request,
      out Defect_Result result)
    {
      return this.ResolveParametricData(defect, (Defect_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Defect_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Defect) defect, (Defect_Parameters) parameters, (Defect_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Defect_Result result1;
        ResultStatus actions = this.GetActions((Defect) defect, (Defect_Parameters) parameters, (Defect_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Defect_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Defect) defect, (Defect_Parameters) parameters, (Defect_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Defect_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Defect) defect, (Defect_LoadESigDetails_Parameters) parameters, (Defect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Defect_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Defect) defect, (Defect_Parameters) parameters, (Defect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Defect_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Defect) defect, (Defect_Parameters) parameters, (Defect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Defect_Result result1;
        ResultStatus resultStatus = this.Load((Defect) defect, (Defect_Parameters) parameters, (Defect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject defect,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Defect_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Defect) defect, (Defect_Parameters) parameters, (Defect_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      try
      {
        DefectMethod[] methods = new DefectMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDefectService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Defect_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Defect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Defect cdo,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      try
      {
        return ((IDefectService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Defect_Result result1;
        ResultStatus environment = this.GetEnvironment((Defect) cdo, (Defect_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Defect_Request request, out Defect_Result result)
    {
      return this.GetEnvironment((Defect) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Defect cdo,
      Defect_Request request,
      out Defect_Result result)
    {
      result = (Defect_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDefectService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DefectMethod(cdo, DefectMethods.ExecuteTransaction, (Defect_Parameters) null));
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
        Defect_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Defect) cdo, (Defect_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Defect cdo)
    {
      return this.ExecuteTransaction(cdo, (Defect_Request) null, out Defect_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Defect_Request request,
      out Defect_Result result)
    {
      return this.ExecuteTransaction((Defect) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Defect cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DefectMethod(cdo, DefectMethods.AddDataTransaction, (Defect_Parameters) null));
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
        return this.AddDataTransaction((Defect) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

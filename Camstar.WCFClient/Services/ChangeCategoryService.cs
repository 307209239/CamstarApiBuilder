// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeCategoryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeCategoryService : QualityTxnBase
  {
    public ChangeCategoryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeCategoryService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).CreateParametricData(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus CreateParametricData(ChangeCategory changeCategory)
    {
      return this.CreateParametricData(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus CreateParametricData(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.CreateParametricData(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).GetActions(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus GetActions(ChangeCategory changeCategory)
    {
      return this.GetActions(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus GetActions(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.GetActions(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).GetDataPoints(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus GetDataPoints(ChangeCategory changeCategory)
    {
      return this.GetDataPoints(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus GetDataPoints(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.GetDataPoints(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).GetWIPMsgs(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeCategory changeCategory)
    {
      return this.GetWIPMsgs(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.GetWIPMsgs(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).Load(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus Load(ChangeCategory changeCategory)
    {
      return this.Load(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus Load(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.Load(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).LoadESigDetails(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeCategory changeCategory)
    {
      return this.LoadESigDetails(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.LoadESigDetails(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).ProcessComputation(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus ProcessComputation(ChangeCategory changeCategory)
    {
      return this.ProcessComputation(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus ProcessComputation(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.ProcessComputation(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).ResolveParametricData(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus ResolveParametricData(ChangeCategory changeCategory)
    {
      return this.ResolveParametricData(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.ResolveParametricData(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus SetEscalationDate(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (SetEscalationDate), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).SetEscalationDate(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.SetEscalationDate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetEscalationDate), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetEscalationDate()
    {
      return this.SetEscalationDate((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus SetEscalationDate(ChangeCategory changeCategory)
    {
      return this.SetEscalationDate(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus SetEscalationDate(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.SetEscalationDate(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus SetTriageComplete(
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (SetTriageComplete), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).SetTriageComplete(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.SetTriageComplete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetTriageComplete), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetTriageComplete()
    {
      return this.SetTriageComplete((ChangeCategory) null, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus SetTriageComplete(ChangeCategory changeCategory)
    {
      return this.SetTriageComplete(changeCategory, (ChangeCategory_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus SetTriageComplete(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.SetTriageComplete(changeCategory, (ChangeCategory_Parameters) null, request, out result);
    }

    public ResultStatus ValidateCategoryTransition(
      ChangeCategory changeCategory,
      ChangeCategory_ValidateCategoryTransition_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (ValidateCategoryTransition), (DCObject) changeCategory, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).ValidateCategoryTransition(this._UserProfile, changeCategory, parameters, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(changeCategory, ChangeCategoryMethods.ValidateCategoryTransition, (ChangeCategory_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateCategoryTransition), res, (DCObject) changeCategory, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateCategoryTransition()
    {
      return this.ValidateCategoryTransition((ChangeCategory) null, (ChangeCategory_ValidateCategoryTransition_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus ValidateCategoryTransition(ChangeCategory changeCategory)
    {
      return this.ValidateCategoryTransition(changeCategory, (ChangeCategory_ValidateCategoryTransition_Parameters) null, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus ValidateCategoryTransition(
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.ValidateCategoryTransition(changeCategory, (ChangeCategory_ValidateCategoryTransition_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject changeCategory,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeCategory_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChangeCategory) changeCategory, (ChangeCategory_Parameters) parameters, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject changeCategory,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeCategory_Result result1;
        ResultStatus actions = this.GetActions((ChangeCategory) changeCategory, (ChangeCategory_Parameters) parameters, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject changeCategory,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeCategory_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChangeCategory) changeCategory, (ChangeCategory_Parameters) parameters, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeCategory,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeCategory_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeCategory) changeCategory, (ChangeCategory_Parameters) parameters, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject changeCategory,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeCategory_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChangeCategory) changeCategory, (ChangeCategory_Parameters) parameters, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject changeCategory,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeCategory_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChangeCategory) changeCategory, (ChangeCategory_Parameters) parameters, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeCategory,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeCategory_Result result1;
        ResultStatus resultStatus = this.Load((ChangeCategory) changeCategory, (ChangeCategory_Parameters) parameters, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeCategory,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeCategory_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeCategory) changeCategory, (ChangeCategory_Parameters) parameters, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      try
      {
        ChangeCategoryMethod[] methods = new ChangeCategoryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeCategoryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeCategory_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeCategory cdo,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      try
      {
        return ((IChangeCategoryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeCategory_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeCategory) cdo, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.GetEnvironment((ChangeCategory) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeCategory cdo,
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      result = (ChangeCategory_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeCategoryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeCategoryMethod(cdo, ChangeCategoryMethods.ExecuteTransaction, (ChangeCategory_Parameters) null));
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
        ChangeCategory_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeCategory) cdo, (ChangeCategory_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeCategory cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeCategory_Request) null, out ChangeCategory_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeCategory_Request request,
      out ChangeCategory_Result result)
    {
      return this.ExecuteTransaction((ChangeCategory) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeCategory cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeCategoryMethod(cdo, ChangeCategoryMethods.AddDataTransaction, (ChangeCategory_Parameters) null));
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
        return this.AddDataTransaction((ChangeCategory) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

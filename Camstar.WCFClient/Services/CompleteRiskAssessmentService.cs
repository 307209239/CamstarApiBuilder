// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteRiskAssessmentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CompleteRiskAssessmentService : QualityTxnBase
  {
    public CompleteRiskAssessmentService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICompleteRiskAssessmentService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).CreateParametricData(this._UserProfile, completeRiskAssessment, parameters, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(completeRiskAssessment, CompleteRiskAssessmentMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CompleteRiskAssessment) null, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus CreateParametricData(
      CompleteRiskAssessment completeRiskAssessment)
    {
      return this.CreateParametricData(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus CreateParametricData(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.CreateParametricData(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).GetActions(this._UserProfile, completeRiskAssessment, parameters, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(completeRiskAssessment, CompleteRiskAssessmentMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CompleteRiskAssessment) null, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus GetActions(CompleteRiskAssessment completeRiskAssessment)
    {
      return this.GetActions(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus GetActions(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.GetActions(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).GetDataPoints(this._UserProfile, completeRiskAssessment, parameters, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(completeRiskAssessment, CompleteRiskAssessmentMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CompleteRiskAssessment) null, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus GetDataPoints(CompleteRiskAssessment completeRiskAssessment)
    {
      return this.GetDataPoints(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus GetDataPoints(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.GetDataPoints(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).GetWIPMsgs(this._UserProfile, completeRiskAssessment, parameters, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(completeRiskAssessment, CompleteRiskAssessmentMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CompleteRiskAssessment) null, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus GetWIPMsgs(CompleteRiskAssessment completeRiskAssessment)
    {
      return this.GetWIPMsgs(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.GetWIPMsgs(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).Load(this._UserProfile, completeRiskAssessment, parameters, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(completeRiskAssessment, CompleteRiskAssessmentMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CompleteRiskAssessment) null, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus Load(CompleteRiskAssessment completeRiskAssessment)
    {
      return this.Load(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus Load(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.Load(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).LoadESigDetails(this._UserProfile, completeRiskAssessment, parameters, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(completeRiskAssessment, CompleteRiskAssessmentMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CompleteRiskAssessment) null, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus LoadESigDetails(CompleteRiskAssessment completeRiskAssessment)
    {
      return this.LoadESigDetails(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus LoadESigDetails(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.LoadESigDetails(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).ProcessComputation(this._UserProfile, completeRiskAssessment, parameters, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(completeRiskAssessment, CompleteRiskAssessmentMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CompleteRiskAssessment) null, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus ProcessComputation(CompleteRiskAssessment completeRiskAssessment)
    {
      return this.ProcessComputation(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus ProcessComputation(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.ProcessComputation(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Parameters parameters,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).ResolveParametricData(this._UserProfile, completeRiskAssessment, parameters, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(completeRiskAssessment, CompleteRiskAssessmentMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) completeRiskAssessment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CompleteRiskAssessment) null, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteRiskAssessment completeRiskAssessment)
    {
      return this.ResolveParametricData(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus ResolveParametricData(
      CompleteRiskAssessment completeRiskAssessment,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.ResolveParametricData(completeRiskAssessment, (CompleteRiskAssessment_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject completeRiskAssessment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteRiskAssessment_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CompleteRiskAssessment) completeRiskAssessment, (CompleteRiskAssessment_Parameters) parameters, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject completeRiskAssessment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteRiskAssessment_Result result1;
        ResultStatus actions = this.GetActions((CompleteRiskAssessment) completeRiskAssessment, (CompleteRiskAssessment_Parameters) parameters, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject completeRiskAssessment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteRiskAssessment_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CompleteRiskAssessment) completeRiskAssessment, (CompleteRiskAssessment_Parameters) parameters, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject completeRiskAssessment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteRiskAssessment_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CompleteRiskAssessment) completeRiskAssessment, (CompleteRiskAssessment_Parameters) parameters, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject completeRiskAssessment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteRiskAssessment_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CompleteRiskAssessment) completeRiskAssessment, (CompleteRiskAssessment_Parameters) parameters, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject completeRiskAssessment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteRiskAssessment_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CompleteRiskAssessment) completeRiskAssessment, (CompleteRiskAssessment_Parameters) parameters, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject completeRiskAssessment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteRiskAssessment_Result result1;
        ResultStatus resultStatus = this.Load((CompleteRiskAssessment) completeRiskAssessment, (CompleteRiskAssessment_Parameters) parameters, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject completeRiskAssessment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteRiskAssessment_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CompleteRiskAssessment) completeRiskAssessment, (CompleteRiskAssessment_Parameters) parameters, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      try
      {
        CompleteRiskAssessmentMethod[] methods = new CompleteRiskAssessmentMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICompleteRiskAssessmentService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CompleteRiskAssessment_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteRiskAssessment cdo,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      try
      {
        return ((ICompleteRiskAssessmentService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CompleteRiskAssessment_Result result1;
        ResultStatus environment = this.GetEnvironment((CompleteRiskAssessment) cdo, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.GetEnvironment((CompleteRiskAssessment) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CompleteRiskAssessment cdo,
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      result = (CompleteRiskAssessment_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteRiskAssessmentService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CompleteRiskAssessmentMethod(cdo, CompleteRiskAssessmentMethods.ExecuteTransaction, (CompleteRiskAssessment_Parameters) null));
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
        CompleteRiskAssessment_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CompleteRiskAssessment) cdo, (CompleteRiskAssessment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CompleteRiskAssessment cdo)
    {
      return this.ExecuteTransaction(cdo, (CompleteRiskAssessment_Request) null, out CompleteRiskAssessment_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CompleteRiskAssessment_Request request,
      out CompleteRiskAssessment_Result result)
    {
      return this.ExecuteTransaction((CompleteRiskAssessment) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CompleteRiskAssessment cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CompleteRiskAssessmentMethod(cdo, CompleteRiskAssessmentMethods.AddDataTransaction, (CompleteRiskAssessment_Parameters) null));
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
        return this.AddDataTransaction((CompleteRiskAssessment) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

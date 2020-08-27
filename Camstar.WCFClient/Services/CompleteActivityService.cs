// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CompleteActivityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CompleteActivityService : ProcessObjectTxnBase
  {
    public CompleteActivityService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICompleteActivityService), userProfile);
    }

    public ResultStatus CompleteActivity(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (CompleteActivity), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).CompleteActivity(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.CompleteActivity, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CompleteActivity), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CompleteActivity()
    {
      return this.CompleteActivity((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus CompleteActivity(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.CompleteActivity(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus CompleteActivity(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.CompleteActivity(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).CreateParametricData(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus CreateParametricData(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.CreateParametricData(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus CreateParametricData(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.CreateParametricData(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).GetActions(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus GetActions(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.GetActions(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus GetActions(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.GetActions(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus GetChecklistEntries(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (GetChecklistEntries), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).GetChecklistEntries(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.GetChecklistEntries, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetChecklistEntries), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetChecklistEntries()
    {
      return this.GetChecklistEntries((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus GetChecklistEntries(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.GetChecklistEntries(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus GetChecklistEntries(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.GetChecklistEntries(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).GetDataPoints(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus GetDataPoints(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.GetDataPoints(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus GetDataPoints(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.GetDataPoints(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).GetWIPMsgs(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus GetWIPMsgs(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.GetWIPMsgs(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.GetWIPMsgs(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).Load(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus Load(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.Load(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus Load(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.Load(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus LoadDataPoints(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (LoadDataPoints), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).LoadDataPoints(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.LoadDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadDataPoints), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadDataPoints()
    {
      return this.LoadDataPoints((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus LoadDataPoints(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.LoadDataPoints(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus LoadDataPoints(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.LoadDataPoints(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).LoadESigDetails(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus LoadESigDetails(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.LoadESigDetails(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus LoadESigDetails(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.LoadESigDetails(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).ProcessComputation(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus ProcessComputation(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.ProcessComputation(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus ProcessComputation(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.ProcessComputation(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Parameters parameters,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) completeActivity, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).ResolveParametricData(this._UserProfile, completeActivity, parameters, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(completeActivity, CompleteActivityMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) completeActivity, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Camstar.WCF.ObjectStack.CompleteActivity) null, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus ResolveParametricData(Camstar.WCF.ObjectStack.CompleteActivity completeActivity)
    {
      return this.ResolveParametricData(completeActivity, (CompleteActivity_Parameters) null, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus ResolveParametricData(
      Camstar.WCF.ObjectStack.CompleteActivity completeActivity,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.ResolveParametricData(completeActivity, (CompleteActivity_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivity_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Camstar.WCF.ObjectStack.CompleteActivity) completeActivity, (CompleteActivity_Parameters) parameters, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivity_Result result1;
        ResultStatus actions = this.GetActions((Camstar.WCF.ObjectStack.CompleteActivity) completeActivity, (CompleteActivity_Parameters) parameters, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivity_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Camstar.WCF.ObjectStack.CompleteActivity) completeActivity, (CompleteActivity_Parameters) parameters, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivity_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Camstar.WCF.ObjectStack.CompleteActivity) completeActivity, (CompleteActivity_Parameters) parameters, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivity_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Camstar.WCF.ObjectStack.CompleteActivity) completeActivity, (CompleteActivity_Parameters) parameters, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivity_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Camstar.WCF.ObjectStack.CompleteActivity) completeActivity, (CompleteActivity_Parameters) parameters, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivity_Result result1;
        ResultStatus resultStatus = this.Load((Camstar.WCF.ObjectStack.CompleteActivity) completeActivity, (CompleteActivity_Parameters) parameters, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject completeActivity,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CompleteActivity_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Camstar.WCF.ObjectStack.CompleteActivity) completeActivity, (CompleteActivity_Parameters) parameters, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      try
      {
        CompleteActivityMethod[] methods = new CompleteActivityMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICompleteActivityService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CompleteActivity_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Camstar.WCF.ObjectStack.CompleteActivity cdo,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      try
      {
        return ((ICompleteActivityService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CompleteActivity_Result result1;
        ResultStatus environment = this.GetEnvironment((Camstar.WCF.ObjectStack.CompleteActivity) cdo, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.GetEnvironment((Camstar.WCF.ObjectStack.CompleteActivity) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Camstar.WCF.ObjectStack.CompleteActivity cdo,
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      result = (CompleteActivity_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICompleteActivityService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CompleteActivityMethod(cdo, CompleteActivityMethods.ExecuteTransaction, (CompleteActivity_Parameters) null));
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
        CompleteActivity_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Camstar.WCF.ObjectStack.CompleteActivity) cdo, (CompleteActivity_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Camstar.WCF.ObjectStack.CompleteActivity cdo)
    {
      return this.ExecuteTransaction(cdo, (CompleteActivity_Request) null, out CompleteActivity_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CompleteActivity_Request request,
      out CompleteActivity_Result result)
    {
      return this.ExecuteTransaction((Camstar.WCF.ObjectStack.CompleteActivity) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Camstar.WCF.ObjectStack.CompleteActivity cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CompleteActivityMethod(cdo, CompleteActivityMethods.AddDataTransaction, (CompleteActivity_Parameters) null));
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
        return this.AddDataTransaction((Camstar.WCF.ObjectStack.CompleteActivity) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

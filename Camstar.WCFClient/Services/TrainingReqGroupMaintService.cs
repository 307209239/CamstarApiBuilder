// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrainingReqGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TrainingReqGroupMaintService : RevisionedObjectGroupMaintBase
  {
    public TrainingReqGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITrainingReqGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).Delete(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus Delete(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.Delete(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus Delete(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.Delete(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).Freeze(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus Freeze(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.Freeze(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.Freeze(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.GetWIPMsgs(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.GetWIPMsgs(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).Load(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus Load(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.Load(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus Load(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.Load(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_LoadESigDetails_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.LoadESigDetails, (TrainingReqGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_LoadESigDetails_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.LoadESigDetails(trainingReqGroupMaint, (TrainingReqGroupMaint_LoadESigDetails_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.LoadESigDetails(trainingReqGroupMaint, (TrainingReqGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).New(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus New(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.New(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus New(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.New(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).NewCopy(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus NewCopy(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.NewCopy(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.NewCopy(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).SaveAs(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus SaveAs(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.SaveAs(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.SaveAs(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Parameters parameters,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).UnFreeze(this._UserProfile, trainingReqGroupMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(trainingReqGroupMaint, TrainingReqGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) trainingReqGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TrainingReqGroupMaint) null, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(TrainingReqGroupMaint trainingReqGroupMaint)
    {
      return this.UnFreeze(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TrainingReqGroupMaint trainingReqGroupMaint,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.UnFreeze(trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_LoadESigDetails_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject trainingReqGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingReqGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TrainingReqGroupMaint) trainingReqGroupMaint, (TrainingReqGroupMaint_Parameters) parameters, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      try
      {
        TrainingReqGroupMaintMethod[] methods = new TrainingReqGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITrainingReqGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingReqGroupMaint cdo,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      try
      {
        return ((ITrainingReqGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TrainingReqGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TrainingReqGroupMaint) cdo, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.GetEnvironment((TrainingReqGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TrainingReqGroupMaint cdo,
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      result = (TrainingReqGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingReqGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TrainingReqGroupMaintMethod(cdo, TrainingReqGroupMaintMethods.ExecuteTransaction, (TrainingReqGroupMaint_Parameters) null));
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
        TrainingReqGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TrainingReqGroupMaint) cdo, (TrainingReqGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TrainingReqGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TrainingReqGroupMaint_Request) null, out TrainingReqGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TrainingReqGroupMaint_Request request,
      out TrainingReqGroupMaint_Result result)
    {
      return this.ExecuteTransaction((TrainingReqGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TrainingReqGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TrainingReqGroupMaintMethod(cdo, TrainingReqGroupMaintMethods.AddDataTransaction, (TrainingReqGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((TrainingReqGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

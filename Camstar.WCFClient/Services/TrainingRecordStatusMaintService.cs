// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrainingRecordStatusMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TrainingRecordStatusMaintService : UserCodeMaintBase
  {
    public TrainingRecordStatusMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITrainingRecordStatusMaintService), userProfile);
    }

    public ResultStatus Delete(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).Delete(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus Delete(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.Delete(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus Delete(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.Delete(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).Freeze(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus Freeze(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.Freeze(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus Freeze(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.Freeze(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).GetWIPMsgs(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.GetWIPMsgs(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.GetWIPMsgs(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).Load(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus Load(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.Load(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus Load(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.Load(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_LoadESigDetails_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).LoadESigDetails(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.LoadESigDetails, (TrainingRecordStatusMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_LoadESigDetails_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.LoadESigDetails(trainingRecordStatusMaint, (TrainingRecordStatusMaint_LoadESigDetails_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.LoadESigDetails(trainingRecordStatusMaint, (TrainingRecordStatusMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).New(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus New(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.New(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus New(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.New(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).NewCopy(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus NewCopy(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.NewCopy(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus NewCopy(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.NewCopy(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).SaveAs(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus SaveAs(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.SaveAs(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus SaveAs(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.SaveAs(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Parameters parameters,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).UnFreeze(this._UserProfile, trainingRecordStatusMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(trainingRecordStatusMaint, TrainingRecordStatusMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) trainingRecordStatusMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TrainingRecordStatusMaint) null, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TrainingRecordStatusMaint trainingRecordStatusMaint)
    {
      return this.UnFreeze(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TrainingRecordStatusMaint trainingRecordStatusMaint,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.UnFreeze(trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_LoadESigDetails_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.New((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.Load((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject trainingRecordStatusMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordStatusMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TrainingRecordStatusMaint) trainingRecordStatusMaint, (TrainingRecordStatusMaint_Parameters) parameters, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      try
      {
        TrainingRecordStatusMaintMethod[] methods = new TrainingRecordStatusMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITrainingRecordStatusMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingRecordStatusMaint cdo,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      try
      {
        return ((ITrainingRecordStatusMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TrainingRecordStatusMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TrainingRecordStatusMaint) cdo, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.GetEnvironment((TrainingRecordStatusMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TrainingRecordStatusMaint cdo,
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      result = (TrainingRecordStatusMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordStatusMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(cdo, TrainingRecordStatusMaintMethods.ExecuteTransaction, (TrainingRecordStatusMaint_Parameters) null));
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
        TrainingRecordStatusMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TrainingRecordStatusMaint) cdo, (TrainingRecordStatusMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TrainingRecordStatusMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TrainingRecordStatusMaint_Request) null, out TrainingRecordStatusMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TrainingRecordStatusMaint_Request request,
      out TrainingRecordStatusMaint_Result result)
    {
      return this.ExecuteTransaction((TrainingRecordStatusMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TrainingRecordStatusMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TrainingRecordStatusMaintMethod(cdo, TrainingRecordStatusMaintMethods.AddDataTransaction, (TrainingRecordStatusMaint_Parameters) null));
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
        return this.AddDataTransaction((TrainingRecordStatusMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

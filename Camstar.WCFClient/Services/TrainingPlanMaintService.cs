// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrainingPlanMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TrainingPlanMaintService : NamedDataObjectMaintBase
  {
    public TrainingPlanMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITrainingPlanMaintService), userProfile);
    }

    public ResultStatus Delete(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).Delete(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TrainingPlanMaint) null, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus Delete(TrainingPlanMaint trainingPlanMaint)
    {
      return this.Delete(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus Delete(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.Delete(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).Freeze(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TrainingPlanMaint) null, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus Freeze(TrainingPlanMaint trainingPlanMaint)
    {
      return this.Freeze(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus Freeze(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.Freeze(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).GetWIPMsgs(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TrainingPlanMaint) null, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TrainingPlanMaint trainingPlanMaint)
    {
      return this.GetWIPMsgs(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.GetWIPMsgs(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).Load(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TrainingPlanMaint) null, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus Load(TrainingPlanMaint trainingPlanMaint)
    {
      return this.Load(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus Load(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.Load(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_LoadESigDetails_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).LoadESigDetails(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.LoadESigDetails, (TrainingPlanMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TrainingPlanMaint) null, (TrainingPlanMaint_LoadESigDetails_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus LoadESigDetails(TrainingPlanMaint trainingPlanMaint)
    {
      return this.LoadESigDetails(trainingPlanMaint, (TrainingPlanMaint_LoadESigDetails_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.LoadESigDetails(trainingPlanMaint, (TrainingPlanMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).New(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TrainingPlanMaint) null, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus New(TrainingPlanMaint trainingPlanMaint)
    {
      return this.New(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus New(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.New(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).NewCopy(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TrainingPlanMaint) null, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus NewCopy(TrainingPlanMaint trainingPlanMaint)
    {
      return this.NewCopy(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus NewCopy(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.NewCopy(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).SaveAs(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TrainingPlanMaint) null, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus SaveAs(TrainingPlanMaint trainingPlanMaint)
    {
      return this.SaveAs(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus SaveAs(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.SaveAs(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Parameters parameters,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).UnFreeze(this._UserProfile, trainingPlanMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(trainingPlanMaint, TrainingPlanMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) trainingPlanMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TrainingPlanMaint) null, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus UnFreeze(TrainingPlanMaint trainingPlanMaint)
    {
      return this.UnFreeze(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TrainingPlanMaint trainingPlanMaint,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.UnFreeze(trainingPlanMaint, (TrainingPlanMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_LoadESigDetails_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.New((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.Load((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject trainingPlanMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingPlanMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TrainingPlanMaint) trainingPlanMaint, (TrainingPlanMaint_Parameters) parameters, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      try
      {
        TrainingPlanMaintMethod[] methods = new TrainingPlanMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITrainingPlanMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingPlanMaint cdo,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      try
      {
        return ((ITrainingPlanMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TrainingPlanMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TrainingPlanMaint) cdo, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.GetEnvironment((TrainingPlanMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TrainingPlanMaint cdo,
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      result = (TrainingPlanMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingPlanMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TrainingPlanMaintMethod(cdo, TrainingPlanMaintMethods.ExecuteTransaction, (TrainingPlanMaint_Parameters) null));
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
        TrainingPlanMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TrainingPlanMaint) cdo, (TrainingPlanMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TrainingPlanMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TrainingPlanMaint_Request) null, out TrainingPlanMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TrainingPlanMaint_Request request,
      out TrainingPlanMaint_Result result)
    {
      return this.ExecuteTransaction((TrainingPlanMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TrainingPlanMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TrainingPlanMaintMethod(cdo, TrainingPlanMaintMethods.AddDataTransaction, (TrainingPlanMaint_Parameters) null));
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
        return this.AddDataTransaction((TrainingPlanMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

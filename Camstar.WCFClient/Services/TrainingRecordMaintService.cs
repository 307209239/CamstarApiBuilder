// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrainingRecordMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class TrainingRecordMaintService : SubentityMaintenanceBase
  {
    public TrainingRecordMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ITrainingRecordMaintService), userProfile);
    }

    public ResultStatus Delete(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).Delete(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus Delete(TrainingRecordMaint trainingRecordMaint)
    {
      return this.Delete(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus Delete(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.Delete(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).Freeze(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus Freeze(TrainingRecordMaint trainingRecordMaint)
    {
      return this.Freeze(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus Freeze(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.Freeze(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetTrainingRecord(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_GetTrainingRecord_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (GetTrainingRecord), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).GetTrainingRecord(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.GetTrainingRecord, (TrainingRecordMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetTrainingRecord), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetTrainingRecord()
    {
      return this.GetTrainingRecord((TrainingRecordMaint) null, (TrainingRecordMaint_GetTrainingRecord_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus GetTrainingRecord(TrainingRecordMaint trainingRecordMaint)
    {
      return this.GetTrainingRecord(trainingRecordMaint, (TrainingRecordMaint_GetTrainingRecord_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus GetTrainingRecord(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.GetTrainingRecord(trainingRecordMaint, (TrainingRecordMaint_GetTrainingRecord_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).GetWIPMsgs(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(TrainingRecordMaint trainingRecordMaint)
    {
      return this.GetWIPMsgs(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.GetWIPMsgs(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).Load(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus Load(TrainingRecordMaint trainingRecordMaint)
    {
      return this.Load(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus Load(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.Load(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_LoadESigDetails_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).LoadESigDetails(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.LoadESigDetails, (TrainingRecordMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((TrainingRecordMaint) null, (TrainingRecordMaint_LoadESigDetails_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus LoadESigDetails(TrainingRecordMaint trainingRecordMaint)
    {
      return this.LoadESigDetails(trainingRecordMaint, (TrainingRecordMaint_LoadESigDetails_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.LoadESigDetails(trainingRecordMaint, (TrainingRecordMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).New(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus New(TrainingRecordMaint trainingRecordMaint)
    {
      return this.New(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus New(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.New(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).NewCopy(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus NewCopy(TrainingRecordMaint trainingRecordMaint)
    {
      return this.NewCopy(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus NewCopy(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.NewCopy(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).SaveAs(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus SaveAs(TrainingRecordMaint trainingRecordMaint)
    {
      return this.SaveAs(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus SaveAs(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.SaveAs(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).UnFreeze(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus UnFreeze(TrainingRecordMaint trainingRecordMaint)
    {
      return this.UnFreeze(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus UnFreeze(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.UnFreeze(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_ValidateEmployeeRoleCombination_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateEmployeeRoleCombination), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).ValidateEmployeeRoleCombination(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.ValidateEmployeeRoleCombination, (TrainingRecordMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateEmployeeRoleCombination), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateEmployeeRoleCombination()
    {
      return this.ValidateEmployeeRoleCombination((TrainingRecordMaint) null, (TrainingRecordMaint_ValidateEmployeeRoleCombination_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      TrainingRecordMaint trainingRecordMaint)
    {
      return this.ValidateEmployeeRoleCombination(trainingRecordMaint, (TrainingRecordMaint_ValidateEmployeeRoleCombination_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.ValidateEmployeeRoleCombination(trainingRecordMaint, (TrainingRecordMaint_ValidateEmployeeRoleCombination_Parameters) null, request, out result);
    }

    public ResultStatus ValidateESigRequirement(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateESigRequirement), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).ValidateESigRequirement(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.ValidateESigRequirement, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateESigRequirement), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateESigRequirement()
    {
      return this.ValidateESigRequirement((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ValidateESigRequirement(TrainingRecordMaint trainingRecordMaint)
    {
      return this.ValidateESigRequirement(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ValidateESigRequirement(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.ValidateESigRequirement(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateRefInfoIsUnique(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateRefInfoIsUnique), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).ValidateRefInfoIsUnique(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.ValidateRefInfoIsUnique, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateRefInfoIsUnique), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateRefInfoIsUnique()
    {
      return this.ValidateRefInfoIsUnique((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ValidateRefInfoIsUnique(TrainingRecordMaint trainingRecordMaint)
    {
      return this.ValidateRefInfoIsUnique(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ValidateRefInfoIsUnique(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.ValidateRefInfoIsUnique(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateTrainer(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Parameters parameters,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateTrainer), (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).ValidateTrainer(this._UserProfile, trainingRecordMaint, parameters, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(trainingRecordMaint, TrainingRecordMaintMethods.ValidateTrainer, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateTrainer), res, (DCObject) trainingRecordMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateTrainer()
    {
      return this.ValidateTrainer((TrainingRecordMaint) null, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ValidateTrainer(TrainingRecordMaint trainingRecordMaint)
    {
      return this.ValidateTrainer(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ValidateTrainer(
      TrainingRecordMaint trainingRecordMaint,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.ValidateTrainer(trainingRecordMaint, (TrainingRecordMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.Delete((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_LoadESigDetails_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.New((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.Load((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject trainingRecordMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        TrainingRecordMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((TrainingRecordMaint) trainingRecordMaint, (TrainingRecordMaint_Parameters) parameters, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      try
      {
        TrainingRecordMaintMethod[] methods = new TrainingRecordMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ITrainingRecordMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingRecordMaint cdo,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      try
      {
        return ((ITrainingRecordMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        TrainingRecordMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((TrainingRecordMaint) cdo, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.GetEnvironment((TrainingRecordMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      TrainingRecordMaint cdo,
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      result = (TrainingRecordMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ITrainingRecordMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new TrainingRecordMaintMethod(cdo, TrainingRecordMaintMethods.ExecuteTransaction, (TrainingRecordMaint_Parameters) null));
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
        TrainingRecordMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((TrainingRecordMaint) cdo, (TrainingRecordMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(TrainingRecordMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (TrainingRecordMaint_Request) null, out TrainingRecordMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      TrainingRecordMaint_Request request,
      out TrainingRecordMaint_Result result)
    {
      return this.ExecuteTransaction((TrainingRecordMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(TrainingRecordMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new TrainingRecordMaintMethod(cdo, TrainingRecordMaintMethods.AddDataTransaction, (TrainingRecordMaint_Parameters) null));
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
        return this.AddDataTransaction((TrainingRecordMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

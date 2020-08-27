// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ScheduledBusinessRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ScheduledBusinessRuleMaintService : NamedDataObjectMaintBase
  {
    public ScheduledBusinessRuleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IScheduledBusinessRuleMaintService), userProfile);
    }

    public ResultStatus Delete(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).Delete(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Delete(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.Delete(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Delete(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.Delete(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).Freeze(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Freeze(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.Freeze(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Freeze(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.Freeze(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.GetWIPMsgs(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.GetWIPMsgs(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Hold(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Hold), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).Hold(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.Hold, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Hold), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Hold()
    {
      return this.Hold((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Hold(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.Hold(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Hold(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.Hold(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).Load(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Load(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.Load(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Load(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.Load(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_LoadESigDetails_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).LoadESigDetails(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.LoadESigDetails, (ScheduledBusinessRuleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_LoadESigDetails_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.LoadESigDetails(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_LoadESigDetails_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.LoadESigDetails(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).New(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus New(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.New(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus New(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.New(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).NewCopy(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus NewCopy(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.NewCopy(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus NewCopy(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.NewCopy(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Release(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Release), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).Release(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.Release, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Release), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Release()
    {
      return this.Release((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Release(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.Release(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Release(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.Release(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).SaveAs(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus SaveAs(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.SaveAs(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus SaveAs(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.SaveAs(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).UnFreeze(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.UnFreeze(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.UnFreeze(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Validate(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Parameters parameters,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Validate), (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).Validate(this._UserProfile, scheduledBusinessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(scheduledBusinessRuleMaint, ScheduledBusinessRuleMaintMethods.Validate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Validate), res, (DCObject) scheduledBusinessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Validate()
    {
      return this.Validate((ScheduledBusinessRuleMaint) null, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Validate(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint)
    {
      return this.Validate(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus Validate(
      ScheduledBusinessRuleMaint scheduledBusinessRuleMaint,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.Validate(scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_LoadESigDetails_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.New((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.Load((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject scheduledBusinessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ScheduledBusinessRuleMaint) scheduledBusinessRuleMaint, (ScheduledBusinessRuleMaint_Parameters) parameters, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      try
      {
        ScheduledBusinessRuleMaintMethod[] methods = new ScheduledBusinessRuleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IScheduledBusinessRuleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScheduledBusinessRuleMaint cdo,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      try
      {
        return ((IScheduledBusinessRuleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ScheduledBusinessRuleMaint) cdo, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.GetEnvironment((ScheduledBusinessRuleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ScheduledBusinessRuleMaint cdo,
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      result = (ScheduledBusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IScheduledBusinessRuleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(cdo, ScheduledBusinessRuleMaintMethods.ExecuteTransaction, (ScheduledBusinessRuleMaint_Parameters) null));
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
        ScheduledBusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ScheduledBusinessRuleMaint) cdo, (ScheduledBusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ScheduledBusinessRuleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ScheduledBusinessRuleMaint_Request) null, out ScheduledBusinessRuleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ScheduledBusinessRuleMaint_Request request,
      out ScheduledBusinessRuleMaint_Result result)
    {
      return this.ExecuteTransaction((ScheduledBusinessRuleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ScheduledBusinessRuleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ScheduledBusinessRuleMaintMethod(cdo, ScheduledBusinessRuleMaintMethods.AddDataTransaction, (ScheduledBusinessRuleMaint_Parameters) null));
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
        return this.AddDataTransaction((ScheduledBusinessRuleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

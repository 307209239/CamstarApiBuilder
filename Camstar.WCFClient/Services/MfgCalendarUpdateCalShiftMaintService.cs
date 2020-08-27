// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MfgCalendarUpdateCalShiftMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MfgCalendarUpdateCalShiftMaintService : MfgCalendarMaintBase
  {
    public MfgCalendarUpdateCalShiftMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMfgCalendarUpdateCalShiftMaintService), userProfile);
    }

    public ResultStatus Delete(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).Delete(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus Delete(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.Delete(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus Delete(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.Delete(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).Freeze(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus Freeze(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.Freeze(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus Freeze(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.Freeze(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).GetWIPMsgs(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.GetWIPMsgs(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.GetWIPMsgs(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).Load(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus Load(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.Load(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus Load(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.Load(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_LoadESigDetails_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).LoadESigDetails(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.LoadESigDetails, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_LoadESigDetails_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.LoadESigDetails(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_LoadESigDetails_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.LoadESigDetails(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).New(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus New(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.New(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus New(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.New(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).NewCopy(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus NewCopy(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.NewCopy(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus NewCopy(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.NewCopy(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).SaveAs(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus SaveAs(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.SaveAs(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus SaveAs(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.SaveAs(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Parameters parameters,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).UnFreeze(this._UserProfile, mfgCalendarUpdateCalShiftMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(mfgCalendarUpdateCalShiftMaint, MfgCalendarUpdateCalShiftMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) mfgCalendarUpdateCalShiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MfgCalendarUpdateCalShiftMaint) null, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint)
    {
      return this.UnFreeze(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MfgCalendarUpdateCalShiftMaint mfgCalendarUpdateCalShiftMaint,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.UnFreeze(mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_LoadESigDetails_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.New((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.Load((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject mfgCalendarUpdateCalShiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MfgCalendarUpdateCalShiftMaint) mfgCalendarUpdateCalShiftMaint, (MfgCalendarUpdateCalShiftMaint_Parameters) parameters, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      try
      {
        MfgCalendarUpdateCalShiftMaintMethod[] methods = new MfgCalendarUpdateCalShiftMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MfgCalendarUpdateCalShiftMaint cdo,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      try
      {
        return ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MfgCalendarUpdateCalShiftMaint) cdo, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.GetEnvironment((MfgCalendarUpdateCalShiftMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MfgCalendarUpdateCalShiftMaint cdo,
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      result = (MfgCalendarUpdateCalShiftMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarUpdateCalShiftMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(cdo, MfgCalendarUpdateCalShiftMaintMethods.ExecuteTransaction, (MfgCalendarUpdateCalShiftMaint_Parameters) null));
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
        MfgCalendarUpdateCalShiftMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MfgCalendarUpdateCalShiftMaint) cdo, (MfgCalendarUpdateCalShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MfgCalendarUpdateCalShiftMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MfgCalendarUpdateCalShiftMaint_Request) null, out MfgCalendarUpdateCalShiftMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MfgCalendarUpdateCalShiftMaint_Request request,
      out MfgCalendarUpdateCalShiftMaint_Result result)
    {
      return this.ExecuteTransaction((MfgCalendarUpdateCalShiftMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MfgCalendarUpdateCalShiftMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MfgCalendarUpdateCalShiftMaintMethod(cdo, MfgCalendarUpdateCalShiftMaintMethods.AddDataTransaction, (MfgCalendarUpdateCalShiftMaint_Parameters) null));
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
        return this.AddDataTransaction((MfgCalendarUpdateCalShiftMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

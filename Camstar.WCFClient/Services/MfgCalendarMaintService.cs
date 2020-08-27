// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MfgCalendarMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MfgCalendarMaintService : NamedDataObjectMaintBase
  {
    public MfgCalendarMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMfgCalendarMaintService), userProfile);
    }

    public ResultStatus CheckShiftAction(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (CheckShiftAction), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).CheckShiftAction(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.CheckShiftAction, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckShiftAction), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckShiftAction()
    {
      return this.CheckShiftAction((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus CheckShiftAction(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.CheckShiftAction(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus CheckShiftAction(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.CheckShiftAction(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).Delete(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus Delete(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.Delete(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus Delete(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.Delete(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).Freeze(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus Freeze(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.Freeze(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus Freeze(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.Freeze(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).GetWIPMsgs(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.GetWIPMsgs(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.GetWIPMsgs(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).Load(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus Load(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.Load(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus Load(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.Load(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_LoadESigDetails_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).LoadESigDetails(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.LoadESigDetails, (MfgCalendarMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MfgCalendarMaint) null, (MfgCalendarMaint_LoadESigDetails_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.LoadESigDetails(mfgCalendarMaint, (MfgCalendarMaint_LoadESigDetails_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.LoadESigDetails(mfgCalendarMaint, (MfgCalendarMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).New(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus New(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.New(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus New(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.New(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).NewCopy(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus NewCopy(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.NewCopy(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus NewCopy(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.NewCopy(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).SaveAs(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus SaveAs(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.SaveAs(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus SaveAs(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.SaveAs(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Parameters parameters,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).UnFreeze(this._UserProfile, mfgCalendarMaint, parameters, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(mfgCalendarMaint, MfgCalendarMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) mfgCalendarMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MfgCalendarMaint) null, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus UnFreeze(MfgCalendarMaint mfgCalendarMaint)
    {
      return this.UnFreeze(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MfgCalendarMaint mfgCalendarMaint,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.UnFreeze(mfgCalendarMaint, (MfgCalendarMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_LoadESigDetails_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.New((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.Load((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject mfgCalendarMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MfgCalendarMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MfgCalendarMaint) mfgCalendarMaint, (MfgCalendarMaint_Parameters) parameters, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      try
      {
        MfgCalendarMaintMethod[] methods = new MfgCalendarMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMfgCalendarMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MfgCalendarMaint cdo,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      try
      {
        return ((IMfgCalendarMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MfgCalendarMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MfgCalendarMaint) cdo, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.GetEnvironment((MfgCalendarMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MfgCalendarMaint cdo,
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      result = (MfgCalendarMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMfgCalendarMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MfgCalendarMaintMethod(cdo, MfgCalendarMaintMethods.ExecuteTransaction, (MfgCalendarMaint_Parameters) null));
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
        MfgCalendarMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MfgCalendarMaint) cdo, (MfgCalendarMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MfgCalendarMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MfgCalendarMaint_Request) null, out MfgCalendarMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MfgCalendarMaint_Request request,
      out MfgCalendarMaint_Result result)
    {
      return this.ExecuteTransaction((MfgCalendarMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MfgCalendarMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MfgCalendarMaintMethod(cdo, MfgCalendarMaintMethods.AddDataTransaction, (MfgCalendarMaint_Parameters) null));
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
        return this.AddDataTransaction((MfgCalendarMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

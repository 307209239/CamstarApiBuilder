// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BonusReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BonusReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public BonusReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBonusReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).Delete(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.Delete(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.Delete(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.Freeze(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.Freeze(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.GetWIPMsgs(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).Load(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus Load(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.Load(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.Load(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_LoadESigDetails_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.LoadESigDetails, (BonusReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_LoadESigDetails_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.LoadESigDetails(bonusReasonGroupMaint, (BonusReasonGroupMaint_LoadESigDetails_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(bonusReasonGroupMaint, (BonusReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).New(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus New(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.New(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.New(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.NewCopy(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.NewCopy(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.SaveAs(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.SaveAs(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Parameters parameters,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, bonusReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(bonusReasonGroupMaint, BonusReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) bonusReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BonusReasonGroupMaint) null, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(BonusReasonGroupMaint bonusReasonGroupMaint)
    {
      return this.UnFreeze(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BonusReasonGroupMaint bonusReasonGroupMaint,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.UnFreeze(bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_LoadESigDetails_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject bonusReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BonusReasonGroupMaint) bonusReasonGroupMaint, (BonusReasonGroupMaint_Parameters) parameters, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      try
      {
        BonusReasonGroupMaintMethod[] methods = new BonusReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBonusReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BonusReasonGroupMaint cdo,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      try
      {
        return ((IBonusReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BonusReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BonusReasonGroupMaint) cdo, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((BonusReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BonusReasonGroupMaint cdo,
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      result = (BonusReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BonusReasonGroupMaintMethod(cdo, BonusReasonGroupMaintMethods.ExecuteTransaction, (BonusReasonGroupMaint_Parameters) null));
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
        BonusReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BonusReasonGroupMaint) cdo, (BonusReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BonusReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BonusReasonGroupMaint_Request) null, out BonusReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BonusReasonGroupMaint_Request request,
      out BonusReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((BonusReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BonusReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BonusReasonGroupMaintMethod(cdo, BonusReasonGroupMaintMethods.AddDataTransaction, (BonusReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((BonusReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

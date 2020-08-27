// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BonusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BonusReasonMaintService : UserCodeMaintBase
  {
    public BonusReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBonusReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).Delete(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BonusReasonMaint) null, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus Delete(BonusReasonMaint bonusReasonMaint)
    {
      return this.Delete(bonusReasonMaint, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus Delete(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.Delete(bonusReasonMaint, (BonusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).Freeze(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BonusReasonMaint) null, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus Freeze(BonusReasonMaint bonusReasonMaint)
    {
      return this.Freeze(bonusReasonMaint, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.Freeze(bonusReasonMaint, (BonusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BonusReasonMaint) null, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BonusReasonMaint bonusReasonMaint)
    {
      return this.GetWIPMsgs(bonusReasonMaint, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.GetWIPMsgs(bonusReasonMaint, (BonusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).Load(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BonusReasonMaint) null, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus Load(BonusReasonMaint bonusReasonMaint)
    {
      return this.Load(bonusReasonMaint, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus Load(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.Load(bonusReasonMaint, (BonusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_LoadESigDetails_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.LoadESigDetails, (BonusReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BonusReasonMaint) null, (BonusReasonMaint_LoadESigDetails_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BonusReasonMaint bonusReasonMaint)
    {
      return this.LoadESigDetails(bonusReasonMaint, (BonusReasonMaint_LoadESigDetails_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.LoadESigDetails(bonusReasonMaint, (BonusReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).New(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BonusReasonMaint) null, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus New(BonusReasonMaint bonusReasonMaint)
    {
      return this.New(bonusReasonMaint, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus New(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.New(bonusReasonMaint, (BonusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).NewCopy(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BonusReasonMaint) null, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(BonusReasonMaint bonusReasonMaint)
    {
      return this.NewCopy(bonusReasonMaint, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.NewCopy(bonusReasonMaint, (BonusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).SaveAs(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BonusReasonMaint) null, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(BonusReasonMaint bonusReasonMaint)
    {
      return this.SaveAs(bonusReasonMaint, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.SaveAs(bonusReasonMaint, (BonusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Parameters parameters,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).UnFreeze(this._UserProfile, bonusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(bonusReasonMaint, BonusReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) bonusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BonusReasonMaint) null, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(BonusReasonMaint bonusReasonMaint)
    {
      return this.UnFreeze(bonusReasonMaint, (BonusReasonMaint_Parameters) null, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BonusReasonMaint bonusReasonMaint,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.UnFreeze(bonusReasonMaint, (BonusReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_LoadESigDetails_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject bonusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BonusReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BonusReasonMaint) bonusReasonMaint, (BonusReasonMaint_Parameters) parameters, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      try
      {
        BonusReasonMaintMethod[] methods = new BonusReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBonusReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BonusReasonMaint cdo,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      try
      {
        return ((IBonusReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BonusReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BonusReasonMaint) cdo, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.GetEnvironment((BonusReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BonusReasonMaint cdo,
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      result = (BonusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBonusReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BonusReasonMaintMethod(cdo, BonusReasonMaintMethods.ExecuteTransaction, (BonusReasonMaint_Parameters) null));
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
        BonusReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BonusReasonMaint) cdo, (BonusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BonusReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BonusReasonMaint_Request) null, out BonusReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BonusReasonMaint_Request request,
      out BonusReasonMaint_Result result)
    {
      return this.ExecuteTransaction((BonusReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BonusReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BonusReasonMaintMethod(cdo, BonusReasonMaintMethods.AddDataTransaction, (BonusReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((BonusReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

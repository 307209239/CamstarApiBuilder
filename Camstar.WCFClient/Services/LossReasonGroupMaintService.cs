// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.LossReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class LossReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public LossReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ILossReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).Delete(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((LossReasonGroupMaint) null, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.Delete(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.Delete(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((LossReasonGroupMaint) null, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.Freeze(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.Freeze(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((LossReasonGroupMaint) null, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.GetWIPMsgs(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).Load(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((LossReasonGroupMaint) null, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus Load(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.Load(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.Load(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_LoadESigDetails_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.LoadESigDetails, (LossReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((LossReasonGroupMaint) null, (LossReasonGroupMaint_LoadESigDetails_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.LoadESigDetails(lossReasonGroupMaint, (LossReasonGroupMaint_LoadESigDetails_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(lossReasonGroupMaint, (LossReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).New(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((LossReasonGroupMaint) null, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus New(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.New(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.New(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((LossReasonGroupMaint) null, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.NewCopy(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.NewCopy(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((LossReasonGroupMaint) null, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.SaveAs(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.SaveAs(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Parameters parameters,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, lossReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(lossReasonGroupMaint, LossReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) lossReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((LossReasonGroupMaint) null, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(LossReasonGroupMaint lossReasonGroupMaint)
    {
      return this.UnFreeze(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      LossReasonGroupMaint lossReasonGroupMaint,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.UnFreeze(lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_LoadESigDetails_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject lossReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((LossReasonGroupMaint) lossReasonGroupMaint, (LossReasonGroupMaint_Parameters) parameters, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      try
      {
        LossReasonGroupMaintMethod[] methods = new LossReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ILossReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      LossReasonGroupMaint cdo,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      try
      {
        return ((ILossReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        LossReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((LossReasonGroupMaint) cdo, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((LossReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      LossReasonGroupMaint cdo,
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      result = (LossReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new LossReasonGroupMaintMethod(cdo, LossReasonGroupMaintMethods.ExecuteTransaction, (LossReasonGroupMaint_Parameters) null));
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
        LossReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((LossReasonGroupMaint) cdo, (LossReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(LossReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (LossReasonGroupMaint_Request) null, out LossReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      LossReasonGroupMaint_Request request,
      out LossReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((LossReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(LossReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new LossReasonGroupMaintMethod(cdo, LossReasonGroupMaintMethods.AddDataTransaction, (LossReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((LossReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

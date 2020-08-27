// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.LossReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class LossReasonMaintService : UserCodeMaintBase
  {
    public LossReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ILossReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).Delete(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((LossReasonMaint) null, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus Delete(LossReasonMaint lossReasonMaint)
    {
      return this.Delete(lossReasonMaint, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus Delete(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.Delete(lossReasonMaint, (LossReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).Freeze(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((LossReasonMaint) null, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus Freeze(LossReasonMaint lossReasonMaint)
    {
      return this.Freeze(lossReasonMaint, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.Freeze(lossReasonMaint, (LossReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((LossReasonMaint) null, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(LossReasonMaint lossReasonMaint)
    {
      return this.GetWIPMsgs(lossReasonMaint, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.GetWIPMsgs(lossReasonMaint, (LossReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).Load(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((LossReasonMaint) null, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus Load(LossReasonMaint lossReasonMaint)
    {
      return this.Load(lossReasonMaint, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus Load(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.Load(lossReasonMaint, (LossReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_LoadESigDetails_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.LoadESigDetails, (LossReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((LossReasonMaint) null, (LossReasonMaint_LoadESigDetails_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(LossReasonMaint lossReasonMaint)
    {
      return this.LoadESigDetails(lossReasonMaint, (LossReasonMaint_LoadESigDetails_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.LoadESigDetails(lossReasonMaint, (LossReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).New(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((LossReasonMaint) null, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus New(LossReasonMaint lossReasonMaint)
    {
      return this.New(lossReasonMaint, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus New(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.New(lossReasonMaint, (LossReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).NewCopy(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((LossReasonMaint) null, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus NewCopy(LossReasonMaint lossReasonMaint)
    {
      return this.NewCopy(lossReasonMaint, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.NewCopy(lossReasonMaint, (LossReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).SaveAs(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((LossReasonMaint) null, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus SaveAs(LossReasonMaint lossReasonMaint)
    {
      return this.SaveAs(lossReasonMaint, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.SaveAs(lossReasonMaint, (LossReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Parameters parameters,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).UnFreeze(this._UserProfile, lossReasonMaint, parameters, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(lossReasonMaint, LossReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) lossReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((LossReasonMaint) null, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(LossReasonMaint lossReasonMaint)
    {
      return this.UnFreeze(lossReasonMaint, (LossReasonMaint_Parameters) null, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      LossReasonMaint lossReasonMaint,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.UnFreeze(lossReasonMaint, (LossReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((LossReasonMaint) lossReasonMaint, (LossReasonMaint_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((LossReasonMaint) lossReasonMaint, (LossReasonMaint_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((LossReasonMaint) lossReasonMaint, (LossReasonMaint_LoadESigDetails_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((LossReasonMaint) lossReasonMaint, (LossReasonMaint_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((LossReasonMaint) lossReasonMaint, (LossReasonMaint_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((LossReasonMaint) lossReasonMaint, (LossReasonMaint_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((LossReasonMaint) lossReasonMaint, (LossReasonMaint_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((LossReasonMaint) lossReasonMaint, (LossReasonMaint_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject lossReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        LossReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((LossReasonMaint) lossReasonMaint, (LossReasonMaint_Parameters) parameters, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      try
      {
        LossReasonMaintMethod[] methods = new LossReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ILossReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      LossReasonMaint cdo,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      try
      {
        return ((ILossReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        LossReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((LossReasonMaint) cdo, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.GetEnvironment((LossReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      LossReasonMaint cdo,
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      result = (LossReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ILossReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new LossReasonMaintMethod(cdo, LossReasonMaintMethods.ExecuteTransaction, (LossReasonMaint_Parameters) null));
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
        LossReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((LossReasonMaint) cdo, (LossReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(LossReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (LossReasonMaint_Request) null, out LossReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      LossReasonMaint_Request request,
      out LossReasonMaint_Result result)
    {
      return this.ExecuteTransaction((LossReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(LossReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new LossReasonMaintMethod(cdo, LossReasonMaintMethods.AddDataTransaction, (LossReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((LossReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.HoldReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class HoldReasonMaintService : UserCodeWithWMMaintBase
  {
    public HoldReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IHoldReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).Delete(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((HoldReasonMaint) null, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus Delete(HoldReasonMaint holdReasonMaint)
    {
      return this.Delete(holdReasonMaint, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus Delete(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.Delete(holdReasonMaint, (HoldReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).Freeze(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((HoldReasonMaint) null, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus Freeze(HoldReasonMaint holdReasonMaint)
    {
      return this.Freeze(holdReasonMaint, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.Freeze(holdReasonMaint, (HoldReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((HoldReasonMaint) null, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(HoldReasonMaint holdReasonMaint)
    {
      return this.GetWIPMsgs(holdReasonMaint, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.GetWIPMsgs(holdReasonMaint, (HoldReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).Load(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((HoldReasonMaint) null, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus Load(HoldReasonMaint holdReasonMaint)
    {
      return this.Load(holdReasonMaint, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus Load(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.Load(holdReasonMaint, (HoldReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_LoadESigDetails_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.LoadESigDetails, (HoldReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((HoldReasonMaint) null, (HoldReasonMaint_LoadESigDetails_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(HoldReasonMaint holdReasonMaint)
    {
      return this.LoadESigDetails(holdReasonMaint, (HoldReasonMaint_LoadESigDetails_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.LoadESigDetails(holdReasonMaint, (HoldReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).New(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((HoldReasonMaint) null, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus New(HoldReasonMaint holdReasonMaint)
    {
      return this.New(holdReasonMaint, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus New(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.New(holdReasonMaint, (HoldReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).NewCopy(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((HoldReasonMaint) null, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus NewCopy(HoldReasonMaint holdReasonMaint)
    {
      return this.NewCopy(holdReasonMaint, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.NewCopy(holdReasonMaint, (HoldReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).SaveAs(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((HoldReasonMaint) null, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus SaveAs(HoldReasonMaint holdReasonMaint)
    {
      return this.SaveAs(holdReasonMaint, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.SaveAs(holdReasonMaint, (HoldReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Parameters parameters,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).UnFreeze(this._UserProfile, holdReasonMaint, parameters, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(holdReasonMaint, HoldReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) holdReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((HoldReasonMaint) null, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(HoldReasonMaint holdReasonMaint)
    {
      return this.UnFreeze(holdReasonMaint, (HoldReasonMaint_Parameters) null, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      HoldReasonMaint holdReasonMaint,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.UnFreeze(holdReasonMaint, (HoldReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_LoadESigDetails_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject holdReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HoldReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((HoldReasonMaint) holdReasonMaint, (HoldReasonMaint_Parameters) parameters, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      try
      {
        HoldReasonMaintMethod[] methods = new HoldReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IHoldReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HoldReasonMaint cdo,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      try
      {
        return ((IHoldReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        HoldReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((HoldReasonMaint) cdo, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.GetEnvironment((HoldReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      HoldReasonMaint cdo,
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      result = (HoldReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHoldReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new HoldReasonMaintMethod(cdo, HoldReasonMaintMethods.ExecuteTransaction, (HoldReasonMaint_Parameters) null));
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
        HoldReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((HoldReasonMaint) cdo, (HoldReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(HoldReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (HoldReasonMaint_Request) null, out HoldReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      HoldReasonMaint_Request request,
      out HoldReasonMaint_Result result)
    {
      return this.ExecuteTransaction((HoldReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(HoldReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new HoldReasonMaintMethod(cdo, HoldReasonMaintMethods.AddDataTransaction, (HoldReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((HoldReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

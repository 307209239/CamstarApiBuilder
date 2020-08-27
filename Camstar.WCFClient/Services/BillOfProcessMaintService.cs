// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BillOfProcessMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BillOfProcessMaintService : RevisionedObjectMaintBase
  {
    public BillOfProcessMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBillOfProcessMaintService), userProfile);
    }

    public ResultStatus Delete(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).Delete(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus Delete(BillOfProcessMaint billOfProcessMaint)
    {
      return this.Delete(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus Delete(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.Delete(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(BillOfProcessMaint billOfProcessMaint)
    {
      return this.DeleteAllRevisions(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.DeleteAllRevisions(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).Freeze(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus Freeze(BillOfProcessMaint billOfProcessMaint)
    {
      return this.Freeze(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus Freeze(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.Freeze(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).GetWIPMsgs(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BillOfProcessMaint billOfProcessMaint)
    {
      return this.GetWIPMsgs(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.GetWIPMsgs(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).Load(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus Load(BillOfProcessMaint billOfProcessMaint)
    {
      return this.Load(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus Load(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.Load(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_LoadESigDetails_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).LoadESigDetails(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.LoadESigDetails, (BillOfProcessMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BillOfProcessMaint) null, (BillOfProcessMaint_LoadESigDetails_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BillOfProcessMaint billOfProcessMaint)
    {
      return this.LoadESigDetails(billOfProcessMaint, (BillOfProcessMaint_LoadESigDetails_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.LoadESigDetails(billOfProcessMaint, (BillOfProcessMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).New(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus New(BillOfProcessMaint billOfProcessMaint)
    {
      return this.New(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus New(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.New(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).NewCopy(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus NewCopy(BillOfProcessMaint billOfProcessMaint)
    {
      return this.NewCopy(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus NewCopy(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.NewCopy(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).NewRev(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus NewRev(BillOfProcessMaint billOfProcessMaint)
    {
      return this.NewRev(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus NewRev(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.NewRev(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).NewRevCopy(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus NewRevCopy(BillOfProcessMaint billOfProcessMaint)
    {
      return this.NewRevCopy(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.NewRevCopy(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).SaveAs(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus SaveAs(BillOfProcessMaint billOfProcessMaint)
    {
      return this.SaveAs(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus SaveAs(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.SaveAs(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).SaveAsRev(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus SaveAsRev(BillOfProcessMaint billOfProcessMaint)
    {
      return this.SaveAsRev(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.SaveAsRev(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Parameters parameters,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).UnFreeze(this._UserProfile, billOfProcessMaint, parameters, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(billOfProcessMaint, BillOfProcessMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) billOfProcessMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BillOfProcessMaint) null, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus UnFreeze(BillOfProcessMaint billOfProcessMaint)
    {
      return this.UnFreeze(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BillOfProcessMaint billOfProcessMaint,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.UnFreeze(billOfProcessMaint, (BillOfProcessMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_LoadESigDetails_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.New((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.Load((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject billOfProcessMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillOfProcessMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BillOfProcessMaint) billOfProcessMaint, (BillOfProcessMaint_Parameters) parameters, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      try
      {
        BillOfProcessMaintMethod[] methods = new BillOfProcessMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBillOfProcessMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BillOfProcessMaint cdo,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      try
      {
        return ((IBillOfProcessMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BillOfProcessMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BillOfProcessMaint) cdo, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.GetEnvironment((BillOfProcessMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BillOfProcessMaint cdo,
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      result = (BillOfProcessMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillOfProcessMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BillOfProcessMaintMethod(cdo, BillOfProcessMaintMethods.ExecuteTransaction, (BillOfProcessMaint_Parameters) null));
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
        BillOfProcessMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BillOfProcessMaint) cdo, (BillOfProcessMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BillOfProcessMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BillOfProcessMaint_Request) null, out BillOfProcessMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BillOfProcessMaint_Request request,
      out BillOfProcessMaint_Result result)
    {
      return this.ExecuteTransaction((BillOfProcessMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BillOfProcessMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BillOfProcessMaintMethod(cdo, BillOfProcessMaintMethods.AddDataTransaction, (BillOfProcessMaint_Parameters) null));
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
        return this.AddDataTransaction((BillOfProcessMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

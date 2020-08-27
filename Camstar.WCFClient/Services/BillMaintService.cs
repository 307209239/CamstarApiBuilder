// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BillMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BillMaintService : RevisionedObjectMaintBase
  {
    public BillMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBillMaintService), userProfile);
    }

    public ResultStatus Delete(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).Delete(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus Delete(BillMaint billMaint)
    {
      return this.Delete(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus Delete(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.Delete(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(BillMaint billMaint)
    {
      return this.DeleteAllRevisions(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.DeleteAllRevisions(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).Freeze(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus Freeze(BillMaint billMaint)
    {
      return this.Freeze(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus Freeze(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.Freeze(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).GetWIPMsgs(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BillMaint billMaint)
    {
      return this.GetWIPMsgs(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.GetWIPMsgs(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).Load(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus Load(BillMaint billMaint)
    {
      return this.Load(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus Load(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.Load(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BillMaint billMaint,
      BillMaint_LoadESigDetails_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).LoadESigDetails(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.LoadESigDetails, (BillMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BillMaint) null, (BillMaint_LoadESigDetails_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BillMaint billMaint)
    {
      return this.LoadESigDetails(billMaint, (BillMaint_LoadESigDetails_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.LoadESigDetails(billMaint, (BillMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).New(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus New(BillMaint billMaint)
    {
      return this.New(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus New(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.New(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).NewCopy(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus NewCopy(BillMaint billMaint)
    {
      return this.NewCopy(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus NewCopy(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.NewCopy(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).NewRev(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus NewRev(BillMaint billMaint)
    {
      return this.NewRev(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus NewRev(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.NewRev(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).NewRevCopy(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus NewRevCopy(BillMaint billMaint)
    {
      return this.NewRevCopy(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.NewRevCopy(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).SaveAs(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus SaveAs(BillMaint billMaint)
    {
      return this.SaveAs(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus SaveAs(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.SaveAs(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).SaveAsRev(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus SaveAsRev(BillMaint billMaint)
    {
      return this.SaveAsRev(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.SaveAsRev(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BillMaint billMaint,
      BillMaint_Parameters parameters,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) billMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).UnFreeze(this._UserProfile, billMaint, parameters, request, out result) : this.AddMethod((Method) new BillMaintMethod(billMaint, BillMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) billMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BillMaint) null, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus UnFreeze(BillMaint billMaint)
    {
      return this.UnFreeze(billMaint, (BillMaint_Parameters) null, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BillMaint billMaint,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.UnFreeze(billMaint, (BillMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BillMaint) billMaint, (BillMaint_LoadESigDetails_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.New((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus resultStatus = this.Load((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject billMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BillMaint) billMaint, (BillMaint_Parameters) parameters, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      try
      {
        BillMaintMethod[] methods = new BillMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBillMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BillMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BillMaint cdo,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      try
      {
        return ((IBillMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BillMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BillMaint) cdo, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.GetEnvironment((BillMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BillMaint cdo,
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      result = (BillMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BillMaintMethod(cdo, BillMaintMethods.ExecuteTransaction, (BillMaint_Parameters) null));
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
        BillMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BillMaint) cdo, (BillMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BillMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BillMaint_Request) null, out BillMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BillMaint_Request request,
      out BillMaint_Result result)
    {
      return this.ExecuteTransaction((BillMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BillMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BillMaintMethod(cdo, BillMaintMethods.AddDataTransaction, (BillMaint_Parameters) null));
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
        return this.AddDataTransaction((BillMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

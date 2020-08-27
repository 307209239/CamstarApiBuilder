// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ERPRouteMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ERPRouteMaintService : RevisionedObjectMaintBase
  {
    public ERPRouteMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IERPRouteMaintService), userProfile);
    }

    public ResultStatus Delete(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).Delete(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus Delete(ERPRouteMaint eRPRouteMaint)
    {
      return this.Delete(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus Delete(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.Delete(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ERPRouteMaint eRPRouteMaint)
    {
      return this.DeleteAllRevisions(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.DeleteAllRevisions(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).Freeze(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus Freeze(ERPRouteMaint eRPRouteMaint)
    {
      return this.Freeze(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus Freeze(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.Freeze(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ERPRouteMaint eRPRouteMaint)
    {
      return this.GetWIPMsgs(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.GetWIPMsgs(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).Load(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus Load(ERPRouteMaint eRPRouteMaint)
    {
      return this.Load(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus Load(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.Load(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_LoadESigDetails_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).LoadESigDetails(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.LoadESigDetails, (ERPRouteMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ERPRouteMaint) null, (ERPRouteMaint_LoadESigDetails_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ERPRouteMaint eRPRouteMaint)
    {
      return this.LoadESigDetails(eRPRouteMaint, (ERPRouteMaint_LoadESigDetails_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.LoadESigDetails(eRPRouteMaint, (ERPRouteMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).New(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus New(ERPRouteMaint eRPRouteMaint)
    {
      return this.New(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus New(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.New(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).NewCopy(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus NewCopy(ERPRouteMaint eRPRouteMaint)
    {
      return this.NewCopy(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus NewCopy(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.NewCopy(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).NewRev(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus NewRev(ERPRouteMaint eRPRouteMaint)
    {
      return this.NewRev(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus NewRev(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.NewRev(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).NewRevCopy(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus NewRevCopy(ERPRouteMaint eRPRouteMaint)
    {
      return this.NewRevCopy(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.NewRevCopy(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).SaveAs(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus SaveAs(ERPRouteMaint eRPRouteMaint)
    {
      return this.SaveAs(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus SaveAs(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.SaveAs(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).SaveAsRev(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus SaveAsRev(ERPRouteMaint eRPRouteMaint)
    {
      return this.SaveAsRev(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.SaveAsRev(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Parameters parameters,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).UnFreeze(this._UserProfile, eRPRouteMaint, parameters, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(eRPRouteMaint, ERPRouteMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eRPRouteMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ERPRouteMaint) null, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus UnFreeze(ERPRouteMaint eRPRouteMaint)
    {
      return this.UnFreeze(eRPRouteMaint, (ERPRouteMaint_Parameters) null, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ERPRouteMaint eRPRouteMaint,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.UnFreeze(eRPRouteMaint, (ERPRouteMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_LoadESigDetails_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.New((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.Load((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eRPRouteMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPRouteMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ERPRouteMaint) eRPRouteMaint, (ERPRouteMaint_Parameters) parameters, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      try
      {
        ERPRouteMaintMethod[] methods = new ERPRouteMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IERPRouteMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ERPRouteMaint cdo,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      try
      {
        return ((IERPRouteMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ERPRouteMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ERPRouteMaint) cdo, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.GetEnvironment((ERPRouteMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ERPRouteMaint cdo,
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      result = (ERPRouteMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPRouteMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ERPRouteMaintMethod(cdo, ERPRouteMaintMethods.ExecuteTransaction, (ERPRouteMaint_Parameters) null));
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
        ERPRouteMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ERPRouteMaint) cdo, (ERPRouteMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ERPRouteMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ERPRouteMaint_Request) null, out ERPRouteMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ERPRouteMaint_Request request,
      out ERPRouteMaint_Result result)
    {
      return this.ExecuteTransaction((ERPRouteMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ERPRouteMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ERPRouteMaintMethod(cdo, ERPRouteMaintMethods.AddDataTransaction, (ERPRouteMaint_Parameters) null));
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
        return this.AddDataTransaction((ERPRouteMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

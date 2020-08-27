// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ERPBOMMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ERPBOMMaintService : BillMaintBase
  {
    public ERPBOMMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IERPBOMMaintService), userProfile);
    }

    public ResultStatus Delete(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).Delete(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus Delete(ERPBOMMaint eRPBOMMaint)
    {
      return this.Delete(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus Delete(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.Delete(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(ERPBOMMaint eRPBOMMaint)
    {
      return this.DeleteAllRevisions(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.DeleteAllRevisions(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).Freeze(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus Freeze(ERPBOMMaint eRPBOMMaint)
    {
      return this.Freeze(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus Freeze(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.Freeze(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ERPBOMMaint eRPBOMMaint)
    {
      return this.GetWIPMsgs(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.GetWIPMsgs(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).Load(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus Load(ERPBOMMaint eRPBOMMaint)
    {
      return this.Load(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus Load(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.Load(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_LoadESigDetails_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).LoadESigDetails(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.LoadESigDetails, (ERPBOMMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ERPBOMMaint) null, (ERPBOMMaint_LoadESigDetails_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ERPBOMMaint eRPBOMMaint)
    {
      return this.LoadESigDetails(eRPBOMMaint, (ERPBOMMaint_LoadESigDetails_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.LoadESigDetails(eRPBOMMaint, (ERPBOMMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).New(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus New(ERPBOMMaint eRPBOMMaint)
    {
      return this.New(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus New(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.New(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).NewCopy(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus NewCopy(ERPBOMMaint eRPBOMMaint)
    {
      return this.NewCopy(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus NewCopy(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.NewCopy(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).NewRev(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus NewRev(ERPBOMMaint eRPBOMMaint)
    {
      return this.NewRev(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus NewRev(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.NewRev(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).NewRevCopy(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus NewRevCopy(ERPBOMMaint eRPBOMMaint)
    {
      return this.NewRevCopy(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.NewRevCopy(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).SaveAs(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus SaveAs(ERPBOMMaint eRPBOMMaint)
    {
      return this.SaveAs(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus SaveAs(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.SaveAs(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).SaveAsRev(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus SaveAsRev(ERPBOMMaint eRPBOMMaint)
    {
      return this.SaveAsRev(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.SaveAsRev(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Parameters parameters,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).UnFreeze(this._UserProfile, eRPBOMMaint, parameters, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(eRPBOMMaint, ERPBOMMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eRPBOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ERPBOMMaint) null, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus UnFreeze(ERPBOMMaint eRPBOMMaint)
    {
      return this.UnFreeze(eRPBOMMaint, (ERPBOMMaint_Parameters) null, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ERPBOMMaint eRPBOMMaint,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.UnFreeze(eRPBOMMaint, (ERPBOMMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_LoadESigDetails_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.New((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.Load((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eRPBOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ERPBOMMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ERPBOMMaint) eRPBOMMaint, (ERPBOMMaint_Parameters) parameters, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      try
      {
        ERPBOMMaintMethod[] methods = new ERPBOMMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IERPBOMMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ERPBOMMaint cdo,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      try
      {
        return ((IERPBOMMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ERPBOMMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ERPBOMMaint) cdo, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.GetEnvironment((ERPBOMMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ERPBOMMaint cdo,
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      result = (ERPBOMMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IERPBOMMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ERPBOMMaintMethod(cdo, ERPBOMMaintMethods.ExecuteTransaction, (ERPBOMMaint_Parameters) null));
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
        ERPBOMMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ERPBOMMaint) cdo, (ERPBOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ERPBOMMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ERPBOMMaint_Request) null, out ERPBOMMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ERPBOMMaint_Request request,
      out ERPBOMMaint_Result result)
    {
      return this.ExecuteTransaction((ERPBOMMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ERPBOMMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ERPBOMMaintMethod(cdo, ERPBOMMaintMethods.AddDataTransaction, (ERPBOMMaint_Parameters) null));
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
        return this.AddDataTransaction((ERPBOMMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

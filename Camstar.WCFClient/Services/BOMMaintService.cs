// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BOMMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BOMMaintService : BillMaintBase
  {
    public BOMMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBOMMaintService), userProfile);
    }

    public ResultStatus Delete(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).Delete(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus Delete(BOMMaint bOMMaint)
    {
      return this.Delete(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus Delete(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.Delete(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(BOMMaint bOMMaint)
    {
      return this.DeleteAllRevisions(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.DeleteAllRevisions(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).Freeze(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus Freeze(BOMMaint bOMMaint)
    {
      return this.Freeze(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus Freeze(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.Freeze(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).GetWIPMsgs(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BOMMaint bOMMaint)
    {
      return this.GetWIPMsgs(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.GetWIPMsgs(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).Load(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus Load(BOMMaint bOMMaint)
    {
      return this.Load(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus Load(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.Load(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BOMMaint bOMMaint,
      BOMMaint_LoadESigDetails_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).LoadESigDetails(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.LoadESigDetails, (BOMMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BOMMaint) null, (BOMMaint_LoadESigDetails_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BOMMaint bOMMaint)
    {
      return this.LoadESigDetails(bOMMaint, (BOMMaint_LoadESigDetails_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.LoadESigDetails(bOMMaint, (BOMMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).New(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus New(BOMMaint bOMMaint)
    {
      return this.New(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus New(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.New(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).NewCopy(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus NewCopy(BOMMaint bOMMaint)
    {
      return this.NewCopy(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus NewCopy(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.NewCopy(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).NewRev(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus NewRev(BOMMaint bOMMaint)
    {
      return this.NewRev(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus NewRev(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.NewRev(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).NewRevCopy(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus NewRevCopy(BOMMaint bOMMaint)
    {
      return this.NewRevCopy(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.NewRevCopy(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).SaveAs(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus SaveAs(BOMMaint bOMMaint)
    {
      return this.SaveAs(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus SaveAs(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.SaveAs(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).SaveAsRev(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus SaveAsRev(BOMMaint bOMMaint)
    {
      return this.SaveAsRev(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.SaveAsRev(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BOMMaint bOMMaint,
      BOMMaint_Parameters parameters,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) bOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).UnFreeze(this._UserProfile, bOMMaint, parameters, request, out result) : this.AddMethod((Method) new BOMMaintMethod(bOMMaint, BOMMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) bOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BOMMaint) null, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus UnFreeze(BOMMaint bOMMaint)
    {
      return this.UnFreeze(bOMMaint, (BOMMaint_Parameters) null, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BOMMaint bOMMaint,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.UnFreeze(bOMMaint, (BOMMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BOMMaint) bOMMaint, (BOMMaint_LoadESigDetails_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.New((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.Load((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject bOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BOMMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BOMMaint) bOMMaint, (BOMMaint_Parameters) parameters, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      try
      {
        BOMMaintMethod[] methods = new BOMMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBOMMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BOMMaint cdo,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      try
      {
        return ((IBOMMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BOMMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BOMMaint) cdo, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.GetEnvironment((BOMMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BOMMaint cdo,
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      result = (BOMMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBOMMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BOMMaintMethod(cdo, BOMMaintMethods.ExecuteTransaction, (BOMMaint_Parameters) null));
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
        BOMMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BOMMaint) cdo, (BOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BOMMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BOMMaint_Request) null, out BOMMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BOMMaint_Request request,
      out BOMMaint_Result result)
    {
      return this.ExecuteTransaction((BOMMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BOMMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BOMMaintMethod(cdo, BOMMaintMethods.AddDataTransaction, (BOMMaint_Parameters) null));
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
        return this.AddDataTransaction((BOMMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

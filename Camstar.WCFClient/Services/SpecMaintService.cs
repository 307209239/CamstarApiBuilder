// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SpecMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SpecMaintService : BusinessProcessSpecMaintBase
  {
    public SpecMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISpecMaintService), userProfile);
    }

    public ResultStatus Delete(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).Delete(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus Delete(SpecMaint specMaint)
    {
      return this.Delete(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus Delete(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.Delete(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(SpecMaint specMaint)
    {
      return this.DeleteAllRevisions(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.DeleteAllRevisions(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).Freeze(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus Freeze(SpecMaint specMaint)
    {
      return this.Freeze(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus Freeze(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.Freeze(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).GetWIPMsgs(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SpecMaint specMaint)
    {
      return this.GetWIPMsgs(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.GetWIPMsgs(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).Load(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus Load(SpecMaint specMaint)
    {
      return this.Load(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus Load(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.Load(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SpecMaint specMaint,
      SpecMaint_LoadESigDetails_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).LoadESigDetails(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.LoadESigDetails, (SpecMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SpecMaint) null, (SpecMaint_LoadESigDetails_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SpecMaint specMaint)
    {
      return this.LoadESigDetails(specMaint, (SpecMaint_LoadESigDetails_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.LoadESigDetails(specMaint, (SpecMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).New(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus New(SpecMaint specMaint)
    {
      return this.New(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus New(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.New(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).NewCopy(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus NewCopy(SpecMaint specMaint)
    {
      return this.NewCopy(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus NewCopy(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.NewCopy(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).NewRev(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus NewRev(SpecMaint specMaint)
    {
      return this.NewRev(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus NewRev(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.NewRev(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).NewRevCopy(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus NewRevCopy(SpecMaint specMaint)
    {
      return this.NewRevCopy(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.NewRevCopy(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).SaveAs(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus SaveAs(SpecMaint specMaint)
    {
      return this.SaveAs(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus SaveAs(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.SaveAs(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).SaveAsRev(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus SaveAsRev(SpecMaint specMaint)
    {
      return this.SaveAsRev(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.SaveAsRev(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus SetCDOTypeName(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (SetCDOTypeName), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).SetCDOTypeName(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.SetCDOTypeName, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetCDOTypeName), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetCDOTypeName()
    {
      return this.SetCDOTypeName((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus SetCDOTypeName(SpecMaint specMaint)
    {
      return this.SetCDOTypeName(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus SetCDOTypeName(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.SetCDOTypeName(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) specMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).UnFreeze(this._UserProfile, specMaint, parameters, request, out result) : this.AddMethod((Method) new SpecMaintMethod(specMaint, SpecMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) specMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SpecMaint) null, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus UnFreeze(SpecMaint specMaint)
    {
      return this.UnFreeze(specMaint, (SpecMaint_Parameters) null, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.UnFreeze(specMaint, (SpecMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SpecMaint) specMaint, (SpecMaint_LoadESigDetails_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.New((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.Load((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject specMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SpecMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SpecMaint) specMaint, (SpecMaint_Parameters) parameters, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      try
      {
        SpecMaintMethod[] methods = new SpecMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISpecMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SpecMaint cdo,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      try
      {
        return ((ISpecMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SpecMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SpecMaint) cdo, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.GetEnvironment((SpecMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SpecMaint cdo,
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      result = (SpecMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISpecMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SpecMaintMethod(cdo, SpecMaintMethods.ExecuteTransaction, (SpecMaint_Parameters) null));
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
        SpecMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SpecMaint) cdo, (SpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SpecMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SpecMaint_Request) null, out SpecMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SpecMaint_Request request,
      out SpecMaint_Result result)
    {
      return this.ExecuteTransaction((SpecMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SpecMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SpecMaintMethod(cdo, SpecMaintMethods.AddDataTransaction, (SpecMaint_Parameters) null));
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
        return this.AddDataTransaction((SpecMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

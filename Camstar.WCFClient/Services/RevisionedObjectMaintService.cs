// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RevisionedObjectMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RevisionedObjectMaintService : MaintenanceBase
  {
    public RevisionedObjectMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRevisionedObjectMaintService), userProfile);
    }

    public ResultStatus Delete(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).Delete(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus Delete(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.Delete(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus Delete(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.Delete(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.DeleteAllRevisions(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.DeleteAllRevisions(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).Freeze(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus Freeze(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.Freeze(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus Freeze(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.Freeze(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).GetWIPMsgs(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.GetWIPMsgs(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.GetWIPMsgs(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).Load(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus Load(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.Load(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus Load(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.Load(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_LoadESigDetails_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).LoadESigDetails(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.LoadESigDetails, (RevisionedObjectMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RevisionedObjectMaint) null, (RevisionedObjectMaint_LoadESigDetails_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.LoadESigDetails(revisionedObjectMaint, (RevisionedObjectMaint_LoadESigDetails_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.LoadESigDetails(revisionedObjectMaint, (RevisionedObjectMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).New(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus New(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.New(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus New(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.New(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).NewCopy(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus NewCopy(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.NewCopy(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus NewCopy(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.NewCopy(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).NewRev(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus NewRev(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.NewRev(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus NewRev(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.NewRev(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).NewRevCopy(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus NewRevCopy(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.NewRevCopy(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.NewRevCopy(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).SaveAs(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus SaveAs(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.SaveAs(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus SaveAs(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.SaveAs(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).SaveAsRev(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus SaveAsRev(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.SaveAsRev(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.SaveAsRev(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).UnFreeze(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus UnFreeze(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.UnFreeze(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.UnFreeze(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateLock(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateLock), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).ValidateLock(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.ValidateLock, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateLock), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateLock()
    {
      return this.ValidateLock((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus ValidateLock(RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.ValidateLock(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus ValidateLock(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.ValidateLock(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateMasterDataCatalog(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Parameters parameters,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateMasterDataCatalog), (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).ValidateMasterDataCatalog(this._UserProfile, revisionedObjectMaint, parameters, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(revisionedObjectMaint, RevisionedObjectMaintMethods.ValidateMasterDataCatalog, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateMasterDataCatalog), res, (DCObject) revisionedObjectMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateMasterDataCatalog()
    {
      return this.ValidateMasterDataCatalog((RevisionedObjectMaint) null, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus ValidateMasterDataCatalog(
      RevisionedObjectMaint revisionedObjectMaint)
    {
      return this.ValidateMasterDataCatalog(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus ValidateMasterDataCatalog(
      RevisionedObjectMaint revisionedObjectMaint,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.ValidateMasterDataCatalog(revisionedObjectMaint, (RevisionedObjectMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_LoadESigDetails_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.New((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.Load((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject revisionedObjectMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RevisionedObjectMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RevisionedObjectMaint) revisionedObjectMaint, (RevisionedObjectMaint_Parameters) parameters, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      try
      {
        RevisionedObjectMaintMethod[] methods = new RevisionedObjectMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRevisionedObjectMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RevisionedObjectMaint cdo,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      try
      {
        return ((IRevisionedObjectMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RevisionedObjectMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RevisionedObjectMaint) cdo, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.GetEnvironment((RevisionedObjectMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RevisionedObjectMaint cdo,
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      result = (RevisionedObjectMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRevisionedObjectMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RevisionedObjectMaintMethod(cdo, RevisionedObjectMaintMethods.ExecuteTransaction, (RevisionedObjectMaint_Parameters) null));
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
        RevisionedObjectMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RevisionedObjectMaint) cdo, (RevisionedObjectMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RevisionedObjectMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RevisionedObjectMaint_Request) null, out RevisionedObjectMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RevisionedObjectMaint_Request request,
      out RevisionedObjectMaint_Result result)
    {
      return this.ExecuteTransaction((RevisionedObjectMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RevisionedObjectMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RevisionedObjectMaintMethod(cdo, RevisionedObjectMaintMethods.AddDataTransaction, (RevisionedObjectMaint_Parameters) null));
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
        return this.AddDataTransaction((RevisionedObjectMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

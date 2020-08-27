// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DocumentMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DocumentMaintService : RevisionedObjectMaintBase
  {
    public DocumentMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDocumentMaintService), userProfile);
    }

    public ResultStatus Delete(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).Delete(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus Delete(DocumentMaint documentMaint)
    {
      return this.Delete(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus Delete(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.Delete(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(DocumentMaint documentMaint)
    {
      return this.DeleteAllRevisions(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.DeleteAllRevisions(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus DocumentMaint_Validations(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (DocumentMaint_Validations), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).DocumentMaint_Validations(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.DocumentMaint_Validations, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DocumentMaint_Validations), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DocumentMaint_Validations()
    {
      return this.DocumentMaint_Validations((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus DocumentMaint_Validations(DocumentMaint documentMaint)
    {
      return this.DocumentMaint_Validations(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus DocumentMaint_Validations(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.DocumentMaint_Validations(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus DownloadFile(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (DownloadFile), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).DownloadFile(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.DownloadFile, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DownloadFile), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DownloadFile()
    {
      return this.DownloadFile((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus DownloadFile(DocumentMaint documentMaint)
    {
      return this.DownloadFile(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus DownloadFile(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.DownloadFile(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).Freeze(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus Freeze(DocumentMaint documentMaint)
    {
      return this.Freeze(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus Freeze(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.Freeze(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).GetWIPMsgs(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DocumentMaint documentMaint)
    {
      return this.GetWIPMsgs(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.GetWIPMsgs(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).Load(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus Load(DocumentMaint documentMaint)
    {
      return this.Load(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus Load(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.Load(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DocumentMaint documentMaint,
      DocumentMaint_LoadESigDetails_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).LoadESigDetails(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.LoadESigDetails, (DocumentMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DocumentMaint) null, (DocumentMaint_LoadESigDetails_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DocumentMaint documentMaint)
    {
      return this.LoadESigDetails(documentMaint, (DocumentMaint_LoadESigDetails_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.LoadESigDetails(documentMaint, (DocumentMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).New(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus New(DocumentMaint documentMaint)
    {
      return this.New(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus New(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.New(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).NewCopy(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus NewCopy(DocumentMaint documentMaint)
    {
      return this.NewCopy(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus NewCopy(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.NewCopy(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).NewRev(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus NewRev(DocumentMaint documentMaint)
    {
      return this.NewRev(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus NewRev(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.NewRev(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).NewRevCopy(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus NewRevCopy(DocumentMaint documentMaint)
    {
      return this.NewRevCopy(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.NewRevCopy(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).SaveAs(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus SaveAs(DocumentMaint documentMaint)
    {
      return this.SaveAs(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus SaveAs(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.SaveAs(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).SaveAsRev(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus SaveAsRev(DocumentMaint documentMaint)
    {
      return this.SaveAsRev(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.SaveAsRev(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).UnFreeze(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus UnFreeze(DocumentMaint documentMaint)
    {
      return this.UnFreeze(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.UnFreeze(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    public ResultStatus UploadFile(
      DocumentMaint documentMaint,
      DocumentMaint_Parameters parameters,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (UploadFile), (DCObject) documentMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).UploadFile(this._UserProfile, documentMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(documentMaint, DocumentMaintMethods.UploadFile, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UploadFile), res, (DCObject) documentMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UploadFile()
    {
      return this.UploadFile((DocumentMaint) null, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus UploadFile(DocumentMaint documentMaint)
    {
      return this.UploadFile(documentMaint, (DocumentMaint_Parameters) null, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus UploadFile(
      DocumentMaint documentMaint,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.UploadFile(documentMaint, (DocumentMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DocumentMaint) documentMaint, (DocumentMaint_LoadESigDetails_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.New((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.Load((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject documentMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DocumentMaint) documentMaint, (DocumentMaint_Parameters) parameters, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      try
      {
        DocumentMaintMethod[] methods = new DocumentMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDocumentMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DocumentMaint cdo,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      try
      {
        return ((IDocumentMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DocumentMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DocumentMaint) cdo, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.GetEnvironment((DocumentMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DocumentMaint cdo,
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      result = (DocumentMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DocumentMaintMethod(cdo, DocumentMaintMethods.ExecuteTransaction, (DocumentMaint_Parameters) null));
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
        DocumentMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DocumentMaint) cdo, (DocumentMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DocumentMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DocumentMaint_Request) null, out DocumentMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DocumentMaint_Request request,
      out DocumentMaint_Result result)
    {
      return this.ExecuteTransaction((DocumentMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DocumentMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DocumentMaintMethod(cdo, DocumentMaintMethods.AddDataTransaction, (DocumentMaint_Parameters) null));
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
        return this.AddDataTransaction((DocumentMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}

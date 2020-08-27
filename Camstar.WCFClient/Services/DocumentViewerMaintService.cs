// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DocumentViewerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DocumentViewerMaintService : NamedDataObjectMaintBase
  {
    public DocumentViewerMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDocumentViewerMaintService), userProfile);
    }

    public ResultStatus Delete(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).Delete(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DocumentViewerMaint) null, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus Delete(DocumentViewerMaint documentViewerMaint)
    {
      return this.Delete(documentViewerMaint, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus Delete(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.Delete(documentViewerMaint, (DocumentViewerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).Freeze(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DocumentViewerMaint) null, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus Freeze(DocumentViewerMaint documentViewerMaint)
    {
      return this.Freeze(documentViewerMaint, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus Freeze(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.Freeze(documentViewerMaint, (DocumentViewerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).GetWIPMsgs(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DocumentViewerMaint) null, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DocumentViewerMaint documentViewerMaint)
    {
      return this.GetWIPMsgs(documentViewerMaint, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.GetWIPMsgs(documentViewerMaint, (DocumentViewerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).Load(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DocumentViewerMaint) null, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus Load(DocumentViewerMaint documentViewerMaint)
    {
      return this.Load(documentViewerMaint, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus Load(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.Load(documentViewerMaint, (DocumentViewerMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_LoadESigDetails_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).LoadESigDetails(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.LoadESigDetails, (DocumentViewerMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DocumentViewerMaint) null, (DocumentViewerMaint_LoadESigDetails_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DocumentViewerMaint documentViewerMaint)
    {
      return this.LoadESigDetails(documentViewerMaint, (DocumentViewerMaint_LoadESigDetails_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.LoadESigDetails(documentViewerMaint, (DocumentViewerMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).New(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DocumentViewerMaint) null, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus New(DocumentViewerMaint documentViewerMaint)
    {
      return this.New(documentViewerMaint, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus New(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.New(documentViewerMaint, (DocumentViewerMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).NewCopy(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DocumentViewerMaint) null, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus NewCopy(DocumentViewerMaint documentViewerMaint)
    {
      return this.NewCopy(documentViewerMaint, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus NewCopy(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.NewCopy(documentViewerMaint, (DocumentViewerMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).SaveAs(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DocumentViewerMaint) null, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus SaveAs(DocumentViewerMaint documentViewerMaint)
    {
      return this.SaveAs(documentViewerMaint, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus SaveAs(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.SaveAs(documentViewerMaint, (DocumentViewerMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Parameters parameters,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).UnFreeze(this._UserProfile, documentViewerMaint, parameters, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(documentViewerMaint, DocumentViewerMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) documentViewerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DocumentViewerMaint) null, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus UnFreeze(DocumentViewerMaint documentViewerMaint)
    {
      return this.UnFreeze(documentViewerMaint, (DocumentViewerMaint_Parameters) null, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DocumentViewerMaint documentViewerMaint,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.UnFreeze(documentViewerMaint, (DocumentViewerMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_LoadESigDetails_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.New((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.Load((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject documentViewerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DocumentViewerMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DocumentViewerMaint) documentViewerMaint, (DocumentViewerMaint_Parameters) parameters, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      try
      {
        DocumentViewerMaintMethod[] methods = new DocumentViewerMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDocumentViewerMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DocumentViewerMaint cdo,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      try
      {
        return ((IDocumentViewerMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DocumentViewerMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DocumentViewerMaint) cdo, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.GetEnvironment((DocumentViewerMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DocumentViewerMaint cdo,
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      result = (DocumentViewerMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDocumentViewerMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DocumentViewerMaintMethod(cdo, DocumentViewerMaintMethods.ExecuteTransaction, (DocumentViewerMaint_Parameters) null));
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
        DocumentViewerMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DocumentViewerMaint) cdo, (DocumentViewerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DocumentViewerMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DocumentViewerMaint_Request) null, out DocumentViewerMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DocumentViewerMaint_Request request,
      out DocumentViewerMaint_Result result)
    {
      return this.ExecuteTransaction((DocumentViewerMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DocumentViewerMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DocumentViewerMaintMethod(cdo, DocumentViewerMaintMethods.AddDataTransaction, (DocumentViewerMaint_Parameters) null));
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
        return this.AddDataTransaction((DocumentViewerMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
